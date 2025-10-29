using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
//Write a program to:

//Declare a const double for the maximum possible score (e.g., 100.0).

//Use var to store a student's score (from user input or fixed value).

//Use arithmetic operators to calculate the percentage score if given raw score and max score.

//Use if-else if ladder with logical and comparison operators to assign letter grades:

//90 % and above: 'A'

//80 % to 89.99 %: 'B'

//70 % to 79.99 %: 'C'

//60 % to 69.99 %: 'D'

//Below 60%: 'F'

//Use a switch statement to print a feedback message based on the letter grade.

namespace C_Learning.QuestionSolving
{
    public class StudGraCal
    {
        public static void StuGraCal()
        {
            const double maxScore = 100;
            Console.WriteLine("Enter Marks Obtained");
            var rawScore = Convert.ToDouble(Console.ReadLine());
            double percentage = (rawScore / maxScore) * 100;

            string grade;

            if (percentage > 90)
            {
                grade = "A";
            }
            else if (percentage > 80)
            {
                grade = "B";
            }
            else if (percentage > 70)
            {
                grade = "C";
            }
            else if (percentage > 60)
            {
                grade = "D";
            }
            else if (percentage > 50)
            {
                grade = "E";
            }
            else
            {
                grade = "F";
            }

            //switch (grade)
            //{
            //    case "A":
            //        Console.WriteLine("Excellent");
            //        break;
            //    case "B":
            //        Console.WriteLine("Good");
            //        break;
            //    case "C":
            //        Console.WriteLine("Fair performance. Keep practicing.");
            //        break;
            //    case "D":
            //        Console.WriteLine("You passed, but you should work harder.");
            //        break;
            //    case "F":
            //        Console.WriteLine("Failed. Don’t give up, study more!");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid grade.");
            //        break;
            //}
            string feedback = grade switch
            {
                "A" => "Excellent",
                "B" => "Good job! Aim for an A next time.",
                "C" => "Fair performance. Keep practicing.",
                "D" => "You passed, but you should work harder.",
                "E" => "You have Just passed",
                "F" => "Failed. Don’t give up, study more!",
                _ => "Invalid grade."
            };
            Console.WriteLine($"Grade: {grade}");
            Console.WriteLine(feedback);
            Console.ReadLine();    
        }
    }
}
