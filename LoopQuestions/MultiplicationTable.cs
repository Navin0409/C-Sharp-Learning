//Print a multiplication table for any given number.

namespace C_Learning.LoopQuestions
{
    public class MultiplicationTable
    {
        public static void Multiplicationtable()
        {
            Console.WriteLine("Enter number to generate its table");
            int num = int.Parse(Console.ReadLine());
            int ans;
            for (int i = 1; i <= 10; i++)
            {
                ans = num * i;
                Console.WriteLine($"{num} X {i} = {ans}");
            }
        }
    }
}
