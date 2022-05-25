﻿
namespace BackendTools.FormDialog
{
    partial class frmTableForFunction
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
            this.btnGenerateFromColumn = new FontAwesome.Sharp.IconButton();
            this.btnGenerateFromTable = new FontAwesome.Sharp.IconButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lvSelectedColumn = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.lvSelectedTable = new System.Windows.Forms.ListView();
            this.table = new System.Windows.Forms.ColumnHeader();
            this.dgvTable = new System.Windows.Forms.DataGridView();
            this.cmsTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showColumnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).BeginInit();
            this.cmsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGenerateFromColumn
            // 
            this.btnGenerateFromColumn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGenerateFromColumn.IconColor = System.Drawing.Color.Black;
            this.btnGenerateFromColumn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerateFromColumn.Location = new System.Drawing.Point(1205, 469);
            this.btnGenerateFromColumn.Name = "btnGenerateFromColumn";
            this.btnGenerateFromColumn.Size = new System.Drawing.Size(198, 69);
            this.btnGenerateFromColumn.TabIndex = 13;
            this.btnGenerateFromColumn.Text = "GENERATE FROM SELECTED COLUMN";
            this.btnGenerateFromColumn.UseVisualStyleBackColor = true;
            this.btnGenerateFromColumn.Click += new System.EventHandler(this.btnGenerateFromColumn_Click);
            // 
            // btnGenerateFromTable
            // 
            this.btnGenerateFromTable.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnGenerateFromTable.IconColor = System.Drawing.Color.Black;
            this.btnGenerateFromTable.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGenerateFromTable.Location = new System.Drawing.Point(605, 469);
            this.btnGenerateFromTable.Name = "btnGenerateFromTable";
            this.btnGenerateFromTable.Size = new System.Drawing.Size(198, 69);
            this.btnGenerateFromTable.TabIndex = 12;
            this.btnGenerateFromTable.Text = "GENERATE FROM SELECTED TABLE";
            this.btnGenerateFromTable.UseVisualStyleBackColor = true;
            this.btnGenerateFromTable.Click += new System.EventHandler(this.btnGenerateFromTable_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Search Table";
            this.textBox1.Size = new System.Drawing.Size(434, 31);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lvSelectedColumn
            // 
            this.lvSelectedColumn.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lvSelectedColumn.GridLines = true;
            this.lvSelectedColumn.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSelectedColumn.HideSelection = false;
            this.lvSelectedColumn.Location = new System.Drawing.Point(931, 69);
            this.lvSelectedColumn.MultiSelect = false;
            this.lvSelectedColumn.Name = "lvSelectedColumn";
            this.lvSelectedColumn.Size = new System.Drawing.Size(632, 378);
            this.lvSelectedColumn.TabIndex = 10;
            this.lvSelectedColumn.UseCompatibleStateImageBehavior = false;
            this.lvSelectedColumn.View = System.Windows.Forms.View.Details;
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
            // lvSelectedTable
            // 
            this.lvSelectedTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvSelectedTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.table});
            this.lvSelectedTable.GridLines = true;
            this.lvSelectedTable.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lvSelectedTable.HideSelection = false;
            this.lvSelectedTable.Location = new System.Drawing.Point(482, 69);
            this.lvSelectedTable.MultiSelect = false;
            this.lvSelectedTable.Name = "lvSelectedTable";
            this.lvSelectedTable.Size = new System.Drawing.Size(425, 378);
            this.lvSelectedTable.TabIndex = 9;
            this.lvSelectedTable.UseCompatibleStateImageBehavior = false;
            this.lvSelectedTable.View = System.Windows.Forms.View.Details;
            this.lvSelectedTable.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvSelectedTable_MouseClick);
            this.lvSelectedTable.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvSelectedTable_MouseDoubleClick);
            // 
            // table
            // 
            this.table.Text = "table name";
            this.table.Width = 300;
            // 
            // dgvTable
            // 
            this.dgvTable.AllowUserToAddRows = false;
            this.dgvTable.AllowUserToDeleteRows = false;
            this.dgvTable.AllowUserToOrderColumns = true;
            this.dgvTable.AllowUserToResizeColumns = false;
            this.dgvTable.AllowUserToResizeRows = false;
            this.dgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTable.ColumnHeadersVisible = false;
            this.dgvTable.Location = new System.Drawing.Point(20, 69);
            this.dgvTable.Name = "dgvTable";
            this.dgvTable.RowHeadersVisible = false;
            this.dgvTable.RowHeadersWidth = 62;
            this.dgvTable.RowTemplate.Height = 33;
            this.dgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvTable.Size = new System.Drawing.Size(434, 378);
            this.dgvTable.TabIndex = 8;
            this.dgvTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTable_CellMouseDoubleClick);
            // 
            // cmsTable
            // 
            this.cmsTable.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.cmsTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showColumnToolStripMenuItem});
            this.cmsTable.Name = "cmsTable";
            this.cmsTable.Size = new System.Drawing.Size(191, 36);
            this.cmsTable.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.cmsTable_ItemClicked);
            // 
            // showColumnToolStripMenuItem
            // 
            this.showColumnToolStripMenuItem.Name = "showColumnToolStripMenuItem";
            this.showColumnToolStripMenuItem.Size = new System.Drawing.Size(190, 32);
            this.showColumnToolStripMenuItem.Text = "show column";
            // 
            // frmTableForFunction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1630, 557);
            this.Controls.Add(this.btnGenerateFromColumn);
            this.Controls.Add(this.btnGenerateFromTable);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lvSelectedColumn);
            this.Controls.Add(this.lvSelectedTable);
            this.Controls.Add(this.dgvTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmTableForFunction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTableForFunction";
            this.Load += new System.EventHandler(this.frmTableForFunction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTable)).EndInit();
            this.cmsTable.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconButton btnGenerateFromColumn;
        private FontAwesome.Sharp.IconButton btnGenerateFromTable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView lvSelectedColumn;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView lvSelectedTable;
        private System.Windows.Forms.ColumnHeader table;
        private System.Windows.Forms.DataGridView dgvTable;
        private System.Windows.Forms.ContextMenuStrip cmsTable;
        private System.Windows.Forms.ToolStripMenuItem showColumnToolStripMenuItem;
    }
}