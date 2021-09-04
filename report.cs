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
    public partial class report : Form
    {
        public report()
        {
            InitializeComponent();
        }

        private void report_Load(object sender, EventArgs e) // to show data in form of charrt and table, function from utility.cs is called.
        {
            Utility review = new Utility();
            List<Review> creviewList = review.feedback();
            //lblTotalReviews.Text = creviewList.Count.ToString();
            DataTable dt = Utility.ConvertToDataTable(review.feedback());
            feedbackGrid.DataSource = dt;

            Dictionary<string, int> Data = Utility.Chart(creviewList);

            foreach (KeyValuePair<string, int> entry in Data)
            {
                feedbackChart.Series["Criteria Rate"].Points.AddXY(entry.Key, entry.Value);
            }
        }

        private void btnSort_Click(object sender, EventArgs e) // sorting is done here where code is called from utility.cs
        {
            Utility review = new Utility();
            List<Review> reviewList = review.feedback();
            DataTable dt = Utility.ConvertToDataTable(Utility.SortByDate(review.feedback()));
            feedbackGrid.DataSource = dt;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            adminPanel aP = new adminPanel();
            aP.Show();
            this.Close();
        }

    }

}
