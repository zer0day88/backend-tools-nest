
namespace BackendTools.UserControls
{
    partial class UCPocoModels
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
            this.btnGetPOCOFromFunction = new FontAwesome.Sharp.IconButton();
            this.btnGetPOCOFromTable = new FontAwesome.Sharp.IconButton();
            this.CodeEditor = new Syncfusion.Windows.Forms.Edit.EditControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.CodeEditor)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGetPOCOFromFunction
            // 
            this.btnGetPOCOFromFunction.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetPOCOFromFunction.IconChar = FontAwesome.Sharp.IconChar.FileCode;
            this.btnGetPOCOFromFunction.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnGetPOCOFromFunction.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGetPOCOFromFunction.IconSize = 30;
            this.btnGetPOCOFromFunction.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetPOCOFromFunction.Location = new System.Drawing.Point(25, 82);
            this.btnGetPOCOFromFunction.Name = "btnGetPOCOFromFunction";
            this.btnGetPOCOFromFunction.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGetPOCOFromFunction.Size = new System.Drawing.Size(204, 43);
            this.btnGetPOCOFromFunction.TabIndex = 16;
            this.btnGetPOCOFromFunction.Text = "From Function";
            this.btnGetPOCOFromFunction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetPOCOFromFunction.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetPOCOFromFunction.UseVisualStyleBackColor = true;
            this.btnGetPOCOFromFunction.Click += new System.EventHandler(this.btnGetPOCOFromFunction_Click);
            // 
            // btnGetPOCOFromTable
            // 
            this.btnGetPOCOFromTable.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGetPOCOFromTable.IconChar = FontAwesome.Sharp.IconChar.PollH;
            this.btnGetPOCOFromTable.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.btnGetPOCOFromTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGetPOCOFromTable.IconSize = 30;
            this.btnGetPOCOFromTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetPOCOFromTable.Location = new System.Drawing.Point(25, 19);
            this.btnGetPOCOFromTable.Name = "btnGetPOCOFromTable";
            this.btnGetPOCOFromTable.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGetPOCOFromTable.Size = new System.Drawing.Size(204, 43);
            this.btnGetPOCOFromTable.TabIndex = 15;
            this.btnGetPOCOFromTable.Text = "From Table";
            this.btnGetPOCOFromTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGetPOCOFromTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGetPOCOFromTable.UseVisualStyleBackColor = true;
            this.btnGetPOCOFromTable.Click += new System.EventHandler(this.btnGetPOCOFromTable_Click);
            // 
            // CodeEditor
            // 
            this.CodeEditor.AllowZoom = false;
            this.CodeEditor.ChangedLinesMarkingLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(238)))), ((int)(((byte)(98)))));
            this.CodeEditor.CodeSnipptSize = new System.Drawing.Size(100, 100);
            this.CodeEditor.Configurator = config1;
            this.CodeEditor.ContextChoiceBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.CodeEditor.ContextChoiceBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(166)))), ((int)(((byte)(50)))));
            this.CodeEditor.ContextChoiceForeColor = System.Drawing.SystemColors.InfoText;
            this.CodeEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CodeEditor.IndicatorMarginBackColor = System.Drawing.Color.Empty;
            this.CodeEditor.LineNumbersColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.CodeEditor.Location = new System.Drawing.Point(0, 0);
            this.CodeEditor.MarkerAreaWidth = 24;
            this.CodeEditor.Name = "CodeEditor";
            this.CodeEditor.RenderRightToLeft = false;
            this.CodeEditor.ScrollPosition = new System.Drawing.Point(0, 0);
            this.CodeEditor.SelectionTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(214)))), ((int)(((byte)(255)))));
            this.CodeEditor.Size = new System.Drawing.Size(783, 519);
            this.CodeEditor.StatusBarSettings.CoordsPanel.Width = 150;
            this.CodeEditor.StatusBarSettings.EncodingPanel.Width = 100;
            this.CodeEditor.StatusBarSettings.FileNamePanel.Width = 100;
            this.CodeEditor.StatusBarSettings.InsertPanel.Width = 33;
            this.CodeEditor.StatusBarSettings.Offcie2007ColorScheme = Syncfusion.Windows.Forms.Office2007Theme.Blue;
            this.CodeEditor.StatusBarSettings.Offcie2010ColorScheme = Syncfusion.Windows.Forms.Office2010Theme.Blue;
            this.CodeEditor.StatusBarSettings.StatusPanel.Width = 70;
            this.CodeEditor.StatusBarSettings.TextPanel.Width = 214;
            this.CodeEditor.StatusBarSettings.VisualStyle = Syncfusion.Windows.Forms.Tools.Controls.StatusBar.VisualStyle.Default;
            this.CodeEditor.TabIndex = 0;
            this.CodeEditor.Text = "editControl1";
            this.CodeEditor.UseXPStyleBorder = true;
            this.CodeEditor.VisualColumn = 13;
            this.CodeEditor.VScrollMode = Syncfusion.Windows.Forms.Edit.ScrollMode.Immediate;
            this.CodeEditor.ZoomFactor = 1F;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(65)))), ((int)(((byte)(92)))));
            this.panel1.Controls.Add(this.btnGetPOCOFromTable);
            this.panel1.Controls.Add(this.btnGetPOCOFromFunction);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(259, 519);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CodeEditor);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(259, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(783, 519);
            this.panel2.TabIndex = 18;
            // 
            // UCPocoModels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(27)))), ((int)(((byte)(63)))));
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "UCPocoModels";
            this.Size = new System.Drawing.Size(1042, 519);
            ((System.ComponentModel.ISupportInitialize)(this.CodeEditor)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private FontAwesome.Sharp.IconButton btnGetPOCOFromFunction;
        private FontAwesome.Sharp.IconButton btnGetPOCOFromTable;
        private Syncfusion.Windows.Forms.Edit.EditControl CodeEditor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}
