//Use a nested loop to create a pyramid of *

namespace C_Learning.LoopQuestions
{
    public class CreatePyramid
    {
        public static void Createpyramid()
        {
            int n = 5;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(' ');
                }
                for (int s = 0; s < 2 * i - 1; s++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
