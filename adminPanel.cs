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
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }

        private void btnaddCriteria_Click(object sender, EventArgs e)
        {
            addCriteria aC = new addCriteria();
            aC.Show();
            this.Close();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            report R = new report();
            R.Show();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            initialPage iP = new initialPage();
            iP.Show();
            this.Close();
        }

        private void btnimportData_Click(object sender, EventArgs e) // for file upload option 
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                List<Review> data = new List<Review>();
                try
                {
                    StreamReader streamReader = new StreamReader(openFile.FileName);
                    string line = streamReader.ReadLine();
                    while (line != null)
                    {
                        Review review = (Review)JsonConvert.DeserializeObject<Review>(line);
                        data.Add(review);
                        line = streamReader.ReadLine();
                    }
                    streamReader.Close();

                    StreamWriter streamWriter = new StreamWriter("review.txt", true);

                    foreach (Review review in data)
                    {
                        string review_json = JsonConvert.SerializeObject(review, Formatting.None);
                        streamWriter.WriteLine(review_json);
                    }
                    streamWriter.Close();
                    MessageBox.Show("Data Imported Successfully!", "Success", MessageBoxButtons.OK);
                }
                catch (Exception)
                {
                    MessageBox.Show("Failed to import data. Please check the File and Try Agian.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
