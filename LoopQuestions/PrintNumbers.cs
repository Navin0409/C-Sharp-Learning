using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning.LoopQuestions
{
    public class PrintNumbers
    {
        public static void Printnumber()
        {
            for(int i = 1; i <= 20; i++)
            {
                if (i == 13)
                {
                    continue;
                } else if (i == 17){
                    break;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
