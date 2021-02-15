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
    public partial class frmAgentOperation : Form
    {
        public frmAgentOperation()
        {
            InitializeComponent();
        }
        DataTable Agent;
        private void btn_Add_Click(object sender, EventArgs e)
        {

            DataRow myrow;
            if (clsCommonData.mode == "add")
            {
                // Create a new datarow (record) from the table Companies
                myrow = Agent.NewRow();
                // Fill the datarow with values from textboxes
                myrow["ID"] = Agent.Rows.Count + 1;
                myrow["FullName"] = txtName.Text;
                myrow["Address"] = txtAddress.Text;
                myrow["Phone"] = txtPhone.Text;
                myrow["Email"] = txtEmail.Text;
                myrow["Password"] = txtPassword.Text;
                myrow["Post"] = txtPost.Text;
                myrow["DOB"] = dateTimePicker1.Value.ToString();
                // Add the datarow in the collection Rows of the table
                Agent.Rows.Add(myrow);
                // update the database with the changes made in the dataset using the CommandBuilder object
                try
                {
                    OleDbCommandBuilder mybuilder = new OleDbCommandBuilder(clsCommonData.Employees);
                    clsCommonData.Employees.Update(clsCommonData.myset, "Employees");
                    // empty and reload the content of the database in the dataset
                    clsCommonData.myset.Tables.Remove("Employees");
                    clsCommonData.Employees.Fill(clsCommonData.myset, "Employees");

                    MessageBox.Show("Data has been added!! ", "Insertion!!", MessageBoxButtons.OKCancel);
                }
                catch(Exception ex)
                {

                }
            }

            else // mode == "edit"
            {
                // Edit the current datarow
                myrow = Agent.NewRow();
                // Fill the datarow with values from textboxes
                myrow["ID"] = Agent.Rows.Count + 1;
                myrow["FullName"] = txtName.Text;
                myrow["Address"] = txtAddress.Text;
                myrow["Phone"] = txtPhone.Text;
                myrow["Email"] = txtEmail.Text;
                myrow["Password"] = txtPassword.Text;
                myrow["Post"] = txtPost.Text;
                myrow["DOB"] = dateTimePicker1.Value.ToString();
                // Add the datarow in the collection Rows of the table
                
                // update the database with the changes made in the dataset using the CommandBuilder object
                OleDbCommandBuilder mybuilder = new OleDbCommandBuilder(clsCommonData.Employees);
                clsCommonData.Employees.Update(clsCommonData.myset, "Employees");
                // empty and reload the content of the database in the dataset
                clsCommonData.myset.Tables.Remove("Employees");
                clsCommonData.Employees.Fill(clsCommonData.myset, "Employees");

                MessageBox.Show("Data has been added!! ", "Insertion!!", MessageBoxButtons.OKCancel);

            }
        }

        private void frmAgentOperation_Load(object sender, EventArgs e)
        {
            Agent = clsCommonData.myset.Tables["Employees"];
        }
    }
}
