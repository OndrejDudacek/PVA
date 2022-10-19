using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ulong num = ulong.Parse(Console.ReadLine());
            bool prime = true;

            if (num % 2 == 0)
            {
                prime = false;
            }
            else
            {
                for (ulong i = 2; i < num; i++)
                {
            
                    if (num % i == 0)
                    {
                    prime = false;
                    }
                }
            }

            if (prime)
            {

            }

            
            Console.ReadKey();
        }
    }
}
