using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckCredit
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            double price;
            const int MAX = 5000;

            price = Convert.ToDouble(txtPrice.Text);

            

            if (price > MAX )
            {
                lblApproved.Text = "Error";

            }
            else
            {
                lblApproved.Text = "Approved";
            }




        }
    }
}
