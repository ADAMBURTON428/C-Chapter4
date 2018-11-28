using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Admission
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            double GPA;
            int Test;

            GPA = Convert.ToDouble(txtGPA.Text);
            Test = Convert.ToInt32(txtTestScore.Text);

            if (GPA >= 3.0 && Test >= 60)
            {
                lblOutput.Text = "Accept";

            }
            else if (GPA <= 3.0 && Test >= 80)
            {
                lblOutput.Text = "Accept";
            }
            else
                lblOutput.Text = "Reject";
        }
    }
}
