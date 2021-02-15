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
    public partial class frmClientData : Form
    {
        public frmClientData()
        {
            InitializeComponent();
        }

        DataTable Clients;
        private void frmClientData_Load(object sender, EventArgs e)
        {
            Clients = clsCommonData.myset.Tables["Clients"];

            dataClients.DataSource = Clients;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            clsCommonData.mode = "add";
            frmClientsOperations frmClientsOperations = new frmClientsOperations();
            frmClientsOperations.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsCommonData.client_ID = dataClients.SelectedRows[0].Cells[0].Value.ToString();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            DataTable Client;
            Client = clsCommonData.myset.Tables["Clients"];
            if (MessageBox.Show("Are you sure to delete this company ?", "Deletion Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                // Delete the current datarow
                Client.Rows[Convert.ToInt32(dataClients.SelectedRows[0].Cells[0].Value.ToString())].Delete();

                // update the database with the changes made in the dataset using the CommandBuilder object
                OleDbCommandBuilder mybuilder = new OleDbCommandBuilder(clsCommonData.Clients);
                clsCommonData.Clients.Update(clsCommonData.myset, "Clients");
                // empty and reload the content of the database in the dataset
                clsCommonData.myset.Tables.Remove("Clients");
                clsCommonData.Clients.Fill(clsCommonData.myset, "Clients");


            }
        }
    }
}
