using Newtonsoft.Json;
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
    public partial class customerPage : Form     // this class is for displaying customer form screen
    {
        public customerPage()
        {
            InitializeComponent();

        }
        
        private void clearfields()  //for making clearing all the fields
        {
            txtName.Text = null;
            txtContact.Text = null;
            txtEmail.Text = null;
            ratingBox.Controls.Clear();
            //readRating();

        }
        private void btnClear_Click_1(object sender, EventArgs e)
        {
            clearfields();
        }

        private void btnSave_Click_1(object sender, EventArgs e) // saves all the filled data in form of txt file
        {
            string name = txtName.Text;
            string contact = txtContact.Text;
            string email = txtEmail.Text;
            Dictionary<string, int> ratings = new Dictionary<string, int>();


            foreach (Control item in ratingBox.Controls)
            {
                UserControl item1 = (UserControl)item;
                var rB = item.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);
                if (rB != null)
                {
                    int rValue = int.Parse(rB.Text);
                    ratings.Add(item.Name, rValue);
                    
                }
                else
                {
                    MessageBox.Show("Please give ratings for all criteria.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                }
                
            }
            if (name != null && email != null && contact != null && ratings.Count != 0) // checking for empty fields
            {
                Review cReview = new Review();
                cReview.CustomerName = name;
                cReview.CustomerContact = contact;
                cReview.CustomerEmail = email;
                cReview.CustomerRating = ratings;
                cReview.datetime = DateTime.Now;
                Utility.writeReview(cReview);
                MessageBox.Show("Sucessfully added!");
                this.clearfields();
            }
            
            else
            {
                MessageBox.Show("Please fill up the forms correctly", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            initialPage iP = new initialPage();
            iP.Show();
            this.Close();
        }

        public void readRating ()  // this stores all the ratings 
        {
            List<string> criterias = Utility.ReadCriteria();

            for (int i = 0; i < criterias.Count; i++)
            {
                //Console.WriteLine(i);
                criteriaRating rating = new criteriaRating();
                rating.Name = criterias[i];
                //Console.WriteLine(rating.Name);
                rating.Dock = DockStyle.Top;
                //rating.Controls[0].Text = criterias[i];
                //Console.WriteLine(rating.Controls[0].Text);
                ratingBox.Controls.Add(rating);
                ratingBox.Controls[i].Visible = true;
                rating.setlabel(criterias[i]);
            }
        }

        private void ratingBox_Paint(object sender, PaintEventArgs e)
        {
            readRating();
        }
    }
}
