using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace Age_Insult_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            string ageString;
            int yes;
            string yesString;

            Write("Welcome to the famous Age Insult Generator!!!\n");
            Write("Please enter your supposed age ");
            ageString = ReadLine();
            age = Convert.ToInt32(ageString);
            

            

            if (age > 0 && age <= 12)
            {
                 Write("You are a minor\n");
            }
            else if (age <= 0)
            {
                 Write("How did you get here\n");
            }
            else if (age > 13 && age <= 18)
            {

                 Write("You are a thing, good job\n");
            }
            else if (age > 18 && age <= 25)
            {

                Write("Get a life.\n");
   
            }
            else if (age > 26 && age <= 30)
            {
                Write("You got a Job 1 for yes 2 for no");
                yesString = ReadLine();
                yes = Convert.ToInt32(yesString);
                if (yes == 1)
                    Write("Good\n7");
                else
                    Write("Get one\n");
               
            }
            else if (age > 31 && age <= 40)
            {
                Write("Why are you here?\n");
            }
            else if (age > 41 && age <= 50)
            {
                Write("You are old, nice\n");
            }

            else if (age > 51 && age <= 75)
            {
                Write("Time flies by right\n");
            }
            else if (age > 75)
            {
                Write("Your still here thats good for you\n");
            }
          
        }
    }
}
