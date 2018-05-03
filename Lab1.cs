/*
 * Written by: Nicholas Cockcroft
 * Date: January 25, 2018
 * Class .NET Environment
 * Assignment: Lab 1
 * 
 * Description: Calculate the average of numbers entered by the user.
 */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1
{
    class Lab1
    {
        static void Main(string[] args)
        {
            // Local variables.
            string number;
            double actualNum;
            double sum = 0;
            int count = 0;

            // Prompts the user for how many numbers they want to average.
            Console.Write("How many numbers would you like to type in? ");
            number = Console.ReadLine();
            count = int.Parse(number);

            for(int i = 0; i < count; i++)
            {
                // Read in a number from the user.
                Console.Write("Enter number: ");
                number = Console.ReadLine();

                // Error checking to make sure the number isn't negative or zero
                if(double.Parse(number) < 0)
                {
                    MessageBox.Show("Error: Negative number! Will be disreguarded.");
                    i--;
                    continue;
                }

                // Convert the number to a double and add it to the sum.
                actualNum = double.Parse(number);
                sum += actualNum;
            }

            sum = sum / count;

            // Rounds the average to 2 decimal places to the right.
            sum = Math.Round(sum, 2);

            // Outputting the average to the console.
            Console.Write("The average is: {0}\n", sum);
        }
    }
}
