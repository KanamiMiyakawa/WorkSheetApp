using System;
using System.Data;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Utility
{
    /// <summary>
    /// 入力チェックユーティリティ
    /// </summary>
    public static class ValidateUtil
    {

        public const string SPLIT_MARK = "@@";

        /// <summary>
        /// 桁数チェック
        /// </summary>
        /// <param name="value">値</param>
        /// <param name="maxLength">最大桁数</param>
        /// <returns>true:桁数以内、false:桁数超</returns>
        public static bool IsEffectiveLength(string value, int maxLength)
        {
            if (StringUtil.GetByteLength(value) > maxLength)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 数値チェック
        /// </summary>
        /// <param name="value">値</param>
        /// <returns>true:空文字or数値、false:数値以外</returns>
        public static bool IsNumeric(string value)
        {
            bool result = true;
            if (!string.IsNullOrEmpty(value))
            {
                decimal work;
                result = decimal.TryParse(value, out work);
            }

            return result;
        }

        /// <summary>
        /// 日付チェック
        /// </summary>
        /// <param name="value">値</param>
        /// <returns>true:日付、false:日付以外</returns>
        public static bool IsDate(string value)
        {
            bool result = true;
            if (!string.IsNullOrEmpty(value))
            {
                DateTime dt;
                result = DateTime.TryParse(value, out dt);
                if (result == true)
                {

                    //正規表現で、YYYY/MM/DDの形か検証
                    Regex rTemp = new Regex(
                            @"^(?<year>[0-9]{4}|[0-9]{2})(?<datesep>\/|-|\.)" +
                            @"(?<month>0?[1-9]|1[012])\k<datesep>" +
                            @"(?<day>0?[1-9]|[12][0-9]|3[01])$");
                    if (rTemp.IsMatch(value))
                    {
                        result = true;
                    }
                    else
                    {
                        result = false;
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// 日付時間チェック
        /// </summary>
        /// <param name="value">値</param>
        /// <returns>true:日付時間、false:日付時間以外</returns>
        public static bool IsDateTime(string value)
        {
            bool result = true;
            if (!string.IsNullOrEmpty(value))
            {
                DateTime dt;
                result = DateTime.TryParse(value, out dt);
            }

            return result;
        }

        /// <summary>
        /// NG文字列チェック
        /// </summary>
        /// <param name="value">値</param>
        /// <param name="ngWords">NG文字列</param>
        /// <returns>true:NG文字列を含まない、false:NG文字列を含む</returns>
        public static bool IsNotNGWords(string value, string ngWords)
        {
            for (int i = 0; i < ngWords.Length; i++)
            {
                string ngWord = ngWords.Substring(i, 1);
                if (value.IndexOf(ngWord) >= 0)
                {
                    return false;
                }
            }
            return true;
        }

        /// <summary>
        /// 限定文字列チェック　※主に区分値の確認用
        /// </summary>
        /// <param name="value">値</param>
        /// <param name="onlyWords">OK文字列　※カンマ区切りで指定する　例)1,2,3</param>
        /// <returns>true:限定文字列、false:限定文字列以外が使用されている</returns>
        public static bool IsOnlyWords(string value, string onlyWords)
        {
            string[] tempAry = onlyWords.Split(',');

            for (int i = 0; i < tempAry.Length; i++)
            {
                if (value == tempAry[i])
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// 小数点の桁数チェック
        /// </summary>
        /// <param name="val">値</param>
        /// <param name="intLength">最大整数部桁数</param>
        /// <param name="decLength">最大小数部桁数</param>
        /// <returns>true:桁数以内で構成されている整数or整数+小数、false:桁数超</returns>
        public static bool IsEffectiveDecimalLength(string val, int intLength, int decLength)
        {
            //Decimalに変換できないものは数値としてみなさない
            if (IsNumeric(val) == false)
            {
                return false;
            }

            //正規表現で、整数＋小数と、整数のみ両方検証し、桁数内であればOK
            Regex rTemp = new Regex(@"^-?[0-9]{1," + intLength + @"}\.[0-9]{1," + decLength +
                                        @"}$|^-?[0-9]{1," + intLength + "}$");
            if (rTemp.IsMatch(decimal.Parse(val).ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 整数の桁数チェック
        /// </summary>
        /// <param name="val">値</param>
        /// <param name="intLength">最大整数部桁数</param>
        /// <returns>true:桁数以内で構成されている整数、false:桁数超</returns>
        public static bool IsEffectiveIntegerLength(string val, int intLength)
        {
            //Decimalに変換できないものは数値としてみなさない
            if (IsNumeric(val) == false)
            {
                return false;
            }

            //正規表現で、桁数内であればOK
            Regex rTemp = new Regex(@"^-?[0-9]{1," + intLength + @"}$");
            if (rTemp.IsMatch(decimal.Parse(val).ToString()))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 郵便番号チェック
        /// </summary>
        /// <param name="value">値</param>
        /// <returns>true:郵便番号、false:郵便番号以外</returns>
        public static bool IsPost(string value)
        {
            bool result = true;
            if (!string.IsNullOrEmpty(value))
            {
                //正規表現で、999-9999の形か検証
                Regex rTemp = new Regex(@"(?<postcode>0\d{3}-\d{4}-\d{4}?)");
                if (rTemp.IsMatch(value))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
            }

            return result;
        }

        /// <summary>
        /// 値がリスト内にあるか確認する
        /// </summary>
        /// <param name="val">値</param>
        /// <param name="listTarget">リスト</param>
        /// <returns>true:リストに存在している、false:リストに存在していない</returns>
        public static bool IsExistsList(string value, List<string> listTarget)
        {
            if (listTarget.Contains(value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 重複チェック
        /// </summary>
        /// <param name="listValue">値</param>
        /// <returns>true:重複していない、false:重複している</returns>
        public static bool IsNotDuplicate(List<string> listTarget)
        {
            List<string> listTemp = new List<string>();
            for (int i = 0; i < listTarget.Count; i++)
            {
                if (listTemp.Contains(listTarget[i]))
                {
                    return false;
                }
                else
                {
                    listTemp.Add(listTarget[i]);
                }
            }
            return true;

        }

        /// <summary>
        /// データテーブルからマスタ参照チェック用のリストを作成する
        /// </summary>
        /// <param name="dt"></param>
        /// <param name="columnsArray"></param>
        /// <returns></returns>
        public static List<string> DataTableToMasterList(DataTable dt, string[] columnsArray)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string wk = "";
                for (int j = 0; j < columnsArray.Length; j++)
                {
                    for (int k = 0; k < dt.Columns.Count; k++)
                    {
                        if (dt.Columns[k].ColumnName == columnsArray[j])
                        {
                            if (string.IsNullOrEmpty(wk))
                            {
                                wk = dt.Rows[i][k].ToString();
                            }
                            else
                            {
                                wk += SPLIT_MARK + dt.Rows[i][k].ToString();
                            }
                            break;
                        }
                    }
                }

                result.Add(wk);
            }
            return result;
        }

        ///// <summary>
        ///// エラーリスト内のメッセージを連結し、文字列を返す
        ///// </summary>
        ///// <param name="errList">エラーリスト</param>
        ///// <param name="joinString">接続文字列(改行コード等)</param>
        ///// <returns>文字列</returns>
        //public static string CnvListErrorMessageToString(List<TRAIN.IF.ErrInfoIF> errList, string joinString)
        //{
        //    string result = "";
        //    for (int i = 0; i < errList.Count; i++)
        //    {
        //        if (string.IsNullOrEmpty(result))
        //        {
        //            result = errList[i].ErrorMessage;
        //        }
        //        else
        //        {
        //            result += joinString + errList[i].ErrorMessage;
        //        }
        //    }
        //    return result;
        //}

        ///// <summary>
        ///// マスタ参照チェック用のリスト作成
        ///// </summary>
        ///// <param name="lst">マスタリスト</param>
        ///// <param name="db">DBオブジェクト</param>
        ///// <param name="refTableName">参照テーブル名</param>
        ///// <param name="targetColumn">参照元の物理カラム名</param>
        ///// <param name="isDeleteEffective">削除データを取得するか</param>
        //public static void MakeMasterListItem(ref Dictionary<string, List<string>> lst, SQLMain dbMain, string refTableName, string targetColumn, bool isDeleteEffective)
        //{
        //    List<SQLParamIF> bInfo = new List<SQLParamIF>();
        //    List<string> item = new List<string>();
        //    string whereCondition = "WHERE 0 = 0";
        //    if (isDeleteEffective == false)
        //    {
        //        whereCondition = "WHERE DELETE_FLG = @DELETE_FLG";
        //        bInfo.Add(new SQLParamIF("@DELETE_FLG", Flag.OFF, ColumnType.Char));
        //    }

        //    if (refTableName=="ユーザーマスタ")
        //    {
        //        MUserDB db = new MUserDB(dbMain);
        //        DataTable dt = db.Search(whereCondition, bInfo);
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            item.Add(dt.Rows[i]["USER_ID"].ToString());
        //        }

        //    }
        //    else if (refTableName == "郵便番号マスタ")
        //    {
        //        MPostDB db = new MPostDB(dbMain);
        //        DataTable dt = db.Search(whereCondition, bInfo);
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            item.Add(dt.Rows[i]["POST_NO"].ToString());
        //        }

        //    }
        //    else if (refTableName == "ファイル取得元情報マスタ")
        //    {
        //        MGetDataDB db = new MGetDataDB(dbMain);
        //        DataTable dt = db.Search(whereCondition, bInfo);
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            item.Add(dt.Rows[i]["GET_DATA_ID"].ToString());
        //        }
        //    }
        //    else if (refTableName == "会社情報")
        //    {
        //        TCompanyDB db = new TCompanyDB(dbMain);
        //        DataTable dt = db.Search(whereCondition, bInfo);
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            item.Add(dt.Rows[i]["COMPANY_ID"].ToString());
        //        }
        //    }
        //    else if (refTableName == "事業所情報")
        //    {
        //        TOfficeDB db = new TOfficeDB(dbMain);
        //        DataTable dt = db.Search(whereCondition, bInfo);
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            item.Add(dt.Rows[i]["OFFICE_ID"].ToString());
        //        }
        //    }
        //    else if (refTableName == "顧客情報")
        //    {
        //        TPersonDB db = new TPersonDB(dbMain);
        //        DataTable dt = db.Search(whereCondition, bInfo);
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            item.Add(dt.Rows[i]["PERSON_ID"].ToString());
        //        }
        //    }
        //    else if (refTableName == "カテゴリー分類マスタ")
        //    {
        //        MCtgTypeDB db = new MCtgTypeDB(dbMain);
        //        DataTable dt = db.Search(whereCondition, bInfo);
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            item.Add(dt.Rows[i]["CTG_TYPE_ID"].ToString());
        //        }
        //    }
        //    else if (refTableName == "メールマスタ")
        //    {
        //        MMailDB db = new MMailDB(dbMain);
        //        DataTable dt = db.Search(whereCondition, bInfo);
        //        for (int i = 0; i < dt.Rows.Count; i++)
        //        {
        //            item.Add(dt.Rows[i]["MAIL_ID"].ToString());
        //        }
        //    }


        //    lst.Add(targetColumn, item);
        //}

    }
}
