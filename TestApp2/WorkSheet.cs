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
    public partial class Form_WorkSheet : Form
    {
        //gitテスト
        //commitテスト
        //commitテスト２

        //DBテスト用変数
        private string USER_ID = "1";
        private string TODAY_DATE = "2021-06-05";

        public Form_WorkSheet()
        {
            InitializeComponent();
        }

        private void WorkSheet_Load(object sender, EventArgs e)
        {
            //ユーザ情報取得
            using (SQLMain dbMain = new SQLMain())
            {
                try
                {
                    string sql = "SELECT * FROM M_USER WHERE USER_ID = @USER_ID";
                    List<SQLParamIF> bInfo = new List<SQLParamIF>();
                    bInfo.Add(new SQLParamIF("@USER_ID", USER_ID, ColumnType.Numeric));

                    DataTable dt = dbMain.GetDataTable(sql, bInfo);

                    lbl_Name.Text = dt.Rows[0]["USER_NAME"].ToString();
                    lbl_USER_ID.Text = dt.Rows[0]["USER_ID"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "ユーザ情報取得エラー");
                }
            }

            txtBox_Date.Text = TODAY_DATE;

            btn_Search_Click(null, null);
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            //日次情報取得
            using (SQLMain dbMain = new SQLMain())
            {
                try
                {
                    string sql = "SELECT * FROM WORK_PLAN_HED WHERE USER_ID = @USER_ID AND WORK_DATE = @WORK_DATE";
                    List<SQLParamIF> bInfo = new List<SQLParamIF>();
                    bInfo.Add(new SQLParamIF("@USER_ID", USER_ID, ColumnType.Numeric));
                    bInfo.Add(new SQLParamIF("@WORK_DATE", txtBox_Date.Text, ColumnType.TimeStamp));

                    DataTable dt = dbMain.GetDataTable(sql, bInfo);

                    lbl_HED_ID.Text = dt.Rows[0]["HED_ID"].ToString();
                    lbl_SumScheduledTime.Text = "合計予定時間 " + dt.Rows[0]["PLAN_TIME_SUM"].ToString() + "時間";
                    lbl_SumEndedTime.Text = "合計終了時間 " + dt.Rows[0]["RESULT_TIME_SUM"].ToString() + "時間";
                    txtBox_Comment1.Text = dt.Rows[0]["COMMENT1"].ToString();
                    txtBox_Comment2.Text = dt.Rows[0]["COMMENT2"].ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "日次情報取得エラー");
                }
            }

            //作業情報取得
            DataGridUtil.UpdateDataGrid(data_Task, lbl_HED_ID.Text);

        }

        private void btn_AddTask_Click(object sender, EventArgs e)
        {
            TaskControl fm = new(lbl_HED_ID.Text);
            fm.ShowDialog();

            DataGridUtil.UpdateDataGrid(data_Task, lbl_HED_ID.Text);
        }
        private void btn_EditTask_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = DataGridUtil.GetSelectedRow(data_Task);
            TaskControl fm = new(dr, lbl_HED_ID.Text);
            fm.ShowDialog();

            DataGridUtil.UpdateDataGrid(data_Task, lbl_HED_ID.Text);
        }

        private void btn_CommentUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("コメントを更新してよろしいですか？(はい/いいえ)", "更新"
                , MessageBoxButtons.YesNo
                , MessageBoxIcon.Exclamation
                )== DialogResult.No)
            {
                return;
            }

            using (SQLMain dbMain = new SQLMain())
            {
                try
                {
                    dbMain.BeginTran();

                    string sql = @"UPDATE WORK_PLAN_HED SET 
                                          COMMENT1 = @COMMENT1
                                        , COMMENT2 = @COMMENT2 
                                    WHERE HED_ID = @HED_ID";
                    List<SQLParamIF> bInfo = new List<SQLParamIF>();
                    bInfo.Add(new SQLParamIF("@COMMENT1", txtBox_Comment1.Text, ColumnType.Varchar));
                    bInfo.Add(new SQLParamIF("@COMMENT2", txtBox_Comment2.Text, ColumnType.Varchar));
                    bInfo.Add(new SQLParamIF("@HED_ID", lbl_HED_ID.Text, ColumnType.Numeric));
                    dbMain.ExecuteTransaction(sql, bInfo);

                    dbMain.CommitTran();

                    MessageBox.Show("コメントを更新しました", "更新");
                }
                catch (Exception ex)
                {
                    dbMain.RollBackTran();

                    MessageBox.Show(ex.Message, "コメント更新エラー");
                }
            }
        }

        private void btn_DeleteTask_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("作業情報を削除してよろしいですか？(はい/いいえ)", "削除", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                == DialogResult.No)
            {
                return;
            }

            DataGridViewRow dr = DataGridUtil.GetSelectedRow(data_Task);
            String DTL_ID = dr.Cells[1].Value.ToString();

            using (SQLMain dbMain = new SQLMain())
            {
                try
                {
                    dbMain.BeginTran();

                    string sql = "DELETE FROM WORK_PLAN_DTL WHERE DTL_ID = @DTL_ID";
                    List<SQLParamIF> bInfo = new List<SQLParamIF>();
                    bInfo.Add(new SQLParamIF("@DTL_ID", DTL_ID, ColumnType.Numeric));
                    dbMain.ExecuteTransaction(sql, bInfo);

                    dbMain.CommitTran();

                    MessageBox.Show("作業情報を削除しました", "削除");
                }
                catch (Exception ex)
                {
                    dbMain.RollBackTran();

                    MessageBox.Show(ex.Message, "作業情報削除エラー");
                }

                DataGridUtil.UpdateDataGrid(data_Task, lbl_HED_ID.Text);
            }
        }
    }
}
