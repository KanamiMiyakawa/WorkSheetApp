using System;
using System.Data;
using System.Configuration;
using Const;
namespace IF
{
    /// <summary>
    /// SQLパラメータ保持クラス
    /// </summary>
    public class SQLParamIF
    {
        public string DbParameterName = "";
        public string DbType = null;
        public object DbValue = DBNull.Value;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="pName">パラメータ名(置換文字)</param>
        /// <param name="pval">値</param>
        /// <param name="ptype">型</param>
        public SQLParamIF(string pName, object pval, string ptype)
        {

            DbParameterName = pName;
            DbType = ptype;
            if (string.IsNullOrEmpty(pval.ToString()))
            {
                DbValue = DBNull.Value;
            }
            else if (ptype == ColumnType.Numeric)
            {
                DbValue = Decimal.Parse(pval.ToString());
            }
            else if (ptype == ColumnType.TimeStamp)
            {
                DbValue = DateTime.Parse(pval.ToString());
            }
            else
            {
                DbValue = pval;
            }
        }

        /// <summary>
        /// コンストラクタ(Varchar専用)
        /// </summary>
        /// <param name="pName">パラメータ名(置換文字)</param>
        /// <param name="pval">値</param>
        public SQLParamIF(string pName, object pval)
        {
            DbParameterName = pName;
            DbType = ColumnType.Varchar;
            DbValue = pval;
        }

        /// <summary>
        /// SQLServer用のDbTypeの取得
        /// </summary>
        /// <returns></returns>
        public SqlDbType GetSqlDbType()
        {
            if (DbType == ColumnType.Char)
            {
                return SqlDbType.Char;
            }
            else if (DbType == ColumnType.Numeric)
            {
                return SqlDbType.Decimal;
            }
            else if (DbType == ColumnType.TimeStamp)
            {
                return SqlDbType.DateTime;
            }
            else if (DbType == ColumnType.NVarChar)
            {
                return SqlDbType.NVarChar;
            }
            else
            {
                return SqlDbType.VarChar;
            }
        }

    }
}

