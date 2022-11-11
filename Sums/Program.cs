using System;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Channels;

namespace Sums
{
    class Program
    {
        static void Main(string[] args)
        {
            ERROR1:
            int userInput;
            int firstNumber;
            Console.WriteLine("Type a first number nuber if u want to exit a program type '0'");
            try
            {
                 userInput = int.Parse(Console.ReadLine());
                 firstNumber = userInput;     
            }catch(Exception)
            {
                Console.WriteLine("U typed a letter");
                goto ERROR1;
            }
            int sum = 0;
            int maxValue = 0;


            if (userInput == 0)
            {
                Environment.Exit(0);
            }
            sum += userInput;

            
            while (userInput != 0)
            {

                ERROR2:
                Console.WriteLine("Type a nuber if u want to exit a program type '0'");
                try
                {
                    userInput = int.Parse(Console.ReadLine());
                }catch (Exception)
                {
                    Console.WriteLine("You typed a letter");
                    goto ERROR2;
                }
               sum += userInput;
               if (userInput > maxValue)
               {
                    maxValue = userInput;
               }else if(firstNumber > maxValue)
                {
                    maxValue = firstNumber;
                }
               
                
                
                
            }
            Console.WriteLine($"Sum of your numbers is: {sum}, and bigest value that u typed is {maxValue}");



        }
    }
}
