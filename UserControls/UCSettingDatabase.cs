using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Npgsql;

namespace BackendTools.UserControls
{
    public partial class UCSettingDatabase : UserControl
    {
        MainForm _parent ;

        public UCSettingDatabase(MainForm parent)
        {
            InitializeComponent();
            this._parent = parent;
        }

        private void chkViewPassword_CheckedChanged(object sender, EventArgs e)
        {
            
            if (chkViewPassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }

        

        private void txtDatabasePort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                MessageBox.Show("port use number only");
            }
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            List<DatabaseSettings> DbSettings;
            var savedDbSettingsJson = Properties.database.Default.connectionList;

            if (savedDbSettingsJson != string.Empty)
            {
                DbSettings =
                    JsonConvert.DeserializeObject<List<DatabaseSettings>>(savedDbSettingsJson);

                var connection = DbSettings.Where(x => x.connectionName == cmbConnectionList.SelectedItem.ToString()).SingleOrDefault();

                SqlAuth.server = connection.host;
                SqlAuth.database = connection.database;
                SqlAuth.port = Convert.ToString(connection.port);
                SqlAuth.uid = connection.username;
                SqlAuth.pass = connection.password;

                this._parent.SetLabelDatabase();
                this._parent.RemoveUserControlFromPanelContent();
            }
        }

        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtServerAddress.Text == string.Empty)
                    return;

                if (txtDatabaseName.Text == string.Empty)
                    return;
                
                if (txtDatabasePort.Text == string.Empty)
                    return;

                if (txtUserName.Text == string.Empty)
                    return;

                if (txtPassword.Text == string.Empty)
                    return;

                SqlAuth.server = txtServerAddress.Text;
                SqlAuth.database = txtDatabaseName.Text;
                SqlAuth.port = txtDatabasePort.Text;
                SqlAuth.uid = txtUserName.Text;
                SqlAuth.pass = txtPassword.Text;

                using (NpgsqlConnection connection = new NpgsqlConnection(SqlAuth.GetConnectionString()))
                {

                    connection.Open();

                    if (connection.State == ConnectionState.Open)
                    {

                        MessageBox.Show("Connection Succesfully");
                    }

                    if (connection.State == ConnectionState.Closed)
                    {
                        MessageBox.Show("Connection failed");
                    }
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR : " + ex.Message);

            }
        }
        

        private void btnConnectAndSave_Click(object sender, EventArgs e)
        {
            //Properties.database.Default.Reset();

            List<DatabaseSettings> DbSettings;
            var savedDbSettingsJson = Properties.database.Default.connectionList;

            if (savedDbSettingsJson != string.Empty)
            {
                DbSettings =
                    JsonConvert.DeserializeObject<List<DatabaseSettings>>(savedDbSettingsJson);

                int connectionCount = DbSettings.Where(x => x.connectionName == txtConnectionName.Text).Count();
                if(connectionCount > 0)
                {
                    MessageBox.Show("connection name sudah ada");
                    return;
                }
            }
            else
            {
                DbSettings = new();
            }

            DatabaseSettings databaseSettings = new();

            databaseSettings.connectionName = txtConnectionName.Text;
            databaseSettings.host = txtServerAddress.Text;
            databaseSettings.database = txtDatabaseName.Text;
            databaseSettings.username = txtUserName.Text;
            databaseSettings.password = txtPassword.Text;
            databaseSettings.port = Convert.ToInt32(txtDatabasePort.Text);

            DbSettings.Add(databaseSettings);

            Properties.database.Default.connectionList = JsonConvert.SerializeObject(DbSettings);
            Properties.database.Default.Save();

            SqlAuth.server = txtServerAddress.Text;
            SqlAuth.database = txtDatabaseName.Text;
            SqlAuth.port = txtDatabasePort.Text;
            SqlAuth.uid = txtUserName.Text;
            SqlAuth.pass = txtPassword.Text;

            MessageBox.Show("Connection Saved");

            this._parent.RemoveUserControlFromPanelContent();
        }

        private void UCSettingDatabase_Load(object sender, EventArgs e)
        {
            LoadConnectionNameToCmb();
        }

        private void LoadConnectionNameToCmb()
        {
            List<DatabaseSettings> DbSettings;
            var savedDbSettingsJson = Properties.database.Default.connectionList;
            if (savedDbSettingsJson != string.Empty)
            {
                DbSettings =
                    JsonConvert.DeserializeObject<List<DatabaseSettings>>(savedDbSettingsJson);

                foreach (DatabaseSettings item in DbSettings)
                {
                    cmbConnectionList.Items.Add(item.connectionName);
                }

                cmbConnectionList.SelectedIndex = 0;

            }
        }
    }

    public record DatabaseSettings
    {
        public string connectionName { get; set; }
        public string host { get; set; }
        public string database { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public int port { get; set; }

    }
}
