using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Girilen sayının palindrome olup olmadığını bulan program");
            Console.WriteLine();
            bool durum = true;
            bool cıkıs = true;
            while (cıkıs)
            {
                int sayı, kalan, toplam = 0, ters;
                Console.Write("Bir sayı giriniz:");
                string input = Console.ReadLine();
                if (input == "exit")
                {
                    break;
                }
                else
                {
                    durum = int.TryParse(input, out sayı);
                    ters = sayı;
                    if (durum == false)
                    {
                        Console.WriteLine("Lütfen doğru formatta bir sayı yazınız!");
                    }
                    else
                    {
                        while (Convert.ToBoolean(sayı))//Sayı 0 olana kadar döngünün çalışmasını sağlar. 
                        //Sayı%sayı==0, sayı==0 veya sayı<=10 dersek sayının tamamını almadan döngüden çıkar.
                        {
                            kalan = sayı % 10;
                            sayı = sayı / 10;
                            toplam = toplam * 10 + kalan;
                        }
                        if (ters == toplam)
                        {
                            Console.WriteLine("Girdiğiniz sayı bir palindromdur. ");
                        }
                        else
                        {
                            Console.WriteLine("Girdiğiniz sayı bir palindrom değildir.");
                        }
                    }
                }
            }
        }
    }
}
