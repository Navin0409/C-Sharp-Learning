using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Learning.LoopQuestions
{
    public class PasswordRetrySystem
    {
        public static void PasswordRetrysystem()
        {
            string correctPassword = "12345";
            string enterPassword;
            int attempts = 0;
            bool success = false;

            do
            {
                Console.WriteLine("Enter Your Password");
                enterPassword = Console.ReadLine();
                attempts++;
                if (enterPassword == correctPassword)
                {
                    Console.WriteLine("Access Granted");
                    success = true;
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect Password");
                    if (attempts < 3)
                    {
                        Console.WriteLine($"You have {3 - attempts} Attemps Left");
                    }
                }
            } while (attempts < 3);
            if (!success)
            {
                Console.WriteLine("Access denied. Too many failed attempts.");
            }
        }
    }
}
