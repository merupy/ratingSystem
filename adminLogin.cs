using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ratingSystem
{
    public partial class adminLogin : Form
    {
        public adminLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            initialPage iP = new initialPage();
            iP.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e) // admin password checker (User = admin and Password = admin)
        {
            string user, password;
            user = txtUsername.Text;
            password = txtPassword.Text;
            if (user == "admin" && password == "admin")
            {
                adminPanel aP = new adminPanel();
                aP.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username or Password Incorrect! Please Try again", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkpassword_CheckedChanged(object sender, EventArgs e) // show password option
        {
            if (chkpassword.Checked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
