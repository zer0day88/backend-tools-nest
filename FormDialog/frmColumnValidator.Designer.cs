
namespace BackendTools.FormDialog
{
    partial class frmColumnValidator
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnApply = new FontAwesome.Sharp.IconButton();
            this.chkPilihSemua = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lvColumnPicker = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnApply);
            this.panel1.Controls.Add(this.chkPilihSemua);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 417);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 64);
            this.panel1.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnApply.IconColor = System.Drawing.Color.Black;
            this.btnApply.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnApply.Location = new System.Drawing.Point(819, 18);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(112, 34);
            this.btnApply.TabIndex = 1;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // chkPilihSemua
            // 
            this.chkPilihSemua.AutoSize = true;
            this.chkPilihSemua.Location = new System.Drawing.Point(13, 7);
            this.chkPilihSemua.Name = "chkPilihSemua";
            this.chkPilihSemua.Size = new System.Drawing.Size(128, 29);
            this.chkPilihSemua.TabIndex = 0;
            this.chkPilihSemua.Text = "pilih semua";
            this.chkPilihSemua.UseVisualStyleBackColor = true;
            this.chkPilihSemua.CheckedChanged += new System.EventHandler(this.chkPilihSemua_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lvColumnPicker);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(967, 417);
            this.panel2.TabIndex = 2;
            // 
            // lvColumnPicker
            // 
            this.lvColumnPicker.CheckBoxes = true;
            this.lvColumnPicker.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvColumnPicker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvColumnPicker.GridLines = true;
            this.lvColumnPicker.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvColumnPicker.HideSelection = false;
            this.lvColumnPicker.Location = new System.Drawing.Point(0, 0);
            this.lvColumnPicker.Name = "lvColumnPicker";
            this.lvColumnPicker.Size = new System.Drawing.Size(967, 417);
            this.lvColumnPicker.TabIndex = 0;
            this.lvColumnPicker.UseCompatibleStateImageBehavior = false;
            this.lvColumnPicker.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "column name";
            this.columnHeader1.Width = 320;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "data type";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "is identity";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Is null";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "max_char";
            // 
            // frmColumnValidator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmColumnValidator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmColumnValidator";
            this.Load += new System.EventHandler(this.frmColumnValidator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnApply;
        private System.Windows.Forms.CheckBox chkPilihSemua;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ListView lvColumnPicker;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}