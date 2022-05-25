
namespace BackendTools.UserControls
{
    partial class UCSettingDatabase
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbConnectionList = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnectionName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServerAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDatabasePort = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnTestConnection = new FontAwesome.Sharp.IconButton();
            this.btnConnectAndSave = new FontAwesome.Sharp.IconButton();
            this.chkViewPassword = new System.Windows.Forms.CheckBox();
            this.btnConnect = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbConnectionList
            // 
            this.cmbConnectionList.FormattingEnabled = true;
            this.cmbConnectionList.Location = new System.Drawing.Point(179, 10);
            this.cmbConnectionList.Name = "cmbConnectionList";
            this.cmbConnectionList.Size = new System.Drawing.Size(256, 33);
            this.cmbConnectionList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(40, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Connection List";
            // 
            // txtConnectionName
            // 
            this.txtConnectionName.Location = new System.Drawing.Point(254, 13);
            this.txtConnectionName.Name = "txtConnectionName";
            this.txtConnectionName.Size = new System.Drawing.Size(250, 31);
            this.txtConnectionName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(84, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Connection Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(84, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Server Address";
            // 
            // txtServerAddress
            // 
            this.txtServerAddress.Location = new System.Drawing.Point(254, 65);
            this.txtServerAddress.Name = "txtServerAddress";
            this.txtServerAddress.Size = new System.Drawing.Size(250, 31);
            this.txtServerAddress.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(84, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Database Name";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Location = new System.Drawing.Point(254, 152);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(250, 31);
            this.txtDatabaseName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(84, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Database Port";
            // 
            // txtDatabasePort
            // 
            this.txtDatabasePort.Location = new System.Drawing.Point(254, 200);
            this.txtDatabasePort.Name = "txtDatabasePort";
            this.txtDatabasePort.Size = new System.Drawing.Size(250, 31);
            this.txtDatabasePort.TabIndex = 8;
            this.txtDatabasePort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDatabasePort_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(84, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Username";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(254, 249);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(250, 31);
            this.txtUserName.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Gainsboro;
            this.label7.Location = new System.Drawing.Point(84, 297);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(254, 297);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(250, 31);
            this.txtPassword.TabIndex = 12;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTestConnection.IconChar = FontAwesome.Sharp.IconChar.CompressAlt;
            this.btnTestConnection.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnTestConnection.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTestConnection.IconSize = 30;
            this.btnTestConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestConnection.Location = new System.Drawing.Point(84, 404);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnTestConnection.Size = new System.Drawing.Size(204, 36);
            this.btnTestConnection.TabIndex = 14;
            this.btnTestConnection.Text = "Test connection";
            this.btnTestConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTestConnection.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTestConnection.UseVisualStyleBackColor = true;
            this.btnTestConnection.Click += new System.EventHandler(this.btnTestConnection_Click);
            // 
            // btnConnectAndSave
            // 
            this.btnConnectAndSave.IconChar = FontAwesome.Sharp.IconChar.CaretSquareRight;
            this.btnConnectAndSave.IconColor = System.Drawing.Color.Black;
            this.btnConnectAndSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConnectAndSave.IconSize = 30;
            this.btnConnectAndSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnectAndSave.Location = new System.Drawing.Point(301, 404);
            this.btnConnectAndSave.Name = "btnConnectAndSave";
            this.btnConnectAndSave.Size = new System.Drawing.Size(203, 34);
            this.btnConnectAndSave.TabIndex = 16;
            this.btnConnectAndSave.Text = "Connect and Save";
            this.btnConnectAndSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConnectAndSave.UseVisualStyleBackColor = true;
            this.btnConnectAndSave.Click += new System.EventHandler(this.btnConnectAndSave_Click);
            // 
            // chkViewPassword
            // 
            this.chkViewPassword.AutoSize = true;
            this.chkViewPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.chkViewPassword.Location = new System.Drawing.Point(254, 334);
            this.chkViewPassword.Name = "chkViewPassword";
            this.chkViewPassword.Size = new System.Drawing.Size(162, 29);
            this.chkViewPassword.TabIndex = 17;
            this.chkViewPassword.Text = "show password";
            this.chkViewPassword.UseVisualStyleBackColor = true;
            this.chkViewPassword.CheckedChanged += new System.EventHandler(this.chkViewPassword_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.IconChar = FontAwesome.Sharp.IconChar.PaperPlane;
            this.btnConnect.IconColor = System.Drawing.Color.Black;
            this.btnConnect.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConnect.IconSize = 30;
            this.btnConnect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnect.Location = new System.Drawing.Point(315, 62);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(120, 36);
            this.btnConnect.TabIndex = 18;
            this.btnConnect.Text = "Connect";
            this.btnConnect.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 77);
            this.panel2.TabIndex = 21;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txtConnectionName);
            this.panel4.Controls.Add(this.txtServerAddress);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.txtDatabaseName);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.chkViewPassword);
            this.panel4.Controls.Add(this.txtDatabasePort);
            this.panel4.Controls.Add(this.btnConnectAndSave);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.btnTestConnection);
            this.panel4.Controls.Add(this.txtUserName);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 77);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(556, 661);
            this.panel4.TabIndex = 24;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(556, 77);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(671, 661);
            this.panel5.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.cmbConnectionList);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnConnect);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 150);
            this.panel1.TabIndex = 21;
            // 
            // UCSettingDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Name = "UCSettingDatabase";
            this.Size = new System.Drawing.Size(1227, 738);
            this.Load += new System.EventHandler(this.UCSettingDatabase_Load);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbConnectionList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnectionName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServerAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDatabasePort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassword;
        private FontAwesome.Sharp.IconButton btnTestConnection;
        private FontAwesome.Sharp.IconButton btnConnectAndSave;
        private System.Windows.Forms.CheckBox chkViewPassword;
        private FontAwesome.Sharp.IconButton btnConnect;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel1;
    }
}
