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
    }
}
