using BackendTools.UserControls;
using DapperPostgreSQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackendTools.FormDialog
{
    public partial class frmTableForValidator : Form
    {
        UCValidator _parent;
        public frmTableForValidator(UCValidator parent)
        {
            InitializeComponent();
            this._parent = parent;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dgvTable.DataSource as DataTable).DefaultView.RowFilter = string.Format("table_name LIKE '%{0}%'", textBox1.Text);
            ApplyGridStyle();
        }

        private async void btnGenerateFromTable_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            foreach (ListViewItem item in this.lvSelectedTable.Items)
            {
                //MessageBox.Show(item.SubItems[0].Text);
                sb.Append("//" + item.SubItems[0].Text);
                sb.Append(Environment.NewLine);
                sb.Append(await Helper.GenerateValidatorFromTable(item.SubItems[0].Text));
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);

            }

            this._parent.SetCodeEditorValue(sb.ToString());
            this.Close();
        }

        private void btnGenerateFromColumn_Click(object sender, EventArgs e)
        {
            string code = Helper.GenerateValidatorFromListView(lvSelectedColumn);
            this._parent.SetCodeEditorValue(code);
            this.Close();
        }

        private async void frmTableForValidator_Load(object sender, EventArgs e)
        {
            dgvTable.DataSource = await Helper.GetTableAsDataTable();
            dgvTable.Columns[0].Width = 406; //434-28

            dgvTable.Columns["table_name"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void dgvTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            IEnumerable<ListViewItem> lv = lvSelectedTable.Items.Cast<ListViewItem>();

            if (lv.Where(x => x.Text == dgvTable.CurrentCell.Value.ToString()).Count() > 0)
            {
                MessageBox.Show("nama table sudah dipakai");
                return;
            }

            DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();
            CellStyle.BackColor = Color.DarkGreen;
            dgvTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Style = CellStyle;

            lvSelectedTable.Items.Add(dgvTable.CurrentCell.Value.ToString());
        }

        private void lvSelectedTable_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            DialogResult dialogResult =
            MessageBox.Show("Hapus table yang dipilih?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            String searchValue = lvSelectedTable.SelectedItems[0].SubItems[0].Text;
            lvSelectedTable.Items.Remove(lvSelectedTable.SelectedItems[0]);

            int rowIndex = -1;

            DataGridViewRow row = dgvTable.Rows
                .Cast<DataGridViewRow>()
                .Where(r => r.Cells["table_name"].Value.ToString().Equals(searchValue))
                .First();

            rowIndex = row.Index;

            DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();
            CellStyle.BackColor = Color.White;
            dgvTable.Rows[rowIndex].Cells["table_name"].Style = CellStyle;
        }

        private void lvSelectedTable_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = lvSelectedTable.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    cmsTable.Show(Cursor.Position);
                }
            }
        }

        private void ApplyGridStyle()
        {
            foreach (ListViewItem itemRow in this.lvSelectedTable.Items)
            {
                //MessageBox.Show(itemRow.SubItems[i].Text);
                int rowIndex = -1;

                if (dgvTable.Rows.Count > 0)
                {
                    DataGridViewRow row = dgvTable.Rows
                    .Cast<DataGridViewRow>()
                    .Where(r => r.Cells["table_name"].Value.ToString().Equals(itemRow.Text))
                    .SingleOrDefault();

                    if (row is null)
                    {
                        return;
                    }
                    rowIndex = row.Index;

                    DataGridViewCellStyle CellStyle = new DataGridViewCellStyle();
                    CellStyle.BackColor = Color.DarkGreen;
                    dgvTable.Rows[rowIndex].Cells["table_name"].Style = CellStyle;
                }


            }
        }

        private void cmsTable_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var focusedItem = lvSelectedTable.FocusedItem;
            var table_name = focusedItem.Text;
            var frm = new frmColumnValidator();
            frm.table_name = focusedItem.Text;
            frm.ShowDialog();

            DataTable dt = new();
            dt = frm.SelectedColumns.ToDataTable();

            bool group_exists = false;

            foreach (ListViewGroup groupitem in this.lvSelectedColumn.Groups)
            {
                if (groupitem.Header == table_name)
                {
                    group_exists = true;
                    foreach (DataRow row in dt.Rows)
                    {
                        ListViewItem item = new ListViewItem(row[0].ToString());
                        for (int i = 1; i < dt.Columns.Count; i++)
                        {
                            item.SubItems.Add(row[i].ToString());
                        }

                        lvSelectedColumn.Items.Add(item);
                        item.Group = groupitem;
                    }
                }
            }

            if (!group_exists)
            {
                ListViewGroup group = new ListViewGroup(table_name);

                lvSelectedColumn.Groups.Add(group);

                foreach (DataRow row in dt.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString(), group);
                    for (int i = 1; i < dt.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }

                    lvSelectedColumn.Items.Add(item);

                }
            }
        }
    }
}
