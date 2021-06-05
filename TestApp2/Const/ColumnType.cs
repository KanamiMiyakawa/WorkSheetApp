using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Const
{
    /// <summary>
    /// DBの型
    /// </summary>
    public static class ColumnType
    {
        public static string Char = "Char";
        public static string Varchar = "Varchar";
        public static string Numeric = "Numeric";
        public static string TimeStamp = "TimeStamp";
        public static string NVarChar = "NVarChar"; //SQLServerのみ
    }
}
