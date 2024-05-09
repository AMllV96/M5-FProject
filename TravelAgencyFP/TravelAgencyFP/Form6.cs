using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelAgencyFP
{
    public partial class Form6 : Form
    {
        int hours;
        int minutes;
        double seconds;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void townLabel_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            seconds += 0.1;
            if (seconds > 60)
            {
                minutes++;
                seconds = 0;
            }

            if (minutes > 60)
            {
                hours++;
                minutes = 0;
            }

            if (pictureBox1.Left <= 1000)
            {
                pictureBox1.Left = pictureBox1.Left + 10;
            }

            else
            {
                pictureBox1.Left = -200;
            }

        }
    }
}
