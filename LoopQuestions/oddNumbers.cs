//Display all odd numbers between 1 and 100.



namespace C_Learning.LoopQuestions
{
    public class oddNumbers
    {
        public static void OddNumber ()
        {

            int n;
            for (n = 1; n <= 100; n++) {
                if (n % 2 != 0) {
                    Console.Write($"Odd numbers: {n} ,");
                }
            }
        }
    }
}
