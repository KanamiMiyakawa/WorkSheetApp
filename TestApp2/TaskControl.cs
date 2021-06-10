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
    public partial class TaskControl : Form
    {
        public TaskControl(string HED_ID)
        {
            InitializeComponent();

            lbl_HED_ID.Text = HED_ID;
            lbl_InsertOrUpdate.Text = "INSERT";
        }

        public TaskControl(DataGridViewRow dr, string HED_ID)
        {
            InitializeComponent();

            lbl_HED_ID.Text = HED_ID;
            lbl_DTL_ID.Text = dr.Cells[1].Value.ToString();

            txtBox_Gaiyou.Text = dr.Cells[2].Value.ToString();
            txtBox_Meisai.Text = dr.Cells[3].Value.ToString();

            //Timespan型をDateTime型に変換、年月日はあとで捨てるので適当に補う
            time_PlanTimeStart.Value = DateTime.Parse("2020-01-01 " + dr.Cells[4].FormattedValue);
            time_PlanTimeEnd.Value = DateTime.Parse("2020-01-01 " + dr.Cells[5].FormattedValue);

            if (dr.Cells[6].Value.ToString() == "")
            {
                time_ResultTimeStart.Checked = false;
            }
            else
            {
                time_ResultTimeStart.Value = DateTime.Parse("2020-01-01 " + dr.Cells[6].FormattedValue);
            }

            if (dr.Cells[7].Value.ToString() == "")
            {
                time_ResultTimeEnd.Checked = false;
            }
            else
            {
                time_ResultTimeEnd.Value = DateTime.Parse("2020-01-01 " + dr.Cells[7].FormattedValue);
            }

            check_EndFlag.Checked = (bool)dr.Cells[8].Value;

            lbl_InsertOrUpdate.Text = "UPDATE";
        }

        private void TaskControl_Load(object sender, EventArgs e)
        {

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //入力チェック
            if (txtBox_Gaiyou.Text == "")
            {
                MessageBox.Show("作業概要は必須入力です。", "作業情報エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            } 
            else if (txtBox_Gaiyou.Text.Length > 100)
            {
                MessageBox.Show("作業概要の桁数が超過しています。", "作業情報エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (lbl_InsertOrUpdate.Text == "UPDATE" && MessageBox.Show("作業情報を更新してよろしいですか？(はい/いいえ)", "更新", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
                == DialogResult.No)
            {
                return;
            }

            //保存処理
            using (SQLMain dbMain = new SQLMain())
            {
                try
                {
                    dbMain.BeginTran();

                    string sql = "";
                    if(lbl_InsertOrUpdate.Text == "INSERT")
                    {
                        sql = "INSERT INTO WORK_PLAN_DTL VALUES(@HED_ID, @GAIYOU, @MEISAI, @PLAN_TIME_START, @PLAN_TIME_END, @RESULT_TIME_START, @RESULT_TIME_END, @END_FLAG)";
                        List<SQLParamIF> bInfo = new List<SQLParamIF>();
                        bInfo.Add(new SQLParamIF("@HED_ID", lbl_HED_ID.Text, ColumnType.Varchar));
                        bInfo.Add(new SQLParamIF("@GAIYOU", txtBox_Gaiyou.Text, ColumnType.Varchar));
                        bInfo.Add(new SQLParamIF("@MEISAI", txtBox_Meisai.Text, ColumnType.Varchar));
                        bInfo.Add(new SQLParamIF("@PLAN_TIME_START", time_PlanTimeStart.Value.ToString("HH:mm"), ColumnType.TimeStamp));
                        bInfo.Add(new SQLParamIF("@PLAN_TIME_END", time_PlanTimeEnd.Value.ToString("HH:mm"), ColumnType.TimeStamp));

                        if (time_ResultTimeStart.Checked == true)
                        {
                            bInfo.Add(new SQLParamIF("@RESULT_TIME_START", time_ResultTimeStart.Value.ToString("HH:mm"), ColumnType.TimeStamp));
                        }
                        else
                        {
                            bInfo.Add(new SQLParamIF("@RESULT_TIME_START", "", ColumnType.TimeStamp));
                        }

                        if (time_ResultTimeEnd.Checked == true)
                        {
                            bInfo.Add(new SQLParamIF("@RESULT_TIME_END", time_ResultTimeEnd.Value.ToString("HH:mm"), ColumnType.TimeStamp));
                        }
                        else
                        {
                            bInfo.Add(new SQLParamIF("@RESULT_TIME_END", "", ColumnType.TimeStamp));
                        }

                        bInfo.Add(new SQLParamIF("@END_FLAG", check_EndFlag.Checked, ColumnType.Varchar));
                        dbMain.ExecuteTransaction(sql, bInfo);
                    }
                    else
                    {
                        sql = "UPDATE WORK_PLAN_DTL SET GAIYOU = @GAIYOU, MEISAI = @MEISAI, PLAN_TIME_START = @PLAN_TIME_START, PLAN_TIME_END = @PLAN_TIME_END, RESULT_TIME_START = @RESULT_TIME_START, RESULT_TIME_END = @RESULT_TIME_END, END_FLAG = @END_FLAG WHERE DTL_ID = @DTL_ID";
                        List<SQLParamIF> bInfo = new List<SQLParamIF>();
                        bInfo.Add(new SQLParamIF("@GAIYOU", txtBox_Gaiyou.Text, ColumnType.Varchar));
                        bInfo.Add(new SQLParamIF("@MEISAI", txtBox_Meisai.Text, ColumnType.Varchar));
                        bInfo.Add(new SQLParamIF("@PLAN_TIME_START", time_PlanTimeStart.Value.ToString("HH:mm"), ColumnType.TimeStamp));
                        bInfo.Add(new SQLParamIF("@PLAN_TIME_END", time_PlanTimeEnd.Value.ToString("HH:mm"), ColumnType.TimeStamp));

                        if (time_ResultTimeStart.Checked == true)
                        {
                            bInfo.Add(new SQLParamIF("@RESULT_TIME_START", time_ResultTimeStart.Value.ToString("HH:mm"), ColumnType.TimeStamp));
                        }
                        else
                        {
                            bInfo.Add(new SQLParamIF("@RESULT_TIME_START", "", ColumnType.TimeStamp));
                        }

                        if (time_ResultTimeEnd.Checked == true)
                        {
                            bInfo.Add(new SQLParamIF("@RESULT_TIME_END", time_ResultTimeEnd.Value.ToString("HH:mm"), ColumnType.TimeStamp));
                        }
                        else
                        {
                            bInfo.Add(new SQLParamIF("@RESULT_TIME_END", "", ColumnType.TimeStamp));
                        }

                        bInfo.Add(new SQLParamIF("@END_FLAG", check_EndFlag.Checked, ColumnType.Varchar));
                        bInfo.Add(new SQLParamIF("@DTL_ID", lbl_DTL_ID.Text, ColumnType.Varchar));
                        dbMain.ExecuteTransaction(sql, bInfo);
                    }

                    dbMain.CommitTran();

                    if (lbl_InsertOrUpdate.Text == "INSERT")
                    {
                        MessageBox.Show("作業情報を保存しました", "保存", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("作業情報を更新しました", "更新", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.Close();
                }
                catch (Exception ex)
                {
                    dbMain.RollBackTran();

                    MessageBox.Show(ex.Message, "作業情報更新エラー");
                }
            }
        }

        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
