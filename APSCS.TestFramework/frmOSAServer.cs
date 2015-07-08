using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APSCS.TestFramework
{
    public partial class frmOSAServer : Form
    {
        DB.Database database;

        public frmOSAServer()
        {
            database = new DB.Database();
            InitializeComponent();
            lbOSAServers.DataSource = database.OSASettings_Get();
            lbOSAServers.DisplayMember = "name";
            //lbOSAServers.ValueMember = "id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtOSAName.Text.Length == 0)
            {
                txtOSAName.Focus();
                return;
            }
            if (txtOSAHostname.Text.Length == 0)
            {
                txtOSAHostname.Focus();
                return;
            }
                
            database.OSASettings_Save(
                lblId.Text,
                txtOSAName.Text,
                txtOSAHostname.Text,
                txtOSAPassword.Text,
                txtEndpointHostname.Text,
                txtEndpointPassword.Text);

            lbOSAServers.DataSource = database.OSASettings_Get();
        }

        private void lbOSAServers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblId.Text = ((DataRowView)lbOSAServers.SelectedValue)["id"].ToString();
            txtOSAName.Text = ((DataRowView)lbOSAServers.SelectedValue)["name"].ToString();
            txtOSAHostname.Text = ((DataRowView)lbOSAServers.SelectedValue)["poa_hostname"].ToString();
            txtOSAPassword.Text = ((DataRowView)lbOSAServers.SelectedValue)["poa_password"].ToString();
            txtEndpointHostname.Text = ((DataRowView)lbOSAServers.SelectedValue)["endpoint_hostname"].ToString();
            txtEndpointPassword.Text = ((DataRowView)lbOSAServers.SelectedValue)["endpoint_password"].ToString();
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            this.lblId.Text = "";
            txtOSAName.Text = "";
            txtOSAHostname.Text = "";
            txtOSAPassword.Text = "";
            txtEndpointHostname.Text = "";
            txtEndpointPassword.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (this.lbOSAServers.SelectedIndex == -1)
                return;
            database.OSASettings_Delete(((DataRowView)this.lbOSAServers.SelectedValue)["id"].ToString());

            lblId.Text = "";
            txtOSAName.Text = "";
            txtOSAHostname.Text = "";
            txtOSAPassword.Text = "";
            txtEndpointHostname.Text = "";
            txtEndpointPassword.Text = "";

            lbOSAServers.DataSource = database.OSASettings_Get();
        }
    }
}
