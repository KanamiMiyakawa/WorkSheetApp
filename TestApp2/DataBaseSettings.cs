using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace WorkSheetApp
{
    public partial class DataBaseSettings : Form
    {
        public DataBaseSettings()
        {
            InitializeComponent();

            var DBSettings = ConfigurationManager.AppSettings;
            lbl_oldServerName.Text = DBSettings["dbServer"] ?? "Not Found";
            lbl_oldUserName.Text = DBSettings["dbUser"] ?? "Not Found";
            lbl_oldDBName.Text = DBSettings["dbName"] ?? "Not Found";
        }
    }
}
