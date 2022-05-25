using BackendTools.FormDialog;
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
    public partial class UCValidator : UserControl
    {
        public UCValidator()
        {
            InitializeComponent();
            Helper.SetThemeEditControlOffice2016DarkGray(CodeEditor);
        }

        private void btnGenerateValidator_Click(object sender, EventArgs e)
        {
            frmTableForValidator frm = new frmTableForValidator(this);
            frm.ShowDialog();
        }

        public void SetCodeEditorValue(string value)
        {
            CodeEditor.Text = value;
        }
    }
}
