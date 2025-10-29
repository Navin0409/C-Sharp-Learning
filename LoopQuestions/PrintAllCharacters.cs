//Use a foreach loop to print all characters in a user’s name.

namespace C_Learning.LoopQuestions
{
    public class PrintAllCharacters
    {
        public static void PrintallCharacter()
        {
            string userName = "Navin0403";

            foreach(char name in userName)
            {
                Console.WriteLine(name);
            }

        }
    }
}
