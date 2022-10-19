using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVA_19._10._2022
{
    class Program
    {
        static void Main(string[] args)
        {

            /*string value = Console.ReadLine();
            string binary = Convert.ToInt32(value, 2).ToString();
            Console.WriteLine(binary);

            Console.ReadKey();
            */


            int input;
            input = Convert.ToInt32(Console.ReadLine());
            string bin = "";

            do
            {
                int vys = input % 2;
                bin = vys + bin;

                input -= vys;
                input = input / 2;

            } while (input >= 1);

            string rev = "";
            for (int i = bin.Length - 1; i >= 0; i--)
            {
                rev += bin[i];
            }
            Console.WriteLine(bin);
            Console.ReadKey();
        }
    }
}
