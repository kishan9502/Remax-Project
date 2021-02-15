using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsRemax
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }
        DataTable House;
        DataTable Empy;
        private void frmSearch_Load(object sender, EventArgs e)
        {

        }

        private void rb_HouseType_CheckedChanged(object sender, EventArgs e)
        {
            cb_SearchInfo.Items.Clear();
            House = clsCommonData.myset.Tables["Houses"];
            dataSearch.DataSource = House;
            
            foreach(DataRow mr in House.Rows)
            {
                cb_SearchInfo.Items.Add(mr["hType"]);
            }
        }

        private void rb_Agent_CheckedChanged(object sender, EventArgs e)
        {
            cb_SearchInfo.Items.Clear();
            Empy = clsCommonData.myset.Tables["Employees"];
            dataSearch.DataSource = Empy;
            foreach (DataRow mr in Empy.Rows)
            {
                cb_SearchInfo.Items.Add(mr["FullName"]);
            }
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            String criteria = "";
            if (rb_Agent.Checked == true)
            {
                criteria = "FullName = '" + cb_SearchInfo.SelectedItem.ToString() + "'";
                dataSearch.DataSource = Empy.Select(criteria).CopyToDataTable();
            }
            if (rb_HouseType.Checked == true)
            {
                criteria = "hType = '" + cb_SearchInfo.SelectedItem.ToString() + "'";
                dataSearch.DataSource = House.Select(criteria).CopyToDataTable();
            }
        }
    }
}
