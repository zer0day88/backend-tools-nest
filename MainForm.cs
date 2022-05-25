using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using BackendTools.UserControls;

namespace BackendTools
{
    public partial class MainForm : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Control _previousPanelContent;
        public static string test { get; set; }

        public MainForm()
        {
            InitializeComponent();
            //Register Syncfusion license
            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense(
                "NDgyNzczQDMxMzkyZTMyMmUzME9mTmNSWW5oSmhSOXZtZmh2NWlHY05qdzZhUWtKRUhXeW9odVo0WkJpVnc9");

            leftBorderBtn = new();
            leftBorderBtn.Size = new Size(7,68);
            MainLeftPanel.Controls.Add(leftBorderBtn);
            statusLabelDatabase.Text = "no connection";
            statusLabelDatabase.BackColor = Color.DarkRed;
            statusLabelHost.Text = "";
            statusLabelHost.BackColor = Color.DarkRed;
        }

        public void SetLabelDatabase()
        {
            statusLabelDatabase.Text = SqlAuth.database;
            statusLabelDatabase.BackColor = Color.DarkGreen;
            statusLabelHost.Text = "@" + SqlAuth.server;
            statusLabelHost.BackColor = Color.DarkGreen;
        }

        public void RemoveUserControlFromPanelContent()
        {
            PanelContent.SuspendLayout();

            if (PanelContent.Controls.Count > 0)
            {
                _previousPanelContent = PanelContent.Controls[0];
                PanelContent.Controls.Clear();
            }
        }

        

        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(180, 165, 165);
        }

        private void ActivateButton(object senderBtn,Color color)
        {
            if(senderBtn !=null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(60, 65, 92); //rgb(180, 165, 165)
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0,currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(44, 46, 67);//Color.FromArgb(48, 27, 63);
                currentBtn.ForeColor = Color.Gainsboro;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Gainsboro;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void showSettingsDatabaseUserControl()
        {

            UCSettingDatabase uc = new(this);

            PanelContent.SuspendLayout();

            if (PanelContent.Controls.Count > 0)
            {
                _previousPanelContent = PanelContent.Controls[0];
                PanelContent.Controls.Clear();
            }

            uc.Width = this.Width - 20;
            uc.Height = this.Height - 60;
            uc.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(uc);

            PanelContent.ResumeLayout(false);
        }

        private void showPocoModelsUserControl()
        {
            UCPocoModels uc = new();

            PanelContent.SuspendLayout();

            if (PanelContent.Controls.Count > 0)
            {
                _previousPanelContent = PanelContent.Controls[0];
                PanelContent.Controls.Clear();
            }

            uc.Width = this.Width - 330;
            uc.Height = this.Height - 60;
            uc.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(uc);

            PanelContent.ResumeLayout(false);
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

            ActivateButton(sender, RGBColors.color1);
            showSettingsDatabaseUserControl();
        }

        private void btnPOCO_Click(object sender, EventArgs e)
        {
            if (SqlAuth.uid is null)
            {
                MessageBox.Show("setting koneksi untuk menggunakan");
                return;
            }
            ActivateButton(sender, RGBColors.color1);
            showPocoModelsUserControl();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnCRUD_Click(object sender, EventArgs e)
        {
            if (SqlAuth.uid is null)
            {
                MessageBox.Show("setting koneksi untuk menggunakan");
                return;
            }
            ActivateButton(sender, RGBColors.color1);
            showCRUDUserControl();
        }

        private void showCRUDUserControl()
        {

            UCCrud uc = new();

            PanelContent.SuspendLayout();
            

            if (PanelContent.Controls.Count > 0)
            {
                _previousPanelContent = PanelContent.Controls[0];
                PanelContent.Controls.Clear();
                
            }

            PanelContent.Dock = DockStyle.Fill;
            
            uc.Width = this.Width - 330;
            uc.Height = this.Height - 60;
            uc.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(uc);

            PanelContent.ResumeLayout(false);
        }

        private void btnFunction_Click(object sender, EventArgs e)
        {
            UCFunction uc = new();

            PanelContent.SuspendLayout();


            if (PanelContent.Controls.Count > 0)
            {
                _previousPanelContent = PanelContent.Controls[0];
                PanelContent.Controls.Clear();

            }

            PanelContent.Dock = DockStyle.Fill;

            uc.Width = this.Width - 330;
            uc.Height = this.Height - 60;
            uc.Dock = DockStyle.Fill;
            PanelContent.Controls.Add(uc);

            PanelContent.ResumeLayout(false);
        }

        //private void btnValidator_Click(object sender, EventArgs e)
        //{
        //    UCValidator uc = new();

        //    PanelContent.SuspendLayout();


        //    if (PanelContent.Controls.Count > 0)
        //    {
        //        _previousPanelContent = PanelContent.Controls[0];
        //        PanelContent.Controls.Clear();

        //    }

        //    PanelContent.Dock = DockStyle.Fill;

        //    uc.Width = this.Width - 330;
        //    uc.Height = this.Height - 60;
        //    uc.Dock = DockStyle.Fill;
        //    PanelContent.Controls.Add(uc);

        //    PanelContent.ResumeLayout(false);
        //}
    }
}
