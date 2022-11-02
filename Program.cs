using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._10._22
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            int min = Int32.MaxValue;
            int max = -1;
            int cislo;
            int soucet = 0;


            x = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                Console.Write("Číslo: ");
                Console.WriteLine(i);
                cislo = Convert.ToInt32(Console.ReadLine());


                soucet += cislo;

                if (cislo > max)
                {
                    max = cislo;
                }
                if (cislo < min)
                {
                    min = cislo;
                }

            }

            Console.WriteLine("---------------------------");

            Console.WriteLine("Max:" + max);
            Console.WriteLine("Min:" + min);
            Console.WriteLine("Průměr:" + soucet / x);

            Console.ReadKey();
        }
    }
}
