namespace APSCS.TestFramework
{
    partial class frmOSAServer
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtEndpointPassword = new System.Windows.Forms.TextBox();
            this.txtEndpointHostname = new System.Windows.Forms.TextBox();
            this.txtOSAPassword = new System.Windows.Forms.TextBox();
            this.txtOSAHostname = new System.Windows.Forms.TextBox();
            this.txtOSAName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbOSAServers = new System.Windows.Forms.ListBox();
            this.lblId = new System.Windows.Forms.Label();
            this.bttNew = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "OSA Server Name";
            // 
            // txtEndpointPassword
            // 
            this.txtEndpointPassword.Location = new System.Drawing.Point(350, 118);
            this.txtEndpointPassword.Name = "txtEndpointPassword";
            this.txtEndpointPassword.Size = new System.Drawing.Size(192, 20);
            this.txtEndpointPassword.TabIndex = 4;
            // 
            // txtEndpointHostname
            // 
            this.txtEndpointHostname.Location = new System.Drawing.Point(350, 92);
            this.txtEndpointHostname.Name = "txtEndpointHostname";
            this.txtEndpointHostname.Size = new System.Drawing.Size(192, 20);
            this.txtEndpointHostname.TabIndex = 3;
            // 
            // txtOSAPassword
            // 
            this.txtOSAPassword.Location = new System.Drawing.Point(350, 66);
            this.txtOSAPassword.Name = "txtOSAPassword";
            this.txtOSAPassword.Size = new System.Drawing.Size(192, 20);
            this.txtOSAPassword.TabIndex = 2;
            // 
            // txtOSAHostname
            // 
            this.txtOSAHostname.Location = new System.Drawing.Point(350, 40);
            this.txtOSAHostname.Name = "txtOSAHostname";
            this.txtOSAHostname.Size = new System.Drawing.Size(192, 20);
            this.txtOSAHostname.TabIndex = 1;
            // 
            // txtOSAName
            // 
            this.txtOSAName.Location = new System.Drawing.Point(350, 14);
            this.txtOSAName.Name = "txtOSAName";
            this.txtOSAName.Size = new System.Drawing.Size(192, 20);
            this.txtOSAName.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "OSA Hostname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(250, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "OSA Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(250, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Endpoint Hostname";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(250, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Endpoint Password";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(386, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(467, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lbOSAServers
            // 
            this.lbOSAServers.FormattingEnabled = true;
            this.lbOSAServers.Location = new System.Drawing.Point(12, 12);
            this.lbOSAServers.Name = "lbOSAServers";
            this.lbOSAServers.Size = new System.Drawing.Size(232, 238);
            this.lbOSAServers.TabIndex = 8;
            this.lbOSAServers.SelectedIndexChanged += new System.EventHandler(this.lbOSAServers_SelectedIndexChanged);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(289, 14);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 13);
            this.lblId.TabIndex = 11;
            // 
            // bttNew
            // 
            this.bttNew.Location = new System.Drawing.Point(317, 226);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(63, 23);
            this.bttNew.TabIndex = 5;
            this.bttNew.Text = "New";
            this.bttNew.UseVisualStyleBackColor = true;
            this.bttNew.Click += new System.EventHandler(this.bttNew_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(250, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 23);
            this.button3.TabIndex = 12;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // frmOSAServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(555, 261);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.bttNew);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.lbOSAServers);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOSAName);
            this.Controls.Add(this.txtOSAHostname);
            this.Controls.Add(this.txtOSAPassword);
            this.Controls.Add(this.txtEndpointHostname);
            this.Controls.Add(this.txtEndpointPassword);
            this.Controls.Add(this.label1);
            this.Name = "frmOSAServer";
            this.Text = "OSA Servers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEndpointPassword;
        private System.Windows.Forms.TextBox txtEndpointHostname;
        private System.Windows.Forms.TextBox txtOSAPassword;
        private System.Windows.Forms.TextBox txtOSAHostname;
        private System.Windows.Forms.TextBox txtOSAName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox lbOSAServers;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.Button button3;
    }
}