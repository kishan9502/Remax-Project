using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prjWinCsRemax
{
    class clsCommonData
    {
        public static DataSet myset;
        public static OleDbDataAdapter Employees;
        public static OleDbDataAdapter Clients;
        public static OleDbDataAdapter Houses;
        public static System.Windows.Forms.ToolStripMenuItem logout;
        public static System.Windows.Forms.ToolStripMenuItem login;
        public static System.Windows.Forms.ToolStripMenuItem operations;
        public static System.Windows.Forms.Label lbl;
        public static string client_ID;
        public static string House_ID;
        public static string mode;
    }
}
