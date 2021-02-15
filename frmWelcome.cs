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
    public partial class frmWelcome : Form
    {
        public frmWelcome()
        {
            InitializeComponent();
        }

        DataTable emp;
        private void btnLogin_Click(object sender, EventArgs e)
        {
             
            if(emp.Rows[0]["Email"].ToString() == txtEmail.Text && emp.Rows[0]["Password"].ToString() == txtPassword.Text)
            {
                MessageBox.Show("Welcome "+ emp.Rows[0]["FullName"].ToString(), "Login");
                clsCommonData.login.Visible = false;
                clsCommonData.logout.Visible = true;
                clsCommonData.operations.Visible = true;
                 clsCommonData.lbl.Text = "Welcome"+emp.Rows[0]["FullName"].ToString()+"\n"+ emp.Rows[0]["Post"].ToString();
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid Credentials", "Login");
            }
        }

        private void frmWelcome_Load(object sender, EventArgs e)
        {
            emp = clsCommonData.myset.Tables["Employees"];
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
