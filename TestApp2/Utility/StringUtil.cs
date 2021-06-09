using System;
using System.Text;
using System.Windows.Forms;

namespace Utility
{
    /// <summary>
    /// 文字列操作ユーティリティ
    /// </summary>
    public static class StringUtil
    {
        /// <summary>
        /// SHIFT-JIS換算でバイト長を取得する
        /// </summary>
        /// <param name="text">文字</param>
        /// <returns></returns>
        public static int GetByteLength(string text)
        {
            return Encoding.GetEncoding("Shift_JIS").GetByteCount(text);
        }

        /// <summary>
        /// VARCHARに格納可能な文字を取得する
        /// </summary>
        /// <param name="dbMain"></param>
        /// <param name="text"></param>
        /// <param name="limitLength"></param>
        /// <returns></returns>
        public static string GetVarcharLimitString(SQLMain dbMain, string text, int limitLength)
        {
            text = text.TrimEnd();
            if (GetByteLength(text) <= limitLength)
            {
                return text;
            }
            else
            {
                string ret = "";
                for (int i = 0; i < text.Length; i++)
                {
                    if (GetByteLength(ret + text.Substring(i, 1)) <= limitLength)
                    {
                        ret += text.Substring(i, 1);
                    }
                    else
                    {
                        break;
                    }
                }
                return ret;
            }
        }
        
        

        /// <summary>
        /// デコード
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string EncPassword(string val)
        {
            string ret = "";
            try
            {
                Encoding enc = Encoding.GetEncoding("Shift_JIS");
                ret = Convert.ToBase64String(enc.GetBytes(val));
            }
            catch (Exception)
            {
                System.ArgumentException argEx = new System.ArgumentException("パスワードの複合化に失敗しました。");
                throw argEx;
            }
            return ret;
        }

        /// <summary>
        /// エンコード
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public static string DecPassword(string val)
        {
            string ret = "";
            try
            {
                Encoding enc = Encoding.GetEncoding("Shift_JIS");
                ret = enc.GetString(Convert.FromBase64String(val));
            }
            catch (Exception)
            {
                System.ArgumentException argEx = new System.ArgumentException("パスワードの暗号化に失敗しました。");
                throw argEx;
            }
            return ret;
        }

        public static string DateToString(DateTimePicker dtPicker)
        {
            return dtPicker.Value.Year.ToString() + "-" + dtPicker.Value.Month + "-" + dtPicker.Value.Day;
        }
    }
}
