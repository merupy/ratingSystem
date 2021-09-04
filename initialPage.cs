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
    public partial class initialPage : Form
    {
        public initialPage()
        {
            InitializeComponent();
        }

        private void btnAdmin_Click(object sender, EventArgs e) // Admin login option where button redirect to admin login page
        {
            adminLogin aL = new adminLogin();
            aL.Show();
            this.Hide();


        }

        private void btnCustomer_Click(object sender, EventArgs e) // Customer rating option where button redirect to customer feedack page.
        {
            customerPage cP = new customerPage();
            cP.Show();
            this.Hide();
        }

        
    }
}
