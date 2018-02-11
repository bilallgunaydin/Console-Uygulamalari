using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_Console_Operators
{
    class Program
    {
        static void Main(string[] args)
        {

            #region ismi
            //asdasdasdasdasdasdasdasda
            //    sdasdasdas
            //    asdasdas

#endregion
            #region aritmetiksel işlemler
            //Aritmetiksel Operatörler
            // +,-,*,/,%
            
            //int a=8;
            //int b=20;
            //int c;

            //Console.WriteLine("a=" + a + ";b=" + b);

            ////c=a+b;
            ////Console.WriteLine("a+b = "+c);

            ////c=a-b;
            //// Console.WriteLine("a-b = "+c);
            
            ////c=a*b;
            //// Console.WriteLine("a*b = "+c);

            ////c=a/b;
            //// Console.WriteLine("a/b = "+c);

            //// a = a + 1;

            //// a++;
            //// Console.WriteLine("a= "+a);

            //c = a++ + b;

            //Console.WriteLine(" c = a++ + b;"+c);
            //c = ++a + b;
            //Console.WriteLine(" c = ++a + b;" + c);

            ////10, b=20
            //c = --a + b++;
            ////c=?

            //Console.WriteLine("c = --a + b++ ="+c);

            ////c=++a+b;

            ////a=a+1;
            ////c=a+b;
            ////------------

            ////c= a++ +b;
            ////c= a+b;
#endregion

            #region aklındanSayıTut
            ///*
            // *Aklında 1 ile 100 arasında bir sayı tut
            // *2 ile çarp
            // *8 ekle
            // *yarısını bul
            // *aklınızdan tuttuğunuz sayıyı bu sayıdan çıkartın
            // *sonuç?
            // *4 çıktı, tebrikler
            // */
            //Console.WriteLine("Aklından 1 ile 100 arasında bir sayı tut");
            //Console.WriteLine("Tuttuğunuz sayıyı giriniz: ");
            //string input = Console.ReadLine();
            //int sayı = int.Parse(input);

            //Console.WriteLine("Şimdi sayıyı iki çarp(devam etmek için entere basın)");

            ////Ekrandan bir satır okumak için kullanmıyoruz.
            ////Enter tuşunu algılamak için kullanıyoruz.
            //Console.ReadLine();

            //int sonuc = sayı * 2;

            //Console.WriteLine(sayı + " x 2 = " + sonuc);

            //Console.WriteLine("Şimdi sonuca 8 ekle(devam için entere basın)");

            ////Ekrandan bir satır okumak için kullanmıyoruz.
            ////Enter tuşunu algılamak için kullanıyoruz.
            //Console.ReadLine();

            //int sonuc2 = sonuc + 8;

            //Console.WriteLine(sonuc+ " + 8= " +sonuc2);

            //Console.WriteLine("Çıkan sonucun yarısını bul(devam etmek için entere basın)");

            ////Ekrandan bir satır okumak için kullanmıyoruz.
            ////Enter tuşunu algılamak için kullanıyoruz.
            //Console.ReadLine();

            //int sonuc3 = sonuc2 / 2;

            //Console.WriteLine(sonuc2+ " / 2= "+sonuc3);

            //Console.WriteLine("Son çıkan sayıdan tuttuğunuz sayıyı çıkartın(devam etmek için entere basın)");


            ////Ekrandan bir satır okumak için kullanmıyoruz.
            ////Enter tuşunu algılamak için kullanıyoruz.
            //Console.ReadLine();

            //int sonuc4 = sonuc3 - sayı;

            //Console.WriteLine("Sonuc 4 mü çıktı? Şaşılacak hadise!!");

            //Console.WriteLine(sonuc3 + " - " + sayı + " = " + sonuc4);

           

            #endregion
            #region Mantıksal İşlemler(Operatörleri)

            ////Mantıksal operatörler
            //// ==,!=,>,<,>=,<=

            //int a = 21;
            //int b = 10;
            //bool c;

            //Console.WriteLine("a={0},b={1}",a,b);
            //Console.WriteLine("A ve b eşit midir?");
            //Console.WriteLine(a ==b);

            //Console.WriteLine("A ve b eşit değil midir?");
            //Console.WriteLine(a !=b);

       

            //Console.WriteLine("a,b'den küçük müdür?");
            //c = a < b;
            //Console.WriteLine(c);

            //Console.Write("a,b^'den büyük müdür?\n");
            //c = a > b;
            //Console.Write(c+"\n");

            //bool sonuc;
            //// Veya (OR) Operatörü

            //sonuc = false || false; // sonuc: false 
            //sonuc = true || false; // sonuc: true 
            //sonuc = false || true; // sonuc: true
            //sonuc = true || true; // sonuc: true

            ////Ve (AND) Operatörü

            //sonuc = false && false; // sonuc: false 
            //sonuc = true && false; // sonuc: true 
            //sonuc = false && true; // sonuc: true
            //sonuc = true && true; // sonuc: true

            //sonuc = 5 > 4 && 3 > 4 || true && 6 < 2; //sonuc false'dir.

            //sonuc = (6 > 2 || 5 > 9) && 5 ==5;     //sonuc true

            //sonuc = 3 < 5 || 4 != 4 && (2 >= 2 || (3 < 3) || false);//sonuc:true

            #endregion

            #region Atama İşlemleri(Operatörleri)

            // Atama işlemleri (Operatörleri)
            // =,+=,-=,*=,/=

            int a = 7;
            int c;
            Console.WriteLine("a= {0}",a);

            c = a;
            Console.WriteLine("c= anın sonucunda c:{0}",c);

            c += a; //c =c + a
            Console.WriteLine("c += a nın sonucunda c: {0}",c);

            c -= a; //c =c - a
            Console.WriteLine("c -= a nın sonucunda c: {0}", c);

            c *= a; // c = c * a;
            Console.WriteLine("c *=a nın sonucunda c:{0}", c);
            
            c /= a; // c = c / a
            Console.WriteLine("c /=a nın sonucunda c:{0}", c);

            c %= a; // c = c / a
            Console.WriteLine("c %=a nın sonucunda c:{0}", c);
            #endregion
            Console.ReadKey();






        }

    }
}
