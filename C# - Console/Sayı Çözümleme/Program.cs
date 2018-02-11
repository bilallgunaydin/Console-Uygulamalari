using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _9_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir tamsayı alan ve tamsayı basamaklarını çözümleyen program ");
            Console.WriteLine();
            bool durum = true;
            while (durum)
            {
                Console.WriteLine("Çözümlemek istediğiniz bir sayı giriniz.");
                int number;
                string input = Console.ReadLine();
                bool basarılı = int.TryParse(input, out number);
                if (input == "exit")
                {
                    break;
                }
                else
                {
                    if (basarılı)
                    {
                        int stepValue = 1;
                        int figure;
                        while (number / Convert.ToInt32(Math.Pow(10, (stepValue - 1))) != 0)
                        {
                            figure = Convert.ToInt32(number % Math.Pow(10, stepValue)) / Convert.ToInt32(Math.Pow(10, (stepValue - 1)));
                            Console.WriteLine("{0} x {1} = {2}", figure, Math.Pow(10, (stepValue - 1)), figure * Math.Pow(10, (stepValue - 1)));
                            stepValue++;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Yanlış giriş yaptınız. Lütfen sayısal bir giriş yapınız.");
                    }
                }
            }
            Console.Read();
        }
    }
}

