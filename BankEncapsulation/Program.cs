using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)

        {
            BankAccount account = new BankAccount() {};
        

            Console.WriteLine("How much would you like to deposit?");

            double userInput1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Would you like to see your balance? press 1 for yes, 2 for no");

            int userInput2 = Convert.ToInt32(Console.ReadLine());

            if (userInput2 == 1)
            {   
                account.Deposit(userInput1);

                Console.WriteLine(account.GetBalance());
            }
            else
            {
                Console.WriteLine("Have a great day!");
            }

            
        }
    }
}
