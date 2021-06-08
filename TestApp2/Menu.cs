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
            if (txtBox_Name.Text == "")
            {
                MessageBox.Show("ユーザー名は必須入力です。", "ユーザー登録エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (txtBox_Name.Text.Length > 40)
            {
                MessageBox.Show("ユーザー名の桁数が超過しています。", "ユーザー登録エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
