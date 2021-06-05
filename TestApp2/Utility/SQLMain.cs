using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Data.SqlClient;
using IF;
using Const;


namespace Utility
{
    /// <summary>
    /// DB操作クラス
    /// </summary>
    public class SQLMain : IDisposable
    {
        //log4Net
        //private static log4net.ILog _logger = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private object _conn = null;
        private string _conServer = "";
        private string _conDataBase = "";
        private string _conUser = "";
        private string _conPwd = "";
        public object _transaction = null;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public SQLMain()
        {
            _conServer = ConfigurationManager.AppSettings["dbServer"];
            _conDataBase = ConfigurationManager.AppSettings["dbName"];
            _conUser = ConfigurationManager.AppSettings["dbUser"];
            _conPwd = ConfigurationManager.AppSettings["dbPwd"];
            _conn = Connection();
        }

        /// <summary>
        /// コンストラクタ(DB名指定)
        /// </summary>
        /// <param name="dbName">DB名</param>
        public SQLMain(string dbName)
        {
            _conServer = ConfigurationManager.AppSettings["dbServer"];
            _conDataBase = dbName;
            _conUser = ConfigurationManager.AppSettings["dbUser"];
            _conPwd = ConfigurationManager.AppSettings["dbPwd"];
            _conn = Connection();
        }

        /// <summary>
        /// デストラクタ
        /// </summary>
        public void Dispose()
        {
            DisConnection();
        }

        /// <summary>
        /// DBへの接続情報を設定し接続を開きます
        /// </summary>
        /// <returns></returns>
        public object Connection()
        {
            string strConnString = string.Format("server={0};database={1};User ID={2};Password={3};"
                , _conServer, _conDataBase, _conUser, _conPwd);
            try
            {
                if (_conn == null)
                {
                    _conn = new SqlConnection(strConnString);
                }

                if (((SqlConnection)_conn).State == ConnectionState.Closed)
                {
                    ((SqlConnection)_conn).Open();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return _conn;
        }

        /// <summary>
        /// DBへの接続を閉じ接続情報を破棄します
        /// </summary>
        public void DisConnection()
        {
            if (_conn != null)
            {
                if (((SqlConnection)_conn).State != ConnectionState.Closed)
                {
                    ((SqlConnection)_conn).Close();
                }
                ((SqlConnection)_conn).Dispose();
                _conn = null;
            }
        }

        /// <summary>
        /// DBへの接続を開きます
        /// </summary>
        public void Open()
        {
            ((SqlConnection)_conn).Open();
        }

        /// <summary>
        /// DBへの接続を閉じます
        /// </summary>
        public void Close()
        {
            ((SqlConnection)_conn).Close();
        }

        /// <summary>
        /// トランザクションの開始
        /// </summary>
        /// <returns></returns>
        public object BeginTran()
        {
            try
            {
                _transaction = ((SqlConnection)_conn).BeginTransaction();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return _transaction;
        }

        /// <summary>
        /// トランザクションのコミット
        /// </summary>
        public void CommitTran()
        {
            try
            {
                ((SqlTransaction)_transaction).Commit();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// トランザクションのロールバック
        /// </summary>
        public void RollBackTran()
        {
            try
            {
                ((SqlTransaction)_transaction).Rollback();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// SQLの実行(Transaction系のみ SELECTはGetDataReaderかGetDataSetを使うこと)
        /// </summary>
        /// <param name="sql">SQL文</param>
        /// <param name="param">パラメータ</param>
        public void ExecuteTransaction(string sql, List<SQLParamIF> param)
        {
            //OutputDBLog(sql, param);
            try
            {
                object oSqlCommand = new SqlCommand(sql, (SqlConnection)_conn);
                ((SqlCommand)oSqlCommand).Transaction = (SqlTransaction)_transaction;
                ParamSet(ref oSqlCommand, param);
                ((SqlCommand)oSqlCommand).ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// SQLを実行しDataSetを返します(SELECT系のみ TransactionはExecuteを使うこと)
        /// </summary>
        /// <param name="psql">SQL文</param>
        /// <param name="pparam">パラメータ</param>
        public DataSet GetDataSet(string sql, List<SQLParamIF> param)
        {
            //OutputDBLog(sql, param);
            DataSet ret = new DataSet();
            try
            {
                object oSqlCommand = new SqlCommand(sql, (SqlConnection)_conn);
                ((SqlCommand)oSqlCommand).Transaction = (SqlTransaction)_transaction;
                ParamSet(ref oSqlCommand, param);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = (SqlCommand)oSqlCommand;

                da.Fill(ret);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return ret;
        }

        /// <summary>
        /// SQLを実行しDataTableを返します(SELECT系のみ TransactionはExecuteを使うこと)
        /// </summary>
        /// <param name="psql">SQL文</param>
        /// <param name="pparam">パラメータ</param>
        /// <returns></returns>
        public DataTable GetDataTable(string sql, List<SQLParamIF> param)
        {
            return GetDataSet(sql, param).Tables[0];
        }

        /// <summary>
        /// パラメータの設定
        /// </summary>
        /// <param name="oSqlCommand">SqlCommand</param>
        /// <param name="pparam">パラメータのリスト</param>
        private void ParamSet(ref object oSqlCommand, List<SQLParamIF> pparam)
        {
            foreach (SQLParamIF item in pparam)
            {
                SqlParameter addParam = ((SqlCommand)oSqlCommand).CreateParameter();
                addParam.ParameterName = item.DbParameterName;
                addParam.SqlDbType = item.GetSqlDbType();
                addParam.Direction = ParameterDirection.Input;
                addParam.Value = item.DbValue;
                ((SqlCommand)oSqlCommand).Parameters.Add(addParam);
            }
        }

        ///// <summary>
        ///// DBログ(DEBUG)の出力
        ///// </summary>
        ///// <param name="pSql">sql文</param>
        ///// <param name="pparam">パラメータ</param>
        //private void OutputDBLog(string pSql, List<SQLParamIF> pparam)
        //{
        //    string msg = "\r\n";
        //    foreach (SQLParamIF item in pparam)
        //    {
        //        msg += "DECLARE " + item.DbParameterName + " " + GetDbType(item.DbType) + " = " + CnvDBValue(item.DbType, item.DbValue.ToString()) + ";\r\n";
        //    }
        //    msg += pSql;
        //    _logger.Debug(msg);
        //}


        /// <summary>
        /// DB型の取得
        /// </summary>
        /// <param name="pType"></param>
        /// <returns></returns>
        private string GetDbType(string pType)
        {
            if (pType == ColumnType.Char)
            {
                return "VARCHAR(MAX)";
            }
            else if (pType == ColumnType.Numeric)
            {
                return "NUMERIC";
            }
            else if (pType == ColumnType.TimeStamp)
            {
                return "TIMESTAMP";
            }
            else if (pType == ColumnType.NVarChar)
            {
                return "NVARCHAR(MAX)";
            }
            else
            {
                return "VARCHAR(MAX)";
            }
        }


        /// <summary>
        /// DB値変換
        /// </summary>
        /// <param name="pType"></param>
        /// <param name="pValue"></param>
        /// <returns></returns>
        private string CnvDBValue(string pType, string pValue)
        {
            bool addSingleQuate = false;

            if (pType == ColumnType.Char || pType == ColumnType.Varchar || pType == ColumnType.TimeStamp || pType == ColumnType.NVarChar)
            {
                addSingleQuate = true;
            }
            else
            {
                addSingleQuate = false;
            }

            if (addSingleQuate)
            {
                return "'" + pValue.Replace("'", "''") + "'";
            }
            else
            {
                if (string.IsNullOrEmpty(pValue))
                {
                    return "NULL";
                }
                else
                {
                    return pValue;
                }
            }
        }

    }
}
