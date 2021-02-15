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
    public partial class frmClientsOperations : Form
    {
        public frmClientsOperations()
        {
            InitializeComponent();
        }

        DataTable Clients;
        private void btn_Add_Click(object sender, EventArgs e)
        {
            

            DataRow myrow;
            if (clsCommonData.mode == "add")
            {
                // Create a new datarow (record) from the table Companies
                myrow = Clients.NewRow();
                // Fill the datarow with values from textboxes
                myrow["cID"] = Clients.Rows.Count+1;
                myrow["cFullName"] = txtName.Text;
                myrow["cAddress"] = txtAddress.Text;
                myrow["cPhone"] = txtPhone.Text;
                myrow["cEmail"] = txtEmail.Text;
                myrow["cDOB"] = dateTimePicker1.Value.ToString();   
                // Add the datarow in the collection Rows of the table
                Clients.Rows.Add(myrow);
                                // update the database with the changes made in the dataset using the CommandBuilder object
                OleDbCommandBuilder mybuilder = new OleDbCommandBuilder(clsCommonData.Clients);
                clsCommonData.Clients.Update(clsCommonData.myset, "Clients");
                // empty and reload the content of the database in the dataset
                clsCommonData.myset.Tables.Remove("Clients");
                clsCommonData.Clients.Fill(clsCommonData.myset, "Clients");

                MessageBox.Show("Data has been added!! ", "Insertion!!", MessageBoxButtons.OKCancel);

            }

            else // mode == "edit"
            {
                // Edit the current datarow
                myrow = Clients.Rows[Convert.ToInt32(clsCommonData.client_ID)];
                // Fill the datarow with values from textboxes
                myrow["cFullName"] = txtName.Text;
                myrow["cAddress"] = txtAddress.Text;
                myrow["cPhone"] = txtPhone.Text;
                myrow["cDOB"] = dateTimePicker1.Value.ToString();
                myrow["cEmail"] = txtEmail.Text;
                myrow["Desired_Type"] = cb_DesiredFor.SelectedItem.ToString();


                // update the database with the changes made in the dataset using the CommandBuilder object
                OleDbCommandBuilder mybuilder = new OleDbCommandBuilder(clsCommonData.Clients);
                clsCommonData.Clients.Update(clsCommonData.myset, "Clients");
                // empty and reload the content of the database in the dataset
                clsCommonData.myset.Tables.Remove("Clients");
                clsCommonData.Clients.Fill(clsCommonData.myset, "Clients");

            }

        }

        private void frmClientsOperations_Load(object sender, EventArgs e)
        {
            Clients = clsCommonData.myset.Tables["Clients"];
            foreach (DataRow row in Clients.Rows)
            {
                cb_DesiredFor.Items.Add(row["Desired_Type"].ToString());
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void cb_DesiredFor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

        }
    }
}
