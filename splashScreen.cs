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
    public partial class splashScreen : Form
    {
        public splashScreen()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.Width += 3;
            if(panel1.Width >= 805)
            {
                timer1.Stop();
                initialPage iP = new initialPage();
                iP.Show();
                this.Hide();
            }
        }
    }
}
