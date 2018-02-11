using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _160901_buyukUnluUyumu
{
    class Program
    {
        static void Main(string[] args)
        {
            bool kalınMıdır = false;
            bool inceMidir = false;

            Console.WriteLine("Kelimeyi giriniz : ");
            string giris = Console.ReadLine();

            char[] kalınHarfler = { 'a', 'ı', 'o', 'u' };
            char[] inceHarfler = { 'e', 'i', 'ö', 'ü' };


            for (int i = 0; i < giris.Length; i++)
            {
                for (int j = 0; j < kalınHarfler.Length; j++)
                {
                    if (giris[i] == kalınHarfler[j])
                    {
                        kalınMıdır = true;
                    }
                    else if (giris[i] == inceHarfler[j])
                    {
                        inceMidir = true;
                    }

                }
            }
            if (kalınMıdır ==inceMidir)
            {
                Console.WriteLine("Büyük ünlü uyumu yoktur");
            }
            else
            {
                Console.WriteLine("Büyük ünlü uyumu vardır");
            }
           

            Console.ReadLine();
        }
    }
}
