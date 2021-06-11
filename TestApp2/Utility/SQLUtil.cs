using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Utility;
using IF;
using Const;

namespace Utility
{
    public static class SQLUtil
    {
        public static DataTable SearchWorkPlanHed(string UserID, string WorkDate)
        {
            using (SQLMain dbMain = new SQLMain())
            {
                try
                {
                    string sql = "SELECT * FROM WORK_PLAN_HED WHERE USER_ID = @USER_ID AND WORK_DATE = @WORK_DATE";
                    List<SQLParamIF> bInfo = new List<SQLParamIF>();
                    bInfo.Add(new SQLParamIF("@USER_ID", UserID, ColumnType.Numeric));
                    bInfo.Add(new SQLParamIF("@WORK_DATE", WorkDate, ColumnType.TimeStamp));

                    return dbMain.GetDataTable(sql, bInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "日次情報検索エラー");
                    throw;
                }
            }
        }
        public static DataTable SearchWorkPlanHed(int HED_ID)
        {
            using (SQLMain dbMain = new SQLMain())
            {
                try
                {
                    string sql = "SELECT * FROM WORK_PLAN_HED WHERE HED_ID = @HED_ID";
                    List<SQLParamIF> bInfo = new List<SQLParamIF>();
                    bInfo.Add(new SQLParamIF("@HED_ID", HED_ID, ColumnType.Numeric));

                    return dbMain.GetDataTable(sql, bInfo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "日次情報検索エラー");
                    throw;
                }
            }
        }
        public static void CreateWorkPlanHed(string UserID, string WorkDate)
        {
            using (SQLMain dbMain = new SQLMain())
            {
                try
                {
                    dbMain.BeginTran();

                    string sql = "INSERT INTO WORK_PLAN_HED VALUES(@USER_ID, @WORK_DATE, 0.0, 0.0, '', '')";
                    List<SQLParamIF> bInfo = new List<SQLParamIF>();
                    bInfo.Add(new SQLParamIF("@USER_ID", UserID, ColumnType.Numeric));
                    bInfo.Add(new SQLParamIF("@WORK_DATE", WorkDate, ColumnType.TimeStamp));
                    dbMain.ExecuteTransaction(sql, bInfo);

                    dbMain.CommitTran();

                    MessageBox.Show("日次情報を作成しました", "日次情報作成");
                }
                catch (Exception ex)
                {
                    dbMain.RollBackTran();
                    MessageBox.Show(ex.Message, "日次作成検索エラー");
                    throw;
                }
            }
        }

        public static void UpdateWorkTimeSumOnHED(string HED_ID)
        {
            using (SQLMain dbMain = new SQLMain())
            {
                try
                {
                    dbMain.BeginTran();

                    //作業時間を合計
                    DataTable dt;
                    TimeSpan SumPlanTime = new TimeSpan(0);
                    TimeSpan SumResultTime = new TimeSpan(0);

                    string sql = "SELECT * FROM WORK_PLAN_DTL WHERE HED_ID = @HED_ID";
                    List<SQLParamIF> bInfo1 = new List<SQLParamIF>();
                    bInfo1.Add(new SQLParamIF("@HED_ID", HED_ID, ColumnType.Numeric));

                    dt = dbMain.GetDataTable(sql, bInfo1);

                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        SumPlanTime = SumPlanTime + TimeSpan.Parse(dt.Rows[i][5].ToString()) - TimeSpan.Parse(dt.Rows[i][4].ToString());

                        object dt8 = dt.Rows[i][8];

                        if (dt.Rows[i][8].Equals(true))
                        {
                            SumResultTime = SumResultTime + TimeSpan.Parse(dt.Rows[i][7].ToString()) - TimeSpan.Parse(dt.Rows[i][6].ToString());
                        }
                    }

                    //合計値をDBに保存
                    sql = "UPDATE WORK_PLAN_HED SET PLAN_TIME_SUM = @PLAN_TIME_SUM, RESULT_TIME_SUM = @RESULT_TIME_SUM WHERE HED_ID = @HED_ID";
                    List<SQLParamIF> bInfo2 = new List<SQLParamIF>();
                    bInfo2.Add(new SQLParamIF("@PLAN_TIME_SUM", Math.Round(SumPlanTime.TotalHours, 1, MidpointRounding.AwayFromZero), ColumnType.Numeric));
                    bInfo2.Add(new SQLParamIF("@RESULT_TIME_SUM", Math.Round(SumResultTime.TotalHours, 1, MidpointRounding.AwayFromZero), ColumnType.Numeric));
                    bInfo2.Add(new SQLParamIF("@HED_ID", HED_ID, ColumnType.Numeric));

                    dbMain.ExecuteTransaction(sql, bInfo2);

                    dbMain.CommitTran();
                }
                catch (Exception ex)
                {
                    dbMain.RollBackTran();

                    MessageBox.Show(ex.Message, "作業時間合計エラー");
                    throw;
                }
            }
        }
    }
}
