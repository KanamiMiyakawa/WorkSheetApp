using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Data;

using IF;
using Const;

namespace Utility
{
    public static class DataGridUtil
    {
        /// <summary>
        /// 選択中の行を取得する
        /// </summary>
        /// <param name="dg"></param>
        /// <returns></returns>
        public static DataGridViewRow GetSelectedRow(DataGridView dg)
        {
            foreach (DataGridViewRow r in dg.SelectedRows)
            {
                return r;
            }
            return null;
        }

        public static void UpdateDataGrid(DataGridView data_Task, string HED_ID)
        {
            using (SQLMain dbMain = new SQLMain())
            {
                try
                {
                    string sql = "SELECT * FROM WORK_PLAN_DTL WHERE HED_ID = @HED_ID ORDER BY PLAN_TIME_START";
                    List<SQLParamIF> bInfo = new List<SQLParamIF>();
                    bInfo.Add(new SQLParamIF("@HED_ID", HED_ID, ColumnType.Numeric));

                    DataTable dt = dbMain.GetDataTable(sql, bInfo);

                    data_Task.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "作業情報取得エラー");
                }

            }
        }
    }
}
