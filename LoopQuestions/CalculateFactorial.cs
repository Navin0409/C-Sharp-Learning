//Calculate the factorial of a given number.

namespace C_Learning.LoopQuestions
{
    public class CalculateFactorial
    {
        public static void Calculatefactorial()
        {
            int num = int.Parse(Console.ReadLine());
            int fact = 1;
            for (int i=1; i <= num; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
        }
    }
}
