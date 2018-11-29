using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using System.Windows.Forms;

namespace RockPaperScissor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


       
        private void DisplayResult(int UserChoice)
        {


            int win = 0;
            int lose = 0;
            Random ranNumberGenrator = new Random();
            int ComputerChoice;
            ComputerChoice = ranNumberGenrator.Next(1, 4);
            if (ComputerChoice == 1)
            {
                if (UserChoice == 1)
                {
                    lblWinLose.Text = "Tie";
                }
                else if (UserChoice == 2)
                {
                    lblWinLose.Text = "You win";
                    lblPlayer.Text = "" + win++;
                }
                else
                {
                    lblWinLose.Text = "You lose";
                }


            }
            else if (ComputerChoice == 2)
            {
                if (UserChoice == 1)
                {
                    lblWinLose.Text = "You lose";
                    lblPlayer.Text = "" + win++;
                }
                else if (UserChoice == 2)
                {
                    lblWinLose.Text = "Tie";
                }
                else
                {
                    lblWinLose.Text = "You win";
                    lblPlayer.Text = "" + win++;
                }
            }
            else if (ComputerChoice == 3)
            {
                if (UserChoice == 1)
                {
                    lblWinLose.Text = "You lose";
                   
                }
                else if (UserChoice == 2)
                {
                    lblWinLose.Text = "You win";
                    lblPlayer.Text = "" + win++;
                }
                else
                    lblWinLose.Text = "Tie";
            }


            }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            int Scissor = 3;
            DisplayResult(Scissor);

        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            int Paper = 2;
            DisplayResult(Paper);
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            int Rock = 1;
            DisplayResult(Rock);


        }
    }
}
