using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjWinCsRemax
{
    public partial class frmHouseOperation : Form
    {
        public frmHouseOperation()
        {
            InitializeComponent();
        }
        DataTable House;
        DataTable Clients;
        DataTable Employees;

        private void frmHouseOperation_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 5; i++)
            {
                cb_Type.Items.Add(i);
                cb_Room.Items.Add(i);
                

            }
            House = clsCommonData.myset.Tables["Houses"];
            Clients = clsCommonData.myset.Tables["Clients"];
            Employees = clsCommonData.myset.Tables["Employees"];

            foreach(DataRow r1 in Employees.Rows)
            {
                cb_Agent.Items.Add(r1["FullName"].ToString());
            }

            foreach (DataRow r2 in Clients.Rows)
            {
                cb_Clients.Items.Add(r2["cFullName"].ToString());
            }
            cb_Status.Items.Insert(0, "For Sale");
            cb_Status.Items.Insert(1, "Lease Only");
            cb_Status.Items.Insert(2, "Sold");
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            DataRow myrow;
            if (clsCommonData.mode == "add")
            {
                
                // Create a new datarow (record) from the table Companies
                myrow = House.NewRow();
                // Fill the datarow with values from textboxes
                myrow["hID"] = Convert.ToString(House.Rows.Count + 1);
                myrow["hType"] = cb_Type.SelectedItem.ToString();
                myrow["hRooms"] = cb_Room.SelectedItem.ToString();
                myrow["hStatus"] = cb_Status.SelectedItem.ToString();
                myrow["hClient"] = cb_Clients.SelectedItem.ToString();
                myrow["hAgent"] = cb_Agent.SelectedItem.ToString();
                myrow["hPrice"] = txt_Price.Text;
                // Add the datarow in the collection Rows of the table
                House.Rows.Add(myrow);
                // update the database with the changes made in the dataset using the CommandBuilder object
                OleDbCommandBuilder mybuilder = new OleDbCommandBuilder(clsCommonData.Houses);
                clsCommonData.Houses.Update(clsCommonData.myset, "Houses");
                // empty and reload the content of the database in the dataset
                clsCommonData.myset.Tables.Remove("Houses");
                clsCommonData.Clients.Fill(clsCommonData.myset, "Houses");

                MessageBox.Show("Data has been added!! ", "Insertion!!", MessageBoxButtons.OKCancel);

            }

            //else // mode == "edit"
            //{
            //    Edit the current datarow
            //    myrow = House.Rows[Convert.ToInt32(clsCommonData.House_ID)];
            //    Fill the datarow with values from
            //    myrow["hID"] = Convert.ToString(House.Rows.Count + 1);
            //    myrow["hType"] = cb_Type.SelectedItem.ToString();
            //    myrow["hRooms"] = cb_Room.SelectedItem.ToString();
            //    myrow["hStatus"] = cb_Status.SelectedItem.ToString();
            //    myrow["hClient"] = cb_Clients.SelectedItem.ToString();
            //    myrow["hAgent"] = cb_Agent.SelectedItem.ToString();
            //    myrow["hPrice"] = txt_Price.Text;
            //    Add the datarow in the collection Rows of the table
            //    House.Rows.Add(myrow);
            //    update the database with the changes made in the dataset using the CommandBuilder object
            //   OleDbCommandBuilder mybuilder = new OleDbCommandBuilder(clsCommonData.Houses);
            //    clsCommonData.Houses.Update(clsCommonData.myset, "Houses");
            //    empty and reload the content of the database in the dataset
            //    clsCommonData.myset.Tables.Remove("Houses");
            //    clsCommonData.Clients.Fill(clsCommonData.myset, "Houses");

            //}
        }
    }
}
