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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        OleDbConnection mycon = new OleDbConnection();
        private void loginToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mycon.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=F:\Multi-Tier\prjWinCsRemax\prjWinCsRemax\database\prjRemax.mdb";
            mycon.Open();

            clsCommonData.login = loginMenu;
            clsCommonData.logout = logoutMenu;
            clsCommonData.operations = operationsMenu;
            clsCommonData.lbl = lbl_User;


            operationsMenu.Visible = false;
            logoutMenu.Visible = false;

            clsCommonData.myset = new DataSet();

            //Adding Table to the dataset

            OleDbCommand cmdEmployees = new OleDbCommand("SELECT * FROM Employees",mycon);
            clsCommonData.Employees = new OleDbDataAdapter(cmdEmployees);
            clsCommonData.Employees.Fill(clsCommonData.myset,"Employees");

            OleDbCommand cmdClients = new OleDbCommand("SELECT * FROM Clients", mycon);
            clsCommonData.Clients = new OleDbDataAdapter(cmdClients);
            clsCommonData.Clients.Fill(clsCommonData.myset, "Clients");

            OleDbCommand cmdHouses = new OleDbCommand("SELECT * FROM Houses", mycon);
            clsCommonData.Houses = new OleDbDataAdapter(cmdHouses);
            clsCommonData.Houses.Fill(clsCommonData.myset, "Houses");


        }

        private void loginMenu_Click(object sender, EventArgs e)
        {
            frmWelcome frmWelcome = new frmWelcome();
            frmWelcome.Show();
        }

        private void manageClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientData frmClientData = new frmClientData();
            frmClientData.Show();
        }

        private void exitApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void logoutMenu_Click(object sender, EventArgs e)
        {
            clsCommonData.login.Visible = true;
            clsCommonData.operations.Visible = false;
            clsCommonData.logout.Visible = false;
        }

        private void manageHousesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHouseData frmHouseData = new frmHouseData();
            frmHouseData.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSearch frmSearch = new frmSearch();
            frmSearch.Show();
        }

        private void manageAgentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAgentData frmAgentData = new frmAgentData();
            frmAgentData.Show();
        }
    }
}
