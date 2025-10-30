using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning.LoopQuestions
{
    public class FibonacciSeries
    {
        public static void Fibonacciseries()
        {
            Console.WriteLine("Enter the limit: ");
            int limit = int.Parse(Console.ReadLine());
            int first = 0, second = 1;
            int next = first + second;

            while (next <= limit)
            {
                Console.WriteLine($" {next}");
                first = second;
                second = next;
                next = first + second;
            }
        }
    }
}
