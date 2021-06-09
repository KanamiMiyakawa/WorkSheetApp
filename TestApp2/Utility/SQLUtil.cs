using System;
using System.Collections.Generic;
using System.Data;
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
                string sql = "SELECT * FROM WORK_PLAN_HED WHERE USER_ID = @USER_ID AND WORK_DATE = @WORK_DATE";
                List<SQLParamIF> bInfo = new List<SQLParamIF>();
                bInfo.Add(new SQLParamIF("@USER_ID", UserID, ColumnType.Numeric));
                bInfo.Add(new SQLParamIF("@WORK_DATE", WorkDate, ColumnType.TimeStamp));

                return dbMain.GetDataTable(sql, bInfo);
            }
        }
    }
}
