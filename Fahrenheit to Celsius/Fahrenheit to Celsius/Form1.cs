using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fahrenheit_to_Celsius
{
    public partial class Form1 : Form
    {
        private object am;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnFahrenheit_Click(object sender, EventArgs e)
        {
            double Input1;
            double Input2;
            double Input3;
            double Output1;
            double Output2;
            double Output3;

            Input1 = Convert.ToDouble(txtInput8.Text);
            Input2 = Convert.ToDouble(txtInput12.Text);
            Input3 = Convert.ToDouble(txtInput5.Text);

            Output1 = Input1 * 1.8 + 32;
            Output2 = Input2 * 1.8 + 32;
            Output3 = Input3 * 1.8 + 32;

            lblOutput8.Text = "" + Output1;
            lblOutput12.Text = "" + Output2;
            lblOutput5.Text = "" + Output3;

            if (Output1 > 100)
            {
                lblHotCold1.Visible = true;
                lblHotCold1.Text = "Thats Hot";

            }
            else if (Output1 < 32)
            {
                lblHotCold1.Visible = true;
                lblHotCold1.Text = "Thats Cold";
            }
            if (Output2 > 100)
            {
                lblHotCold2.Visible = true;
                lblHotCold2.Text = "Thats Hot";
            }
            else if (Output2 < 32)
            {
                lblHotCold2.Visible = true;
                lblHotCold2.Text = "Thats Cold";
            }
            if (Output3 > 100)
            {
                lblHotCold3.Visible = true;
                lblHotCold3.Text = "Thats Hot";

            }
            else if (Output3 < 32)
            {
                lblHotCold3.Visible = true;
                lblHotCold3.Text = "Thats Cold";
      
            }
        }
        private void btnCelsius_Click(object sender, EventArgs e)
        {
            double Input1;
            double Input2;
            double Input3;
            double Output1;
            double Output2;
            double Output3;

            Input1 = Convert.ToDouble(txtInput8.Text);
            Input2 = Convert.ToDouble(txtInput12.Text);
            Input3 = Convert.ToDouble(txtInput5.Text);

            Output1 = (Input1 - 32) * 1.8 ;
            Output2 = (Input2 - 32) * 1.8 ;
            Output3 = (Input3 - 32) * 1.8 ;

            lblOutput8.Text = "" + Output1;
            lblOutput12.Text = "" + Output2;
            lblOutput5.Text = "" + Output3;

            if (Output1 > 100)
            {
                lblHotCold1.Visible = true;
                lblHotCold1.Text = "Thats Hot";

            }
            else if (Output1 < 32)
            {
                lblHotCold1.Visible = true;
                lblHotCold1.Text = "Thats Cold";
            }
            if (Output2 > 100)
            {
                lblHotCold2.Visible = true;
                lblHotCold2.Text = "Thats Hot";
            }
            else if (Output2 < 32)
            {
                lblHotCold2.Visible = true;
                lblHotCold2.Text = "Thats Cold";
            }
            if (Output3 > 100)
            {
                lblHotCold3.Visible = true;
                lblHotCold3.Text = "Thats Hot";

            }
            else if (Output3 < 32)
            {
                lblHotCold3.Visible = true;
                lblHotCold3.Text = "Thats Cold";

            }
        }
    }
}
