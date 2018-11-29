using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hurricane
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int WindSpeed;
            const int Category5 = 157;
            const int Category4 = 130;
            const int Category3 = 111;
            const int Category2 = 96;
            const int Category1 = 75;

            WindSpeed = Convert.ToInt32(txtWindSpeed.Text);   

            if (WindSpeed < Category1)
            {
                lblWindCategory.Text = "Not a Hurricane";
            }
            else if (WindSpeed > Category1 && WindSpeed < Category2)
            {
                lblWindCategory.Text = "Category 1";
            }
            esle if (WindSpeed)
        }

      
    }
}
