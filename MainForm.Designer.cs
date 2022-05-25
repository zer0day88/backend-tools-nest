
namespace BackendTools
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.MainLeftPanel = new System.Windows.Forms.Panel();
            this.btnValidator = new FontAwesome.Sharp.IconButton();
            this.btnFunction = new FontAwesome.Sharp.IconButton();
            this.btnCRUD = new FontAwesome.Sharp.IconButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelDatabase = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelHost = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPOCO = new FontAwesome.Sharp.IconButton();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MainDataPanel = new System.Windows.Forms.Panel();
            this.PanelContent = new System.Windows.Forms.Panel();
            this.MainLeftPanel.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.MainDataPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainLeftPanel
            // 
            this.MainLeftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.MainLeftPanel.Controls.Add(this.btnValidator);
            this.MainLeftPanel.Controls.Add(this.btnFunction);
            this.MainLeftPanel.Controls.Add(this.btnCRUD);
            this.MainLeftPanel.Controls.Add(this.statusStrip1);
            this.MainLeftPanel.Controls.Add(this.btnPOCO);
            this.MainLeftPanel.Controls.Add(this.btnSettings);
            this.MainLeftPanel.Controls.Add(this.panel2);
            this.MainLeftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MainLeftPanel.Location = new System.Drawing.Point(0, 0);
            this.MainLeftPanel.Name = "MainLeftPanel";
            this.MainLeftPanel.Size = new System.Drawing.Size(311, 629);
            this.MainLeftPanel.TabIndex = 0;
            // 
            // btnValidator
            // 
            this.btnValidator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.btnValidator.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnValidator.FlatAppearance.BorderSize = 0;
            this.btnValidator.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnValidator.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnValidator.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.btnValidator.IconColor = System.Drawing.Color.Gainsboro;
            this.btnValidator.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnValidator.IconSize = 32;
            this.btnValidator.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidator.Location = new System.Drawing.Point(0, 349);
            this.btnValidator.Name = "btnValidator";
            this.btnValidator.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnValidator.Size = new System.Drawing.Size(311, 68);
            this.btnValidator.TabIndex = 5;
            this.btnValidator.Text = "VALIDATOR ( * NOT USED IN TYPESCRIPT)";
            this.btnValidator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnValidator.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnValidator.UseVisualStyleBackColor = false;
            // 
            // btnFunction
            // 
            this.btnFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.btnFunction.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunction.FlatAppearance.BorderSize = 0;
            this.btnFunction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunction.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFunction.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.btnFunction.IconColor = System.Drawing.Color.Gainsboro;
            this.btnFunction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFunction.IconSize = 32;
            this.btnFunction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunction.Location = new System.Drawing.Point(0, 281);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnFunction.Size = new System.Drawing.Size(311, 68);
            this.btnFunction.TabIndex = 4;
            this.btnFunction.Text = "FUNCTION";
            this.btnFunction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFunction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFunction.UseVisualStyleBackColor = false;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // btnCRUD
            // 
            this.btnCRUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.btnCRUD.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCRUD.FlatAppearance.BorderSize = 0;
            this.btnCRUD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCRUD.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCRUD.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.btnCRUD.IconColor = System.Drawing.Color.Gainsboro;
            this.btnCRUD.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCRUD.IconSize = 32;
            this.btnCRUD.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCRUD.Location = new System.Drawing.Point(0, 213);
            this.btnCRUD.Name = "btnCRUD";
            this.btnCRUD.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCRUD.Size = new System.Drawing.Size(311, 68);
            this.btnCRUD.TabIndex = 3;
            this.btnCRUD.Text = "CRUD";
            this.btnCRUD.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCRUD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCRUD.UseVisualStyleBackColor = false;
            this.btnCRUD.Click += new System.EventHandler(this.btnCRUD_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelDatabase,
            this.statusLabelHost});
            this.statusStrip1.Location = new System.Drawing.Point(0, 597);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(311, 32);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelDatabase
            // 
            this.statusLabelDatabase.BackColor = System.Drawing.Color.DarkGreen;
            this.statusLabelDatabase.ForeColor = System.Drawing.Color.Gainsboro;
            this.statusLabelDatabase.Name = "statusLabelDatabase";
            this.statusLabelDatabase.Size = new System.Drawing.Size(84, 25);
            this.statusLabelDatabase.Text = "database";
            // 
            // statusLabelHost
            // 
            this.statusLabelHost.BackColor = System.Drawing.Color.DarkGreen;
            this.statusLabelHost.ForeColor = System.Drawing.Color.Gainsboro;
            this.statusLabelHost.Name = "statusLabelHost";
            this.statusLabelHost.Size = new System.Drawing.Size(50, 25);
            this.statusLabelHost.Text = "Host";
            // 
            // btnPOCO
            // 
            this.btnPOCO.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.btnPOCO.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPOCO.FlatAppearance.BorderSize = 0;
            this.btnPOCO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPOCO.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPOCO.IconChar = FontAwesome.Sharp.IconChar.ObjectGroup;
            this.btnPOCO.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPOCO.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPOCO.IconSize = 32;
            this.btnPOCO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOCO.Location = new System.Drawing.Point(0, 145);
            this.btnPOCO.Name = "btnPOCO";
            this.btnPOCO.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPOCO.Size = new System.Drawing.Size(311, 68);
            this.btnPOCO.TabIndex = 2;
            this.btnPOCO.Text = "POCO MODEL";
            this.btnPOCO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPOCO.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPOCO.UseVisualStyleBackColor = false;
            this.btnPOCO.Click += new System.EventHandler(this.btnPOCO_Click);
            // 
            // btnSettings
            // 
            this.btnSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(46)))), ((int)(((byte)(67)))));
            this.btnSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSettings.FlatAppearance.BorderSize = 0;
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnSettings.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSettings.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSettings.IconSize = 32;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.Location = new System.Drawing.Point(0, 77);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnSettings.Size = new System.Drawing.Size(311, 68);
            this.btnSettings.TabIndex = 1;
            this.btnSettings.Text = "SETTINGS";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(311, 77);
            this.panel2.TabIndex = 0;
            // 
            // MainDataPanel
            // 
            this.MainDataPanel.Controls.Add(this.PanelContent);
            this.MainDataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDataPanel.Location = new System.Drawing.Point(311, 0);
            this.MainDataPanel.Name = "MainDataPanel";
            this.MainDataPanel.Size = new System.Drawing.Size(1042, 629);
            this.MainDataPanel.TabIndex = 1;
            // 
            // PanelContent
            // 
            this.PanelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.PanelContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContent.Location = new System.Drawing.Point(0, 0);
            this.PanelContent.Name = "PanelContent";
            this.PanelContent.Size = new System.Drawing.Size(1042, 629);
            this.PanelContent.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1353, 629);
            this.Controls.Add(this.MainDataPanel);
            this.Controls.Add(this.MainLeftPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MainLeftPanel.ResumeLayout(false);
            this.MainLeftPanel.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.MainDataPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainLeftPanel;
        private System.Windows.Forms.Panel MainDataPanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelContent;
        private FontAwesome.Sharp.IconButton btnPOCO;
        private FontAwesome.Sharp.IconButton btnSettings;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelDatabase;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelHost;
        private FontAwesome.Sharp.IconButton btnCRUD;
        private FontAwesome.Sharp.IconButton btnFunction;
        private FontAwesome.Sharp.IconButton btnValidator;
    }
}

