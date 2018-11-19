using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace If_Else_Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            string numString;

            Write("Pick a number 1, 2, or 3\n");
            numString = ReadLine();
            num = Convert.ToInt32(numString);


            if (num == 1 || num == 3)
            {
                Write("You lose\n");
            }
            else if (num == 2)
            {
                Write("You win\n");
            }
            else
                Write("Error\n");


        }
    }
}
