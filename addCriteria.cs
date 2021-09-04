using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ratingSystem
{
    public partial class addCriteria : Form
    {
        public string path = "criteria.txt";
        public addCriteria()
        {
            InitializeComponent();
        }

        

        private void btnSave_Click(object sender, EventArgs e) // makes a txt file while clicking save
        {
            String criteria = txtCriteria.Text;
            if (criteria != null && criteria != "")
            {
                Utility.writeCriteria(criteria);
                txtCriteria.Text = null;
                MessageBox.Show("Criteria Added Successfully!", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Field is empty! Please try again", "Invalid Criteria", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void btnBack_Click(object sender, EventArgs e)
        {
            adminPanel aP = new adminPanel();
            aP.Show();
            this.Close();
        }
    }
}
