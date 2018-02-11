using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Console.Methods00
{
    class Program
    {
        static void Main(string[] args)
        {
            Say("Selam");
            //Function call

            HoldScreen();
            Say("Görüşürüz");
            HoldScreen();
            SayHello();
            HoldScreen();
        }

        static void SayHello()
        {
            Say("Selam");

        }
        static void SayGoodbye()
        {
            Say("Gçrüşürüz");
        }
        static void Say(string word)
        {

            Console.WriteLine(word);
        }
        static string GetHello()
        {
            return "Selam";
        }
        //Function implementation
        static void HoldScreen()
        {
            Console.ReadLine();


        }
    }
}
