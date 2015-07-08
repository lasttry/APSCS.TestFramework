namespace APSCS.TestFramework
{
    partial class APSCS
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbOSAServers = new System.Windows.Forms.ComboBox();
            this.bttAddOSA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblServerDetails = new System.Windows.Forms.Label();
            this.txtAPSPackage = new System.Windows.Forms.TextBox();
            this.bttOpenAPS = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ckbDeployEndpoint = new System.Windows.Forms.CheckBox();
            this.txtEndpointName = new System.Windows.Forms.TextBox();
            this.bttDeploy = new System.Windows.Forms.Button();
            this.pbDeployment = new System.Windows.Forms.ProgressBar();
            this.lsbStatus = new System.Windows.Forms.ListBox();
            this.lsbParameters = new System.Windows.Forms.ListBox();
            this.txtParamName = new System.Windows.Forms.TextBox();
            this.txtParamValue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbConfiguration = new System.Windows.Forms.ComboBox();
            this.bttAddConfiguration = new System.Windows.Forms.Button();
            this.btConfigurationDelete = new System.Windows.Forms.Button();
            this.bttAddSetting = new System.Windows.Forms.Button();
            this.bttRemoveSetting = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lsbResources = new System.Windows.Forms.ListBox();
            this.txtResourceType = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bttResourcesAdd = new System.Windows.Forms.Button();
            this.bttResourcesDelete = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.bttResourcePropertyDelete = new System.Windows.Forms.Button();
            this.bttResourcePropertyAdd = new System.Windows.Forms.Button();
            this.txtResoucePropertyValue = new System.Windows.Forms.TextBox();
            this.txtResoucePropertyName = new System.Windows.Forms.TextBox();
            this.lsbResourceProperties = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // cbOSAServers
            // 
            this.cbOSAServers.FormattingEnabled = true;
            this.cbOSAServers.Location = new System.Drawing.Point(100, 12);
            this.cbOSAServers.Name = "cbOSAServers";
            this.cbOSAServers.Size = new System.Drawing.Size(197, 21);
            this.cbOSAServers.TabIndex = 1;
            this.cbOSAServers.SelectedIndexChanged += new System.EventHandler(this.cbOSAServers_SelectedIndexChanged);
            // 
            // bttAddOSA
            // 
            this.bttAddOSA.Location = new System.Drawing.Point(303, 11);
            this.bttAddOSA.Name = "bttAddOSA";
            this.bttAddOSA.Size = new System.Drawing.Size(29, 23);
            this.bttAddOSA.TabIndex = 2;
            this.bttAddOSA.Text = "...";
            this.bttAddOSA.UseVisualStyleBackColor = true;
            this.bttAddOSA.Click += new System.EventHandler(this.bttAddOSA_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "OSA Server";
            // 
            // lblServerDetails
            // 
            this.lblServerDetails.AutoSize = true;
            this.lblServerDetails.Location = new System.Drawing.Point(339, 15);
            this.lblServerDetails.Name = "lblServerDetails";
            this.lblServerDetails.Size = new System.Drawing.Size(0, 13);
            this.lblServerDetails.TabIndex = 4;
            // 
            // txtAPSPackage
            // 
            this.txtAPSPackage.Location = new System.Drawing.Point(100, 68);
            this.txtAPSPackage.Name = "txtAPSPackage";
            this.txtAPSPackage.Size = new System.Drawing.Size(197, 20);
            this.txtAPSPackage.TabIndex = 5;
            this.txtAPSPackage.TextChanged += new System.EventHandler(this.txtAPSPackage_TextChanged);
            // 
            // bttOpenAPS
            // 
            this.bttOpenAPS.Location = new System.Drawing.Point(303, 67);
            this.bttOpenAPS.Name = "bttOpenAPS";
            this.bttOpenAPS.Size = new System.Drawing.Size(29, 23);
            this.bttOpenAPS.TabIndex = 6;
            this.bttOpenAPS.Text = "...";
            this.bttOpenAPS.UseVisualStyleBackColor = true;
            this.bttOpenAPS.Click += new System.EventHandler(this.bttOpenAPS_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "APS Package";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ckbDeployEndpoint
            // 
            this.ckbDeployEndpoint.AutoSize = true;
            this.ckbDeployEndpoint.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbDeployEndpoint.Location = new System.Drawing.Point(11, 98);
            this.ckbDeployEndpoint.Name = "ckbDeployEndpoint";
            this.ckbDeployEndpoint.Size = new System.Drawing.Size(104, 17);
            this.ckbDeployEndpoint.TabIndex = 8;
            this.ckbDeployEndpoint.Text = "Deploy Endpoint";
            this.ckbDeployEndpoint.UseVisualStyleBackColor = true;
            this.ckbDeployEndpoint.CheckedChanged += new System.EventHandler(this.ckbDeployEndpoint_CheckedChanged);
            // 
            // txtEndpointName
            // 
            this.txtEndpointName.Location = new System.Drawing.Point(122, 95);
            this.txtEndpointName.Name = "txtEndpointName";
            this.txtEndpointName.Size = new System.Drawing.Size(175, 20);
            this.txtEndpointName.TabIndex = 9;
            // 
            // bttDeploy
            // 
            this.bttDeploy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttDeploy.Location = new System.Drawing.Point(718, 554);
            this.bttDeploy.Name = "bttDeploy";
            this.bttDeploy.Size = new System.Drawing.Size(75, 23);
            this.bttDeploy.TabIndex = 10;
            this.bttDeploy.Text = "Deploy";
            this.bttDeploy.UseVisualStyleBackColor = true;
            this.bttDeploy.Click += new System.EventHandler(this.bttDeploy_Click);
            // 
            // pbDeployment
            // 
            this.pbDeployment.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbDeployment.Location = new System.Drawing.Point(12, 528);
            this.pbDeployment.Name = "pbDeployment";
            this.pbDeployment.Size = new System.Drawing.Size(781, 23);
            this.pbDeployment.TabIndex = 11;
            // 
            // lsbStatus
            // 
            this.lsbStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lsbStatus.BackColor = System.Drawing.Color.Black;
            this.lsbStatus.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsbStatus.ForeColor = System.Drawing.Color.Green;
            this.lsbStatus.FormattingEnabled = true;
            this.lsbStatus.Location = new System.Drawing.Point(12, 312);
            this.lsbStatus.Name = "lsbStatus";
            this.lsbStatus.Size = new System.Drawing.Size(781, 212);
            this.lsbStatus.TabIndex = 12;
            this.lsbStatus.SelectedIndexChanged += new System.EventHandler(this.lsbStatus_SelectedIndexChanged);
            // 
            // lsbParameters
            // 
            this.lsbParameters.FormattingEnabled = true;
            this.lsbParameters.Location = new System.Drawing.Point(432, 12);
            this.lsbParameters.Name = "lsbParameters";
            this.lsbParameters.Size = new System.Drawing.Size(365, 95);
            this.lsbParameters.TabIndex = 13;
            // 
            // txtParamName
            // 
            this.txtParamName.Location = new System.Drawing.Point(464, 116);
            this.txtParamName.Name = "txtParamName";
            this.txtParamName.Size = new System.Drawing.Size(108, 20);
            this.txtParamName.TabIndex = 14;
            // 
            // txtParamValue
            // 
            this.txtParamValue.Location = new System.Drawing.Point(619, 116);
            this.txtParamValue.Name = "txtParamValue";
            this.txtParamValue.Size = new System.Drawing.Size(108, 20);
            this.txtParamValue.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Configuration";
            // 
            // cbConfiguration
            // 
            this.cbConfiguration.FormattingEnabled = true;
            this.cbConfiguration.Location = new System.Drawing.Point(100, 39);
            this.cbConfiguration.Name = "cbConfiguration";
            this.cbConfiguration.Size = new System.Drawing.Size(197, 21);
            this.cbConfiguration.TabIndex = 17;
            this.cbConfiguration.SelectedIndexChanged += new System.EventHandler(this.cbConfiguration_SelectedIndexChanged);
            // 
            // bttAddConfiguration
            // 
            this.bttAddConfiguration.Location = new System.Drawing.Point(303, 38);
            this.bttAddConfiguration.Name = "bttAddConfiguration";
            this.bttAddConfiguration.Size = new System.Drawing.Size(29, 23);
            this.bttAddConfiguration.TabIndex = 18;
            this.bttAddConfiguration.Text = "+";
            this.bttAddConfiguration.UseVisualStyleBackColor = true;
            this.bttAddConfiguration.Click += new System.EventHandler(this.bttAddConfiguration_Click);
            // 
            // btConfigurationDelete
            // 
            this.btConfigurationDelete.Location = new System.Drawing.Point(338, 38);
            this.btConfigurationDelete.Name = "btConfigurationDelete";
            this.btConfigurationDelete.Size = new System.Drawing.Size(29, 23);
            this.btConfigurationDelete.TabIndex = 19;
            this.btConfigurationDelete.Text = "-";
            this.btConfigurationDelete.UseVisualStyleBackColor = true;
            this.btConfigurationDelete.Click += new System.EventHandler(this.btConfigurationDelete_Click);
            // 
            // bttAddSetting
            // 
            this.bttAddSetting.Location = new System.Drawing.Point(733, 114);
            this.bttAddSetting.Name = "bttAddSetting";
            this.bttAddSetting.Size = new System.Drawing.Size(29, 23);
            this.bttAddSetting.TabIndex = 20;
            this.bttAddSetting.Text = "+";
            this.bttAddSetting.UseVisualStyleBackColor = true;
            this.bttAddSetting.Click += new System.EventHandler(this.bttAddSetting_Click);
            // 
            // bttRemoveSetting
            // 
            this.bttRemoveSetting.Location = new System.Drawing.Point(768, 114);
            this.bttRemoveSetting.Name = "bttRemoveSetting";
            this.bttRemoveSetting.Size = new System.Drawing.Size(29, 23);
            this.bttRemoveSetting.TabIndex = 21;
            this.bttRemoveSetting.Text = "-";
            this.bttRemoveSetting.UseVisualStyleBackColor = true;
            this.bttRemoveSetting.Click += new System.EventHandler(this.bttRemoveSetting_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(363, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Parameters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(579, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(424, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 141);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Provider Resources";
            // 
            // lsbResources
            // 
            this.lsbResources.FormattingEnabled = true;
            this.lsbResources.Location = new System.Drawing.Point(11, 157);
            this.lsbResources.Name = "lsbResources";
            this.lsbResources.Size = new System.Drawing.Size(346, 95);
            this.lsbResources.TabIndex = 26;
            this.lsbResources.SelectedIndexChanged += new System.EventHandler(this.lsbResources_SelectedIndexChanged);
            // 
            // txtResourceType
            // 
            this.txtResourceType.Location = new System.Drawing.Point(95, 258);
            this.txtResourceType.Name = "txtResourceType";
            this.txtResourceType.Size = new System.Drawing.Size(192, 20);
            this.txtResourceType.TabIndex = 27;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 261);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 28;
            this.label8.Text = "Resource Type";
            // 
            // bttResourcesAdd
            // 
            this.bttResourcesAdd.Location = new System.Drawing.Point(293, 256);
            this.bttResourcesAdd.Name = "bttResourcesAdd";
            this.bttResourcesAdd.Size = new System.Drawing.Size(29, 23);
            this.bttResourcesAdd.TabIndex = 29;
            this.bttResourcesAdd.Text = "+";
            this.bttResourcesAdd.UseVisualStyleBackColor = true;
            this.bttResourcesAdd.Click += new System.EventHandler(this.bttResourcesAdd_Click);
            // 
            // bttResourcesDelete
            // 
            this.bttResourcesDelete.Location = new System.Drawing.Point(328, 256);
            this.bttResourcesDelete.Name = "bttResourcesDelete";
            this.bttResourcesDelete.Size = new System.Drawing.Size(29, 23);
            this.bttResourcesDelete.TabIndex = 30;
            this.bttResourcesDelete.Text = "-";
            this.bttResourcesDelete.UseVisualStyleBackColor = true;
            this.bttResourcesDelete.Click += new System.EventHandler(this.bttResourcesDelete_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(424, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Name";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(579, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Value";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(363, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 26);
            this.label11.TabIndex = 36;
            this.label11.Text = "Resource\r\nProperties";
            // 
            // bttResourcePropertyDelete
            // 
            this.bttResourcePropertyDelete.Location = new System.Drawing.Point(768, 259);
            this.bttResourcePropertyDelete.Name = "bttResourcePropertyDelete";
            this.bttResourcePropertyDelete.Size = new System.Drawing.Size(29, 23);
            this.bttResourcePropertyDelete.TabIndex = 35;
            this.bttResourcePropertyDelete.Text = "-";
            this.bttResourcePropertyDelete.UseVisualStyleBackColor = true;
            // 
            // bttResourcePropertyAdd
            // 
            this.bttResourcePropertyAdd.Location = new System.Drawing.Point(733, 259);
            this.bttResourcePropertyAdd.Name = "bttResourcePropertyAdd";
            this.bttResourcePropertyAdd.Size = new System.Drawing.Size(29, 23);
            this.bttResourcePropertyAdd.TabIndex = 34;
            this.bttResourcePropertyAdd.Text = "+";
            this.bttResourcePropertyAdd.UseVisualStyleBackColor = true;
            this.bttResourcePropertyAdd.Click += new System.EventHandler(this.bttResourcePropertyAdd_Click);
            // 
            // txtResoucePropertyValue
            // 
            this.txtResoucePropertyValue.Location = new System.Drawing.Point(619, 261);
            this.txtResoucePropertyValue.Name = "txtResoucePropertyValue";
            this.txtResoucePropertyValue.Size = new System.Drawing.Size(108, 20);
            this.txtResoucePropertyValue.TabIndex = 33;
            // 
            // txtResoucePropertyName
            // 
            this.txtResoucePropertyName.Location = new System.Drawing.Point(464, 261);
            this.txtResoucePropertyName.Name = "txtResoucePropertyName";
            this.txtResoucePropertyName.Size = new System.Drawing.Size(108, 20);
            this.txtResoucePropertyName.TabIndex = 32;
            // 
            // lsbResourceProperties
            // 
            this.lsbResourceProperties.FormattingEnabled = true;
            this.lsbResourceProperties.Location = new System.Drawing.Point(432, 157);
            this.lsbResourceProperties.Name = "lsbResourceProperties";
            this.lsbResourceProperties.Size = new System.Drawing.Size(365, 95);
            this.lsbResourceProperties.TabIndex = 31;
            // 
            // APSCS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 589);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.bttResourcePropertyDelete);
            this.Controls.Add(this.bttResourcePropertyAdd);
            this.Controls.Add(this.txtResoucePropertyValue);
            this.Controls.Add(this.txtResoucePropertyName);
            this.Controls.Add(this.lsbResourceProperties);
            this.Controls.Add(this.bttResourcesDelete);
            this.Controls.Add(this.bttResourcesAdd);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtResourceType);
            this.Controls.Add(this.lsbResources);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bttRemoveSetting);
            this.Controls.Add(this.bttAddSetting);
            this.Controls.Add(this.btConfigurationDelete);
            this.Controls.Add(this.bttAddConfiguration);
            this.Controls.Add(this.cbConfiguration);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtParamValue);
            this.Controls.Add(this.txtParamName);
            this.Controls.Add(this.lsbParameters);
            this.Controls.Add(this.lsbStatus);
            this.Controls.Add(this.pbDeployment);
            this.Controls.Add(this.bttDeploy);
            this.Controls.Add(this.txtEndpointName);
            this.Controls.Add(this.ckbDeployEndpoint);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bttOpenAPS);
            this.Controls.Add(this.txtAPSPackage);
            this.Controls.Add(this.lblServerDetails);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bttAddOSA);
            this.Controls.Add(this.cbOSAServers);
            this.Name = "APSCS";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbOSAServers;
        private System.Windows.Forms.Button bttAddOSA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblServerDetails;
        private System.Windows.Forms.TextBox txtAPSPackage;
        private System.Windows.Forms.Button bttOpenAPS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox ckbDeployEndpoint;
        private System.Windows.Forms.TextBox txtEndpointName;
        private System.Windows.Forms.Button bttDeploy;
        private System.Windows.Forms.ProgressBar pbDeployment;
        private System.Windows.Forms.ListBox lsbStatus;
        private System.Windows.Forms.ListBox lsbParameters;
        private System.Windows.Forms.TextBox txtParamName;
        private System.Windows.Forms.TextBox txtParamValue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbConfiguration;
        private System.Windows.Forms.Button bttAddConfiguration;
        private System.Windows.Forms.Button btConfigurationDelete;
        private System.Windows.Forms.Button bttAddSetting;
        private System.Windows.Forms.Button bttRemoveSetting;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lsbResources;
        private System.Windows.Forms.TextBox txtResourceType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bttResourcesAdd;
        private System.Windows.Forms.Button bttResourcesDelete;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button bttResourcePropertyDelete;
        private System.Windows.Forms.Button bttResourcePropertyAdd;
        private System.Windows.Forms.TextBox txtResoucePropertyValue;
        private System.Windows.Forms.TextBox txtResoucePropertyName;
        private System.Windows.Forms.ListBox lsbResourceProperties;
    }
}

