using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackendTools.UserControls;

namespace BackendTools.FormDialog
{
    public partial class FrmFunction : Form
    {
        UCPocoModels _parent;
        DataTable functionDT = new();
        string arg_mode = "";
        string function = "";

        public FrmFunction(UCPocoModels parent)
        {
            InitializeComponent();
            this._parent = parent;
        }

        private async void FrmFunction_Load(object sender, EventArgs e)
        {
            var data = await Helper.GetFunctionList();
            functionDT = data;
            foreach (DataRow row in data.Rows)
            {
                ListViewItem item = new ListViewItem(row[0].ToString());
                for (int i = 1; i < data.Columns.Count; i++)
                {
                    item.SubItems.Add(row[i].ToString());
                }
                lvFunction.Items.Add(item);
            }
        }

        private async void contextMenuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            var focusedItem = lvFunction.FocusedItem;
            ToolStripItem item = e.ClickedItem;
            function = focusedItem.Text;

            if(item.Text == "view parameter")
            {
                arg_mode = "i";
                lvArgument.Items.Clear();

                var data = await Helper.GetArgumentDataTable(focusedItem.Text, "i");

                foreach (DataRow row in data.Rows)
                {
                    ListViewItem itemView = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < data.Columns.Count; i++)
                    {
                        itemView.SubItems.Add(row[i].ToString());
                    }
                    lvArgument.Items.Add(itemView);
                }
            }

            if (item.Text == "view record")
            {
                arg_mode = "t";
                lvArgument.Items.Clear();

                var data = await Helper.GetArgumentDataTable(focusedItem.Text, "t");

                foreach (DataRow row in data.Rows)
                {
                    ListViewItem itemView = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < data.Columns.Count; i++)
                    {
                        itemView.SubItems.Add(row[i].ToString());
                    }
                    lvArgument.Items.Add(itemView);
                }
            }
        }

        private void lvFunction_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var focusedItem = lvFunction.FocusedItem;
                if (focusedItem != null && focusedItem.Bounds.Contains(e.Location))
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                for (int i = lvFunction.Items.Count - 1; i >= 0; i--)
                {
                    var item = lvFunction.Items[i];
                    if (!item.Text.ToLower().Contains(textBox1.Text.ToLower()))
                    { 
                        lvFunction.Items.Remove(item);
                    }
                }
                if (lvFunction.SelectedItems.Count == 1)
                {
                    lvFunction.Focus();
                }
            }
            else {
                
                
                foreach (DataRow row in functionDT.Rows)
                {
                    ListViewItem item = new ListViewItem(row[0].ToString());
                    for (int i = 1; i < functionDT.Columns.Count; i++)
                    {
                        item.SubItems.Add(row[i].ToString());
                    }
                    lvFunction.Items.Add(item);
                }
            }
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if(function == "")
            {
                return;
            }

            string code = await Helper.GeneratePOCOFromFunction(function,arg_mode);
            this._parent.SetCodeEditorValue(code);
            this.Close();
        }
    }
}
