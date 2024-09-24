// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
using System;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Enter youAge:");

            // int Age = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine("Your Age: " + Age);
            
            // Declaration of variables to store four numbers
            double number1, number2, number3, number4;

            // Prompting the user to enter the first number
            Console.Write("Enter the First number: ");
            // Reading the first number entered by the user and converting it to a double
            number1 = Convert.ToDouble(Console.ReadLine());

            // Prompting the user to enter the second number
            Console.Write("Enter the Second number: ");
            // Reading the second number entered by the user and converting it to a double
            number2 = Convert.ToDouble(Console.ReadLine());

            // Prompting the user to enter the third number
            Console.Write("Enter the third number: ");
            // Reading the third number entered by the user and converting it to a double
            number3 = Convert.ToDouble(Console.ReadLine());

            // Prompting the user to enter the fourth number
            Console.Write("Enter the fourth number: ");
            // Reading the fourth number entered by the user and converting it to a double
            number4 = Convert.ToDouble(Console.ReadLine());

            // Calculating the average of the four numbers
            double result = (number1 + number2 + number3 + number4) / 4;

            // Displaying the average of the four numbers to the console
            Console.WriteLine("Total Average is: {4} ",
                number1, number2, number3, number4, result);
        }
    }
}