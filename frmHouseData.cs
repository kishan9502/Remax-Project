using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsRemax
{
    public partial class frmHouseData : Form
    {
        public frmHouseData()
        {
            InitializeComponent();
        }

        private void dataHouses_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        DataTable Houses;
        private void frmHouseData_Load(object sender, EventArgs e)
        {
            Houses = clsCommonData.myset.Tables["Houses"];
            dataHouses.DataSource = Houses;

        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            clsCommonData.mode = "add";
            frmHouseOperation frmHouseOperation = new frmHouseOperation();
            frmHouseOperation.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            DataTable House;
            House = clsCommonData.myset.Tables["Houses"];
            if (MessageBox.Show("Are you sure to delete this company ?", "Deletion Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Delete the current datarow
                House.Rows[Convert.ToInt32(dataHouses.SelectedRows[0].Cells[0].Value.ToString())].Delete();

                // update the database with the changes made in the dataset using the CommandBuilder object
                OleDbCommandBuilder mybuilder = new OleDbCommandBuilder(clsCommonData.Houses);
                clsCommonData.Houses.Update(clsCommonData.myset, "Houses");
                // empty and reload the content of the database in the dataset
                clsCommonData.myset.Tables.Remove("Houses");
                clsCommonData.Houses.Fill(clsCommonData.myset, "Houses");


            }
        }
    }
}
