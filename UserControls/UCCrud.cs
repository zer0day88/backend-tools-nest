using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BackendTools.UserControls
{
    public partial class UCCrud : UserControl
    {
        public UCCrud()
        {
            InitializeComponent();
            Helper.SetThemeEditControlOffice2016DarkGray(EditControlModel);
            Helper.SetThemeEditControlOffice2016DarkGray(EditControlFunction);
            Helper.SetThemeEditControlOffice2016DarkGray(EditControlDAO);
            Helper.SetThemeEditControlOffice2016DarkGray(EditControlService);
            Helper.SetThemeEditControlOffice2016DarkGray(EditControlController);
        }

        private async void UCCrud_Load(object sender, EventArgs e)
        {
            dgvTable.DataSource = await Helper.GetTableAsDataTable();
            dgvTable.Columns[0].Width = 406; //434-28

            dgvTable.Columns["table_name"].SortMode = DataGridViewColumnSortMode.NotSortable;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            (dgvTable.DataSource as DataTable).DefaultView.RowFilter = string.Format("table_name LIKE '%{0}%'", txtSearch.Text);
        }

        private void dgvTable_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DialogResult dialogResult =
            MessageBox.Show("Generate CRUD dari table "+ dgvTable.CurrentCell.Value + "?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialogResult == DialogResult.No)
            {
                return;
            }

            this.generateModel(dgvTable.CurrentCell.Value.ToString());
            this.generateFunction(dgvTable.CurrentCell.Value.ToString());
            this.generateDAO(dgvTable.CurrentCell.Value.ToString());
            this.generateService(dgvTable.CurrentCell.Value.ToString());
            this.generateController(dgvTable.CurrentCell.Value.ToString());
        }

        private async void generateModel(string table_name)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(await Helper.GeneratePOCOFromTable(table_name));
            this.EditControlModel.Text = sb.ToString();
            
        }

        private async void generateFunction(string table_name)
        {
            
            this.EditControlFunction.Text = await Helper.GenerateFunctionCRUDFromTable(table_name);

        }

        private async void generateDAO(string table_name)
        {
            this.EditControlDAO.Text = await Helper.GenerateDAO_CRUD_FromTable(table_name);

        }

        private async void generateService(string table_name)
        {
            this.EditControlService.Text = await Helper.GenerateSERVICE_FromTable(table_name);

        }

        private async void generateController(string table_name)
        {
            this.EditControlController.Text =await Helper.GenerateCONTROLLER_FromTable(table_name);

        }
    }
}
