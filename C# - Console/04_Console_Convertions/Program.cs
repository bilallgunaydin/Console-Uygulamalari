using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Console_Convertions
{
    class Program
    {
        static void Main(string[] args)
        {
           // ////Convensions(Dönüşümler)

           // ////Implicit Convension(Kapalı)
           // //int toplam;
           // //byte sayi = 25;
           // //toplam = sayi;

           // //int num = int.MaxValue;
           // //long bigNum = num;

           // ////Explicit Convertions(Açık)
           // //byte toplam2;
           // //int sayi2 = 300;
           // //toplam2 = (byte)sayi2;

           // ////tip dönüşümlerinde tip uyumsuzluğu durumunda atama işlemi yapabilmek için "cast" işlemini kullanırız.

           // //long bigNum2 = 3000000000;
           // //int num2;
           // //num2 = (int)bigNum2;

           // //--------------------------

           // //Console.WriteLine("Lütfen bir sayı yazınız: ");

           // ////Boxing /Kutulama
           // //object input = Console.ReadLine();

           // //object number = 100;

           // //int bigNum =(int) number/*Unboxing*/* 10;


           // ////Unboxing

           // //string yazıylaSayı = (string)number;
           // ////--------------------------------

           // // String ifadeleri nümerik tiplere dönüştürürken Parse metotları kullanırız.

           ////int a =int.Parse("55");
           //// byte b =byte.Parse("39");
           ////  double c =double.Parse("123.5");

           //// //Nümerik veri tipleri(hatta herhangi bir veri tipi için) string tiplere dönüştürürken ise;
           ////  string sonuc = a.ToString();
           ////  string sonuc2 = b.ToString();
           ////  string sonuc3 = c.ToString();

           // //---------------------------


           // //Convert 
           // int x = Convert.ToInt32("46456");

            //---------------------------

            //string sonuc = "45" + 5;//455
            //string sonuc = "45" +( 5 + 9);//4514
            //string sonuc = 4 + 5 + "50";//950
            //string sonuc = 5 + 9 + "45";//1445
            //string sonuc = 5 + "45" + 9;5459
            //string sonuc = 5 + 9 + "23" + 5 + 4 + "3";//1423543
            //string sonuc = 5 + (9 + "23") + 5 + 4 + "3";

        }
    }
}
