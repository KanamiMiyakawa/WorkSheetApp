using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace WorkSheetApp
{
    public partial class DataBaseSettings : Form
    {
        public DataBaseSettings()
        {
            InitializeComponent();

            var DBSettings = ConfigurationManager.AppSettings;
            lbl_oldServerName.Text = DBSettings["dbServer"] ?? "Not Found";
            lbl_oldUserName.Text = DBSettings["dbUser"] ?? "Not Found";
            lbl_oldDBName.Text = DBSettings["dbName"] ?? "Not Found";
        }

        private void btn_tryConnect_Click(object sender, EventArgs e)
        {
            string _conServer = txtBox_newServerName.Text;
            string _conUser = txtBox_newUserName.Text;
            string _conPwd = txtBox_newPassword.Text;
            string _conDataBase = txtBox_newDBName.Text;
            object _conn = null;

            string strConnString = string.Format("server={0};database={1};User ID={2};Password={3};"
                , _conServer, _conDataBase, _conUser, _conPwd);

            try
            {
                _conn = new SqlConnection(strConnString);
                ((SqlConnection)_conn).Open();
                MessageBox.Show("接続に成功しました", "接続テスト");
                ((SqlConnection)_conn).Close();
                ((SqlConnection)_conn).Dispose();
                _conn = null;
            }
            catch
            {
                MessageBox.Show("接続に失敗しました", "接続テスト");
                ((SqlConnection)_conn).Close();
                ((SqlConnection)_conn).Dispose();
                _conn = null;
            }
        }

        private void btn_saveSetting_Click(object sender, EventArgs e)
        {
            try
            {
                var configFile = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                var DBSettings = configFile.AppSettings.Settings;

                DBSettings["dbServer"].Value = txtBox_newServerName.Text;
                DBSettings["dbUser"].Value = txtBox_newUserName.Text;
                DBSettings["dbPwd"].Value = txtBox_newPassword.Text;
                DBSettings["dbName"].Value = txtBox_newDBName.Text;

                configFile.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection(configFile.AppSettings.SectionInformation.Name);

                MessageBox.Show("新しい設定を保存しました", "接続設定の変更");

                this.Close();
            }
            catch (ConfigurationErrorsException)
            {
                MessageBox.Show("設定の保存に失敗しました", "接続設定の変更");
            }
        }

        private void btn_closeWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
