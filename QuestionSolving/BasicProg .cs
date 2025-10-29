using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a C# program that asks the user to enter their name and age using Console.ReadLine(). Then, print a greeting message using their name and display how old they will be after 5 years.
namespace C_Learning.QuestionSolving
{
    public class BasicProg
    {
        public static void Baiscprog()
        {
            Console.WriteLine("Enter you name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = Convert.ToInt32(Console.ReadLine());

            int ageAfter5 = age + 5;

            Console.WriteLine($"Hello {name} you will be {ageAfter5} after 5 years");

        }
    }
}
