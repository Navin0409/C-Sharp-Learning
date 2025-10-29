//Create a simple password checker. The user must enter a password. If it matches a predefined password stored in the code, print “Access Granted”; otherwise, print “Access Denied”.

namespace C_Learning.QuestionSolving
{
    public class passwordChecker
    {
        public static void passwordchecker()
        {
            const string password = "Navin@123";
            Console.WriteLine("Enter Your Password");
            string enterPassword = Console.ReadLine();
            if (enterPassword != password)
            {
                Console.WriteLine("Access Denied");
            }
            else
            {
                Console.WriteLine("Access Granted");
            }
            Console.ReadLine();
        }
    }
}
