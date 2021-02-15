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
    public partial class frmAgentData : Form
    {
        public frmAgentData()
        {
            InitializeComponent();
        }

        DataTable Agents;
        private void frmAgentData_Load(object sender, EventArgs e)
        {
            Agents = clsCommonData.myset.Tables["Employees"];

            dataAgents.DataSource = Agents;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            clsCommonData.mode = "add";
            frmAgentOperation frmAgentOperation = new frmAgentOperation();
            frmAgentOperation.Show();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            DataTable Agent;
            Agent = clsCommonData.myset.Tables["Employees"];
            if (MessageBox.Show("Are you sure to delete this company ?", "Deletion Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Delete the current datarow
                Agent.Rows[Convert.ToInt32(dataAgents.SelectedRows[0].Cells[0].Value.ToString())].Delete();

                // update the database with the changes made in the dataset using the CommandBuilder object
                OleDbCommandBuilder mybuilder = new OleDbCommandBuilder(clsCommonData.Clients);
                clsCommonData.Employees.Update(clsCommonData.myset, "Employees");
                // empty and reload the content of the database in the dataset
                clsCommonData.myset.Tables.Remove("Employees");
                clsCommonData.Employees.Fill(clsCommonData.myset, "Employees");
            }
        }
    }
}
