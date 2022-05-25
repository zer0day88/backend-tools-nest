
namespace BackendTools.UserControls
{
    partial class UCCrud
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
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config1 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config2 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config3 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config4 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            Syncfusion.Windows.Forms.Edit.Implementation.Config.Config config5 = new Syncfusion.Windows.Forms.Edit.Implementation.Config.Config();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.EditControlModel = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.EditControlFunction = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.EditControlDAO = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.panel4 = new System.Windows.Forms.Panel();
            this.EditControlService = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.EditControlController = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditControlModel)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditControlFunction)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditControlDAO)).BeginInit();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EditControlService)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditControlController)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvTable);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 498);
            this.panel1.TabIndex = 0;
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.ColumnHeadersVisible = false;
            this.dgvTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTable.Location = new System.Drawing.Point(0, 51);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.ReadOnly = true;
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowHeadersWidth = 62;
            this.dgvTable.RowTemplate.Height = 33;
            this.dgvTable.Size = new System.Drawing.Size(257, 447);
            this.dgvTable.TabIndex = 1;
            this.dgvTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTable_CellMouseDoubleClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(257, 51);
            this.panel3.TabIndex = 0;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(14, 13);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search Table";
            this.txtSearch.Size = new System.Drawing.Size(229, 31);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Location = new System.Drawing.Point(257, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(785, 498);
            this.panel2.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 11);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(785, 487);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.EditControlModel);
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(777, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Model";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // EditControlModel
            // 
            this.EditControlModel.AllowZoom = false;
            this.EditControlModel.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.EditControlModel.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.EditControlModel.Configurator = config1;
            this.EditControlModel.ContextChoiceBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EditControlModel.ContextChoiceBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(50)))));
            this.EditControlModel.ContextChoiceForeColor = System.Drawing.SystemColors.InfoText;
            this.EditControlModel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditControlModel.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.EditControlModel.LineNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EditControlModel.Location = new System.Drawing.Point(3, 3);
            this.EditControlModel.MarkerAreaWidth = 24;
            this.EditControlModel.Name = "EditControlModel";
            this.EditControlModel.RenderRightToLeft = false;
            this.EditControlModel.ScrollPosition = new System.Drawing.Point(0, 0);
            this.EditControlModel.SelectionTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.EditControlModel.Size = new System.Drawing.Size(771, 443);
            this.EditControlModel.StatusBarSettings.CoordsPanel.Width = 150;
            this.EditControlModel.StatusBarSettings.EncodingPanel.Width = 100;
            this.EditControlModel.StatusBarSettings.FileNamePanel.Width = 100;
            this.EditControlModel.StatusBarSettings.InsertPanel.Width = 33;
            this.EditControlModel.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.EditControlModel.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            this.EditControlModel.StatusBarSettings.StatusPanel.Width = 70;
            this.EditControlModel.StatusBarSettings.TextPanel.Width = 214;
            this.EditControlModel.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Default;
            this.EditControlModel.TabIndex = 0;
            this.EditControlModel.Text = "editControl1";
            this.EditControlModel.UseXPStyleBorder = true;
            this.EditControlModel.VisualColumn = 13;
            this.EditControlModel.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
            this.EditControlModel.ZoomFactor = 1F;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.EditControlFunction);
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(777, 449);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Function";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // EditControlFunction
            // 
            this.EditControlFunction.AllowZoom = false;
            this.EditControlFunction.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.EditControlFunction.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.EditControlFunction.Configurator = config2;
            this.EditControlFunction.ContextChoiceBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EditControlFunction.ContextChoiceBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(50)))));
            this.EditControlFunction.ContextChoiceForeColor = System.Drawing.SystemColors.InfoText;
            this.EditControlFunction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditControlFunction.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.EditControlFunction.LineNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EditControlFunction.Location = new System.Drawing.Point(3, 3);
            this.EditControlFunction.MarkerAreaWidth = 24;
            this.EditControlFunction.Name = "EditControlFunction";
            this.EditControlFunction.RenderRightToLeft = false;
            this.EditControlFunction.ScrollPosition = new System.Drawing.Point(0, 0);
            this.EditControlFunction.SelectionTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.EditControlFunction.Size = new System.Drawing.Size(771, 443);
            this.EditControlFunction.StatusBarSettings.CoordsPanel.Width = 150;
            this.EditControlFunction.StatusBarSettings.EncodingPanel.Width = 100;
            this.EditControlFunction.StatusBarSettings.FileNamePanel.Width = 100;
            this.EditControlFunction.StatusBarSettings.InsertPanel.Width = 33;
            this.EditControlFunction.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.EditControlFunction.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            this.EditControlFunction.StatusBarSettings.StatusPanel.Width = 70;
            this.EditControlFunction.StatusBarSettings.TextPanel.Width = 214;
            this.EditControlFunction.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Default;
            this.EditControlFunction.TabIndex = 1;
            this.EditControlFunction.Text = "editControl1";
            this.EditControlFunction.UseXPStyleBorder = true;
            this.EditControlFunction.VisualColumn = 13;
            this.EditControlFunction.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
            this.EditControlFunction.ZoomFactor = 1F;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.EditControlDAO);
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(777, 449);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "DAO";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // EditControlDAO
            // 
            this.EditControlDAO.AllowZoom = false;
            this.EditControlDAO.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.EditControlDAO.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.EditControlDAO.Configurator = config3;
            this.EditControlDAO.ContextChoiceBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EditControlDAO.ContextChoiceBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(50)))));
            this.EditControlDAO.ContextChoiceForeColor = System.Drawing.SystemColors.InfoText;
            this.EditControlDAO.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditControlDAO.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.EditControlDAO.LineNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EditControlDAO.Location = new System.Drawing.Point(0, 0);
            this.EditControlDAO.MarkerAreaWidth = 24;
            this.EditControlDAO.Name = "EditControlDAO";
            this.EditControlDAO.RenderRightToLeft = false;
            this.EditControlDAO.ScrollPosition = new System.Drawing.Point(0, 0);
            this.EditControlDAO.SelectionTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.EditControlDAO.Size = new System.Drawing.Size(777, 449);
            this.EditControlDAO.StatusBarSettings.CoordsPanel.Width = 150;
            this.EditControlDAO.StatusBarSettings.EncodingPanel.Width = 100;
            this.EditControlDAO.StatusBarSettings.FileNamePanel.Width = 100;
            this.EditControlDAO.StatusBarSettings.InsertPanel.Width = 33;
            this.EditControlDAO.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.EditControlDAO.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            this.EditControlDAO.StatusBarSettings.StatusPanel.Width = 70;
            this.EditControlDAO.StatusBarSettings.TextPanel.Width = 214;
            this.EditControlDAO.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Default;
            this.EditControlDAO.TabIndex = 1;
            this.EditControlDAO.Text = "editControl1";
            this.EditControlDAO.UseXPStyleBorder = true;
            this.EditControlDAO.VisualColumn = 13;
            this.EditControlDAO.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
            this.EditControlDAO.ZoomFactor = 1F;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.EditControlService);
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(777, 449);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Service";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.EditControlController);
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(777, 449);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Controller";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(785, 11);
            this.panel4.TabIndex = 1;
            // 
            // EditControlService
            // 
            this.EditControlService.AllowZoom = false;
            this.EditControlService.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.EditControlService.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.EditControlService.Configurator = config4;
            this.EditControlService.ContextChoiceBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EditControlService.ContextChoiceBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(50)))));
            this.EditControlService.ContextChoiceForeColor = System.Drawing.SystemColors.InfoText;
            this.EditControlService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditControlService.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.EditControlService.LineNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EditControlService.Location = new System.Drawing.Point(0, 0);
            this.EditControlService.MarkerAreaWidth = 24;
            this.EditControlService.Name = "EditControlService";
            this.EditControlService.RenderRightToLeft = false;
            this.EditControlService.ScrollPosition = new System.Drawing.Point(0, 0);
            this.EditControlService.SelectionTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.EditControlService.Size = new System.Drawing.Size(777, 449);
            this.EditControlService.StatusBarSettings.CoordsPanel.Width = 150;
            this.EditControlService.StatusBarSettings.EncodingPanel.Width = 100;
            this.EditControlService.StatusBarSettings.FileNamePanel.Width = 100;
            this.EditControlService.StatusBarSettings.InsertPanel.Width = 33;
            this.EditControlService.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.EditControlService.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            this.EditControlService.StatusBarSettings.StatusPanel.Width = 70;
            this.EditControlService.StatusBarSettings.TextPanel.Width = 214;
            this.EditControlService.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Default;
            this.EditControlService.TabIndex = 2;
            this.EditControlService.Text = "editControl1";
            this.EditControlService.UseXPStyleBorder = true;
            this.EditControlService.VisualColumn = 13;
            this.EditControlService.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
            this.EditControlService.ZoomFactor = 1F;
            // 
            // EditControlController
            // 
            this.EditControlController.AllowZoom = false;
            this.EditControlController.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.EditControlController.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.EditControlController.Configurator = config5;
            this.EditControlController.ContextChoiceBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.EditControlController.ContextChoiceBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(50)))));
            this.EditControlController.ContextChoiceForeColor = System.Drawing.SystemColors.InfoText;
            this.EditControlController.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditControlController.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.EditControlController.LineNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.EditControlController.Location = new System.Drawing.Point(0, 0);
            this.EditControlController.MarkerAreaWidth = 24;
            this.EditControlController.Name = "EditControlController";
            this.EditControlController.RenderRightToLeft = false;
            this.EditControlController.ScrollPosition = new System.Drawing.Point(0, 0);
            this.EditControlController.SelectionTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.EditControlController.Size = new System.Drawing.Size(777, 449);
            this.EditControlController.StatusBarSettings.CoordsPanel.Width = 150;
            this.EditControlController.StatusBarSettings.EncodingPanel.Width = 100;
            this.EditControlController.StatusBarSettings.FileNamePanel.Width = 100;
            this.EditControlController.StatusBarSettings.InsertPanel.Width = 33;
            this.EditControlController.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.EditControlController.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            this.EditControlController.StatusBarSettings.StatusPanel.Width = 70;
            this.EditControlController.StatusBarSettings.TextPanel.Width = 214;
            this.EditControlController.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Default;
            this.EditControlController.TabIndex = 2;
            this.EditControlController.Text = "editControl1";
            this.EditControlController.UseXPStyleBorder = true;
            this.EditControlController.VisualColumn = 13;
            this.EditControlController.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
            this.EditControlController.ZoomFactor = 1F;
            // 
            // UCCrud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCCrud";
            this.Size = new System.Drawing.Size(1042, 498);
            this.Load += new System.EventHandler(this.UCCrud_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditControlModel)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditControlFunction)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditControlDAO)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EditControlService)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EditControlController)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel4;
        private Syncfusion.Windows.Forms.Edit.EditControl EditControlModel;
        private Syncfusion.Windows.Forms.Edit.EditControl EditControlFunction;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private Syncfusion.Windows.Forms.Edit.EditControl EditControlDAO;
        private Syncfusion.Windows.Forms.Edit.EditControl EditControlService;
        private Syncfusion.Windows.Forms.Edit.EditControl EditControlController;
    }
}
