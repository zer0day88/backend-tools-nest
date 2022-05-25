using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BackendTools.FormDialog;

namespace BackendTools.UserControls
{
    public partial class UCPocoModels : UserControl
    {
        public UCPocoModels()
        {
            InitializeComponent();
            Helper.SetThemeEditControlOffice2016DarkGray(CodeEditor);
         
        }

        private void btnGetPOCOFromTable_Click(object sender, EventArgs e)
        {
            frmTable frm = new frmTable(this);
            frm.ShowDialog();
        }

        public void SetCodeEditorValue(string value)
        {
            CodeEditor.Text = value;
        }

        private void btnGetPOCOFromFunction_Click(object sender, EventArgs e)
        {
            FrmFunction frm = new FrmFunction(this);
            frm.ShowDialog();
        }
    }
}
