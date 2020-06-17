using System;
using System.Linq;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace ComparingNumbers
{
    class Program
    {      
        static void Main(string[] args)
        {
            Console.WriteLine("Project: Comparing Numbers!");
            Console.WriteLine("Hello! Today you're going to give me a list of numbers and I will tell you which is the largest!");
            Console.WriteLine();

            string input;
            int numToAdd;
            List<int> numList = new List<int>();

            Console.WriteLine("Please enter your first number:");
            do
            {
                input = Console.ReadLine();
                if (Int32.TryParse(input, out numToAdd))
                {
                    if (numList.Contains(numToAdd))
                    {
                        Console.WriteLine("You've already added this number, please enter another number:");
                        numList.Add(Int32.Parse(Console.ReadLine()));
                        Console.WriteLine("Added! Please input your next value or press enter if you are done.");

                    }
                    else 
                    {
                        numList.Add(numToAdd);
                        Console.WriteLine("Added! Please input your next value or press enter if you are done.");
                    }
                }

                else
                {
                    if (!String.IsNullOrWhiteSpace(input))
                    {
                        Console.WriteLine("Invalid input, Please enter an integer:");
                    }
                }

            } while (!String.IsNullOrWhiteSpace(input));

            Console.WriteLine("You entered " + numList.Count + " number(s). Here are the numbers you entered: ");
            Console.WriteLine(string.Format("{0}", string.Join(", ", numList)));

            int maxNum = numList[0];
            for (int i = 0; i < numList.Count; i++) 
            {
                maxNum = Math.Max(maxNum, numList[i]); 
            }
            Console.WriteLine();
            Console.WriteLine("The largest number in your list is " + maxNum);

        }
    }
}
