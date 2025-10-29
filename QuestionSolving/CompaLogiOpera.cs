//Write a program that accepts three integer numbers from the user. Display which number is the greatest, and verify whether all numbers are different or some are equal.

namespace C_Learning.QuestionSolving
{
    public class CompaLogiOpera
    {
        public static void Compalogopera()
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int greatest = (num1 > num2 && num1 > num3) ? num1 : (num2 > num3) ? num2 : num3;
            Console.WriteLine($"Graetest number is {greatest}");

            if (num1 == num2 && num2 == num3)
            {
                Console.WriteLine("All number are same");
            }
            else if (num1 == num2 || num2 == num3 || num3 == num1) {
                Console.WriteLine("Some number are same");
            }
            else
            {
                Console.WriteLine("All number are different");
            }
        }
    }
}
