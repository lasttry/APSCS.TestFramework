using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using APSCS.OpenAPI;
using System.Dynamic;

namespace APSCS.TestFramework
{
    public partial class APSCS : Form
    {
        private DB.Database db;

        public APSCS()
        {
            db = new DB.Database();

            InitializeComponent();
            this.cbOSAServers.DataSource = db.OSASettings_Get();
            this.cbOSAServers.DisplayMember = "name";

            string lastAPSPackage = Settings.GetLastAPSPackage();
            if (lastAPSPackage.Length != 0)
                this.txtAPSPackage.Text = lastAPSPackage;
            FillConfiguration();
        }

        internal void FillConfiguration()
        {
            DataTable dt = db.ASPPackages_Get();
            DataRow dr = dt.NewRow();
            dr["id"] = -1;
            dr["name"] = "NEW...";
            dt.Rows.Add(dr);
            this.cbConfiguration.DataSource = dt;

            this.cbConfiguration.DisplayMember = "name";

            FillAPSSettings();
        }

        internal void FillAPSSettings()
        {
            DataRowView drvConfig = this.cbConfiguration.SelectedValue as DataRowView;

            DataTable dt = db.APSSettings_Get(drvConfig["id"].ToString());
            dt.Columns.Add("setting");
            foreach (DataRow dr in dt.Rows)
                dr["setting"] = dr["name"] + " = " + dr["value"];

            this.lsbParameters.DataSource = dt;
            this.lsbParameters.DisplayMember = "setting";
        }

        internal void FillAPSResources()
        {
            DataRowView drvConfig = this.cbConfiguration.SelectedValue as DataRowView;
            this.lsbResources.DataSource = db.APSResources_Get(drvConfig["id"].ToString());
            this.lsbResources.DisplayMember = "type";
        }

        internal void FillAPSResourceProperty()
        {
            DataRowView drvResource = this.lsbResources.SelectedValue as DataRowView;
            if (drvResource == null)
            {
                this.lsbResourceProperties.DataSource = null;
                this.lsbResourceProperties.Items.Clear();
                return;
            }
            DataTable dt = db.APSResourceProperties_Get(drvResource["id"].ToString());

            dt.Columns.Add("property");
            foreach (DataRow dr in dt.Rows)
                dr["property"] = dr["name"] + " = " + dr["value"];

            this.lsbResourceProperties.DataSource = dt;
            this.lsbResourceProperties.DisplayMember = "property";
        }

        private void bttAddOSA_Click(object sender, EventArgs e)
        {
            frmOSAServer frmOSA = new frmOSAServer();
            frmOSA.ShowDialog();
            this.cbOSAServers.DataSource = db.OSASettings_Get();
        }

        private void cbOSAServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblServerDetails.Text = ((DataRowView)cbOSAServers.SelectedValue)["poa_hostname"] + "/" + ((DataRowView)cbOSAServers.SelectedValue)["endpoint_hostname"];
        }

        private void bttOpenAPS_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "APS Package (app.zip)|*.app.zip";
            ofd.FilterIndex = 1;
            ofd.Multiselect = false;
            DialogResult userClickedOK = ofd.ShowDialog();
            if (userClickedOK == System.Windows.Forms.DialogResult.OK)
            {
                this.txtAPSPackage.Text = ofd.FileName;
                Settings.SetLastAPSPackage(ofd.FileName);
            }
        }

        private void txtAPSPackage_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ckbDeployEndpoint_CheckedChanged(object sender, EventArgs e)
        {
            if (this.txtAPSPackage.Text.Length == 0)
            {
                ckbDeployEndpoint.Checked = false;
                return;
            }
            string apsPackage = Path.GetFileNameWithoutExtension(txtAPSPackage.Text);
            txtEndpointName.Text = apsPackage.Substring(0, apsPackage.IndexOf('-'));
        }

        public class aps
        {
            public string id { get; set; }
            public string type { get; set; }
            public string status { get; set; }
            public string revision { get; set; }
            public string modified { get; set; }
        }

        private void bttDeploy_Click(object sender, EventArgs e)
        {
            string poaHostname = ((DataRowView)cbOSAServers.SelectedValue)["poa_hostname"].ToString();
            string poaPassword = ((DataRowView)cbOSAServers.SelectedValue)["poa_password"].ToString();
            string endpointHostname = ((DataRowView)cbOSAServers.SelectedValue)["endpoint_hostname"].ToString();
            string endpointPassword = ((DataRowView)cbOSAServers.SelectedValue)["endpoint_password"].ToString();
            string APSUrl = "";
            string EndpointUrl = "";
            int application_id = 0;
            XmlRPC xml = new XmlRPC("http://" + poaHostname + ":8440/RPC2");
            SSHCommunication ssh;

            OpenAPI.pem.getAccountTokenResponse accountTokenResponse = xml.getAccountToken(1, 1);

            lsbStatus.Items.Insert(0, "account Token: " + accountTokenResponse.aps_token);
            lsbStatus.Items.Insert(0, "controller Uri: " + accountTokenResponse.controller_uri);

            string accountToken = accountTokenResponse.aps_token;
            string controllerUri = accountTokenResponse.controller_uri;

            APSController.Controller c = new APSController.Controller(controllerUri, accountToken);

            foreach(DataRowView drvResource in lsbResources.Items)
            {
                var newResource = new ExpandoObject() as IDictionary<string, Object>;
                newResource.Add("aps", new aps()
                {
                    type = drvResource["type"].ToString()
                });

                foreach(DataRow dr in db.APSResourceProperties_Get(drvResource["id"].ToString()).Rows)
                {
                    newResource.Add(dr["name"].ToString(), dr["value"].ToString());
                }
                c.Resources.CreateResource(newResource);
            }
            

            //return;

            pbDeployment.Step = 10;

            lsbStatus.Items.Insert(0, "Checking APS Package...");
            if (!File.Exists(txtAPSPackage.Text))
            {
                pbDeployment.Value = 0;
                lsbStatus.Items.Insert(0, "ERROR: APS file does not exist");
                return;
            }
            lsbStatus.Items.Insert(0, "File exists... progressing...");
            pbDeployment.PerformStep();
            pbDeployment.Value = 10;

            
            lsbStatus.Items.Insert(0, "Checking endpoint server connectivity");
            try { ssh = new SSHCommunication(endpointHostname, "root", endpointPassword); }
            catch (Exception err)
            {
                pbDeployment.Value = 0;
                lsbStatus.Items.Insert(0, err.Message);
                lsbStatus.Items.Insert(0, "ERROR: Connection to endpoint server was not success...");
                return;
            }
            lsbStatus.Items.Insert(0, "Connection success.");

            try
            {
                ssh.CopyFile(txtAPSPackage.Text, "/var/www/html/");
                lsbStatus.Items.Insert(0, "File uploaded(" + Path.GetFileName(txtAPSPackage.Text) + ")...");
                APSUrl = "http://" + endpointHostname + "/" + Path.GetFileName(txtAPSPackage.Text);
                
                lsbStatus.Items.Insert(0, APSUrl);
            }
            catch (Exception ex)
            {
                lsbStatus.Items.Insert(0, "ERROR: " + ex.Message + ex.StackTrace);
                pbDeployment.Value = 0;
                return;
            }

            if (ckbDeployEndpoint.Checked)
            {

                if (!File.Exists(SSHCommunication.EndpointSH))
                {
                    lsbStatus.Items.Insert(0, "Downloading endpoint.sh from apsstandard.org...");
                    SSHCommunication.DownloadEndpoint();
                    lsbStatus.Items.Insert(0, "Downloaded.");
                }

                lsbStatus.Items.Insert(0, "Uploading file to server...");
                try
                {
                    ssh.CopyFile(SSHCommunication.EndpointSH);
                    lsbStatus.Items.Insert(0, "File uploaded(" + Path.GetFileName(SSHCommunication.EndpointSH) + ")...");
                }
                catch (Exception err)
                {
                    lsbStatus.Items.Insert(0, "ERROR: " + err.Message + err.StackTrace);
                    pbDeployment.Value = 0;
                    return;
                }

                lsbStatus.Items.Insert(0, "Creating endpoint for " + Path.GetFileName(SSHCommunication.EndpointSH));
                Renci.SshNet.SshCommand commandResult = ssh.RunCommand("sh endpoint.sh " + txtEndpointName.Text + " " + Path.GetFileName(txtAPSPackage.Text));
                if (commandResult.Result.Contains("already exists"))
                    commandResult = ssh.RunCommand("sh endpoint.sh --upgrade " + txtEndpointName.Text + " /var/www/html/" + Path.GetFileName(txtAPSPackage.Text));

                if (commandResult.Result.Contains("CONGRATULATIONS"))
                    lsbStatus.Items.Insert(0, "Endpoint created");
                else
                {
                    lsbStatus.Items.Insert(0, "ERROR: Endpoint failed to create: " + commandResult.Result);
                    return;
                }
                EndpointUrl = "https://" + endpointHostname + "/" + txtEndpointName.Text;
            }

            

            try
            {
                lsbStatus.Items.Insert(0, "Importing APS Package");
                var importPackage = xml.importPackage(APSUrl);
                lsbStatus.Items.Insert(0, "APS Package Imported");
                application_id = importPackage.application_id;
            }
            catch (Exception ex)
            {
                lsbStatus.Items.Insert(0, "ERROR: " + ex.Message);
                return;
            }

            List<OpenAPI.pem.settings> settings = new List<OpenAPI.pem.settings>();

            foreach (DataRowView drv in this.lsbParameters.Items)
            {
                settings.Add(new OpenAPI.pem.settings() { name = drv["name"].ToString(), value = drv["value"].ToString() });
            }
            

            var provideApplication = xml.provideApplicationInstance(0, 0, application_id, EndpointUrl, settings.ToArray(), new string[] { });


            lsbStatus.Items.Insert(0, "Finish!");
        }

        private void lsbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bttAddConfiguration_Click(object sender, EventArgs e)
        {

            if(this.cbConfiguration.SelectedValue == null)
                db.APSPackages_Save("", this.cbConfiguration.Text, this.txtAPSPackage.Text, this.txtEndpointName.Text, this.ckbDeployEndpoint.Checked);

            FillConfiguration();
        }

        private void cbConfiguration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((long)((DataRowView)cbConfiguration.SelectedValue)["id"] == -1)
            {
                cbConfiguration.SelectedText = "";
                this.txtAPSPackage.Text = "";
                this.ckbDeployEndpoint.Checked = false;
                this.txtEndpointName.Text = "";
                return;
            }

            DataRowView drv = (DataRowView)cbConfiguration.SelectedValue;

            this.txtAPSPackage.Text = drv["apsPackage"].ToString();
            this.ckbDeployEndpoint.Checked = (bool)drv["deployEndpoint"];
            this.txtEndpointName.Text = drv["endpoint"].ToString();
            FillAPSSettings();
            FillAPSResources();
        }

        private void btConfigurationDelete_Click(object sender, EventArgs e)
        {
            db.APSPackages_Delete(((DataRowView)cbConfiguration.SelectedValue)["id"].ToString());
            FillConfiguration();
        }

        private void bttAddSetting_Click(object sender, EventArgs e)
        {
            if(txtParamName.Text.Length == 0)
            {
                txtParamName.Focus();
                return;
            }
            if (txtParamValue.Text.Length == 0)
            {
                txtParamValue.Focus();
                return;
            }
            db.APSSettings_Save("", ((DataRowView)this.cbConfiguration.SelectedValue)["id"].ToString(), txtParamName.Text, txtParamValue.Text);
            
            txtParamName.Text = string.Empty;
            txtParamValue.Text = string.Empty;

            this.FillAPSSettings();
        }

        private void bttRemoveSetting_Click(object sender, EventArgs e)
        {
            if (this.lsbParameters.SelectedValue == null)
                return;

            db.APSSettings_Delete(((DataRowView)this.lsbParameters.SelectedValue)["id"].ToString());
            this.FillAPSSettings();
        }

        private void bttResourcesAdd_Click(object sender, EventArgs e)
        {
            if (txtResourceType.Text.Length == 0)
            {
                this.txtResourceType.Focus();
                return;
            }
            db.APSResources_Save("", ((DataRowView)this.cbConfiguration.SelectedValue)["id"].ToString(), txtResourceType.Text);
            txtResourceType.Text = string.Empty;
            this.FillAPSResources();
        }

        private void bttResourcesDelete_Click(object sender, EventArgs e)
        {
            if (this.lsbResources.SelectedValue == null)
                return;

            db.APSResourceProperties_Delete(null, ((DataRowView)this.lsbResources.SelectedValue)["id"].ToString());
            db.APSResources_Delete(((DataRowView)this.lsbResources.SelectedValue)["id"].ToString());
            this.FillAPSResources();
            this.FillAPSResourceProperty();
        }

        private void lsbResources_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.FillAPSResourceProperty();
        }

        private void bttResourcePropertyAdd_Click(object sender, EventArgs e)
        {
            if (txtResoucePropertyName.Text.Length == 0)
            {
                txtResoucePropertyName.Focus();
                return;
            }
            if (txtResoucePropertyValue.Text.Length == 0)
            {
                txtResoucePropertyValue.Focus();
                return;
            }
            db.APSResourceProperties_Save("", ((DataRowView)this.lsbResources.SelectedValue)["id"].ToString(), txtResoucePropertyName.Text, txtResoucePropertyValue.Text);
            this.FillAPSResourceProperty();

            txtResoucePropertyName.Text = string.Empty;
            txtResoucePropertyValue.Text = string.Empty;
        }

    }
}
