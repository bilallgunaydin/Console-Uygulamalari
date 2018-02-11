using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Console_RefOutKeywords
{
    class Program
    {
        static void Main(string[] args)
        
        {
            //

            //Console.Write("Lütfen bir sayı yazınız: ");
            //string input = Console.ReadLine();
            //Console.Write('\n');

            //int number;

            //bool isSuccess = int.TryParse(input, out number);

            //if (isSuccess)
            //{
            //    int square = number * number;
            //}
            //else
            //{
            //    Console.WriteLine("Yanlış bir giriş yaptınız");

            //}

        //    Console.Write("Lütfen bölünen sayıyı giriniz: ");
        //    string input1 = Console.ReadLine();
        //    Console.Write('\n');
            
        //    Console.Write("Lütfen bölen sayıyı giriniz: ");
        //    string input2 = Console.ReadLine();
        //    Console.Write('\n');

        //    int number = int.Parse(input1);
        //    int divisor = int.Parse(input2);

        //    int division;
        //    bool isSafe = SafeDivide(number, divisor, out division);
        //    if (isSafe)
        //    {
        //        Console.Write("{0} sayısının {1} sayısına bölümü: {2}", number, divisor, division);
        //    }
        //    else
        //    {
        //        Console.Write("Bu bölme güvenli değil");
        //    }

            
        //    Console.ReadLine();
        }


        static int Divide(int number, int divisor)
        {
            int result = number / divisor;

            return result;
        }

        static bool SafeDivide(int number, int divisor,out int result)
        {
            if (divisor == 0)
            {
                result = 0;
                return false;
            }
            else
            {
                result = number / divisor;
            }
            return true;
            
        }
    }
}
