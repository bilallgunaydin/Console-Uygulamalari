using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _9_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Girilen şifreyi gizleyen program");
            Console.WriteLine();
            ConsoleKeyInfo gizli;
            Console.Write("Lütfen kullanıcı adınızı giriniz:");
            string kullanıcıAdı = Console.ReadLine();
            string sifre = "";
            Console.Write("Lütfen şifrenizi girin: ");
            bool durum = true;
            do
            {
                gizli = Console.ReadKey(durum);
                if (gizli.Key != ConsoleKey.Backspace)
                {
                    sifre = sifre + gizli.KeyChar;
                    Console.Write("*");
                }
            } while (gizli.Key != ConsoleKey.Enter);
            Console.WriteLine();
            Console.WriteLine("Şifre Testi:{0}", sifre);
            Console.Read();
        }
    }
}
