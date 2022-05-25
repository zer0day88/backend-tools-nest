
namespace BackendTools.FormDialog
{
    partial class FrmFunction
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
            this.components = new System.ComponentModel.Container();
            this.lvArgument = new System.Windows.Forms.ListView();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.lvFunction = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.viewParameterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewRecordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvArgument
            // 
            this.lvArgument.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5});
            this.lvArgument.HideSelection = false;
            this.lvArgument.Location = new System.Drawing.Point(809, 69);
            this.lvArgument.Name = "lvArgument";
            this.lvArgument.Size = new System.Drawing.Size(461, 388);
            this.lvArgument.TabIndex = 1;
            this.lvArgument.UseCompatibleStateImageBehavior = false;
            this.lvArgument.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Name";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Type";
            this.columnHeader5.Width = 100;
            // 
            // lvFunction
            // 
            this.lvFunction.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvFunction.GridLines = true;
            this.lvFunction.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvFunction.HideSelection = false;
            this.lvFunction.Location = new System.Drawing.Point(27, 69);
            this.lvFunction.Name = "lvFunction";
            this.lvFunction.Size = new System.Drawing.Size(745, 388);
            this.lvFunction.TabIndex = 0;
            this.lvFunction.UseCompatibleStateImageBehavior = false;
            this.lvFunction.View = System.Windows.Forms.View.Details;
            this.lvFunction.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvFunction_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "function name";
            this.columnHeader1.Width = 450;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "function lang";
            this.columnHeader2.Width = 120;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "return";
            this.columnHeader3.Width = 120;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewParameterToolStripMenuItem,
            this.viewRecordToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 68);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // viewParameterToolStripMenuItem
            // 
            this.viewParameterToolStripMenuItem.Name = "viewParameterToolStripMenuItem";
            this.viewParameterToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.viewParameterToolStripMenuItem.Text = "view parameter";
            // 
            // viewRecordToolStripMenuItem
            // 
            this.viewRecordToolStripMenuItem.Name = "viewRecordToolStripMenuItem";
            this.viewRecordToolStripMenuItem.Size = new System.Drawing.Size(205, 32);
            this.viewRecordToolStripMenuItem.Text = "view record";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(27, 23);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "search function";
            this.textBox1.Size = new System.Drawing.Size(745, 31);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(809, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 486);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lvArgument);
            this.Controls.Add(this.lvFunction);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmFunction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmFunction";
            this.Load += new System.EventHandler(this.FrmFunction_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvArgument;
        private System.Windows.Forms.ListView lvFunction;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem viewParameterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewRecordToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}