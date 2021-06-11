using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Utility;
using IF;
using Const;

namespace WorkSheetApp
{
    public partial class Form_Menu : Form
    {
        public Form_Menu()
        {
            InitializeComponent();
        }

        private void btn_CreateUser_Click(object sender, EventArgs e)
        {
            //validation
            if (ValidateUtil.IsValidUserName(txtBox_Name.Text) == false)
            {
                MessageBox.Show("0文字以上40文字以下のユーザー名を入力してください", "ユーザー情報エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //ユーザー登録処理
            using (SQLMain dbMain = new SQLMain())
            {
                try
                {
                    dbMain.BeginTran();

                    string sql = "";
                    sql = "INSERT INTO M_USER VALUES(@USER_NAME)";
                    List<SQLParamIF> bInfo = new List<SQLParamIF>();
                    bInfo.Add(new SQLParamIF("@USER_NAME", txtBox_Name.Text, ColumnType.Varchar));
                    dbMain.ExecuteTransaction(sql, bInfo);

                    dbMain.CommitTran();

                    MessageBox.Show("ユーザーを登録しました", "登録", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    dbMain.RollBackTran();

                    MessageBox.Show(ex.Message, "ユーザー登録エラー");
                }
            }
        }

        private void btn_OpenWorkSheet_Click(object sender, EventArgs e)
        {
            //validation
            if (ValidateUtil.IsValidUserName(txtBox_Name.Text) == false)
            {
                MessageBox.Show("0文字以上40文字以下のユーザー名を入力してください", "ユーザー情報エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string userID;
            string userName;

            using (SQLMain dbMain = new SQLMain())
            {
                try
                {
                    string sql = "SELECT * FROM M_USER WHERE USER_NAME = @USER_NAME";
                    List<SQLParamIF> bInfo = new List<SQLParamIF>();
                    bInfo.Add(new SQLParamIF("@USER_NAME", txtBox_Name.Text, ColumnType.Varchar));

                    DataTable dt = dbMain.GetDataTable(sql, bInfo);

                    userID = dt.Rows[0]["USER_ID"].ToString();
                    userName = dt.Rows[0]["USER_NAME"].ToString();
                }
                catch
                {
                    MessageBox.Show("ユーザ情報が取得できませんでした", "ユーザ情報取得エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            Form_WorkSheet fm = new(userID, userName, dPicker_Date);
            fm.Show();
        }

        private void btn_DataBaseSettings_Click(object sender, EventArgs e)
        {

        }
    }
}
