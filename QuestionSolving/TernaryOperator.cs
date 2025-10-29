//Write a C# program that reads an integer and uses the ternary operator to display whether the number is even or odd.

namespace C_Learning.QuestionSolving
{
    public class TernaryOperator
    {
        public static void ternaryOperator()
        {
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());
            var evenOrOdd = (num % 2 == 0) ? "even" : "Odd";
            Console.WriteLine($"Your number is {evenOrOdd}");
        }
    }
}
