//Create a program that takes two numbers as input (as strings), converts them to integers, adds them together, and displays the result.

namespace C_Learning.QuestionSolving
{
    public class TypeConv
    {
        public static void Typeconv()
        {
            Console.WriteLine("Enter Your first number");
            string num1 = Console.ReadLine();
            Console.WriteLine("Enter Your second number");
            string num2 = Console.ReadLine();
            int numInt1 = int.Parse(num1);
            int numInt2 = int.Parse(num2);

            int sum = numInt1 + numInt2;

            Console.WriteLine($"your Sum Is : {sum}");


        }
    }
}
