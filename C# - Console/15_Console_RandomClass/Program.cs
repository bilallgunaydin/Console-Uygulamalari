using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Console_RandomClass
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int number = rnd.Next(100, 200);

            Console.Write(number);

            Console.ReadLine();
        }
    }
}
