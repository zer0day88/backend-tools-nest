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
    public partial class UCFunction : UserControl
    {
        public UCFunction()
        {
            InitializeComponent();
            Helper.SetThemeEditControlOffice2016DarkGray(CodeEditor);
        }

        private void btnGenerateParam_Click(object sender, EventArgs e)
        {
            frmTableForFunction frm = new frmTableForFunction(this);
            frm.ShowDialog();
        }

        private void btnGenerateReturnTable_Click(object sender, EventArgs e)
        {

        }

        public void SetCodeEditorValue(string value)
        {
            CodeEditor.Text = value;
        }
    }
}
