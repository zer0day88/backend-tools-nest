using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DapperPostgreSQL;

namespace BackendTools.FormDialog
{
    public partial class frmColumn : Form
    {
        public string table_name { get; set; } = string.Empty;
        public List<column_get> SelectedColumns { get; set; } = new();

        public frmColumn()
        {
            InitializeComponent();
        }

        private async void frmColumn_Load(object sender, EventArgs e)
        {

            var data = await Helper.GetColumnFromTableAsList(table_name);

            DataTable dt = new();
            dt = data.ToDataTable();

            foreach (DataRow row in dt.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < dt.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                
                lvColumnPicker.Items.Add(item);
                
            }
        }

        private void SelectAllCheckBoxes(ListView lv, bool currVal)
        {
            foreach (ListViewItem item in lv.Items)
                item.Checked = currVal;
        }

        private void chkPilihSemua_CheckedChanged(object sender, EventArgs e)
        {
            SelectAllCheckBoxes(lvColumnPicker, chkPilihSemua.Checked);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lvColumnPicker.Items.Count; i++)
            {
                if (lvColumnPicker.Items[i].Checked)
                {
                    
                    var column = new column_get();
                    column.column_name = lvColumnPicker.Items[i].Text;
                    column.udt_name = lvColumnPicker.Items[i].SubItems[1].Text;
                    column.is_identity = lvColumnPicker.Items[i].SubItems[2].Text;
                    column.is_nullable = bool.Parse(lvColumnPicker.Items[i].SubItems[3].Text);

                    SelectedColumns.Add(column);
                }
            }

            this.Close();
        }
    }
}
