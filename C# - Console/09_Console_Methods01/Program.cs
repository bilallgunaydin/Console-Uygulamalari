using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Console_Methods01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen sırayla iki sayı yazınız:");
            Console.Write("Sayı 1: ");
            string input01 = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Sayı 2: ");
            string input02 = Console.ReadLine();
            Console.WriteLine();
            int number1 = int.Parse(input01);
            int number2 = int.Parse(input02);
            //int total = number1 + number2;
            int result = Sum(number1, number2);

            Console.WriteLine("İki sayının toplamı: {0}", result);

            Console.ReadLine();

        }

        //Fonksiyon(metot) tanımları, Main(veya diğer) fonksiyonun dışında yapılmalıdır.
        //Fonksiyon yazarken, fonksiyonun dönüş tipi yazdırılır.
        //1.Dönüş Tipi
        //2.Fonkisyonun ismi(PascalCase)
        //3.Fonksiyon Parantezler
        //4.Eğer ki varsa parametreler
        //5.Scope Parantezleri
        //6.Eğer dönüş tipi varsa, return ifadesini belirtmek
        //Metot imzası
        //1.Metodun ismi
        //2.Parametre sırası,sayısı
        //3.Paremetrelerin sıralı olarak tipleri
        static int Sum(int num1,int num2)
        {
            int total = num1 + num2;
            return total;
        }
        //Method Overloading
        //Aynı İSİMDE ancak FARKLI İMZADA metodu tekrar tanımlamaya 
        //METHOD OVERLOAD diyoruz
        static int Sum(int num1, int num2,int num3)
        {
            int total = num1 + num2+num3;
            return total;
        }
        //Bu metot Sum metodunun overload'u değildir
        static int GetTotal(int num1, int num2, int num3)
        {
            int total = num1 + num2 + num3;
            return total;
        }
    }
}
