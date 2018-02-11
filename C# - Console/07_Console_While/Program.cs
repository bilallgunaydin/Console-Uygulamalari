using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Console_While
{
    class Program
    {
        static void Main(string[] args)
        {

            //Döngüler (While)
            /*
             While (koşul) 
            {
                //işlemler;
            * 
            }
             
            */

            //1'den 20ye kadar ki sayıları alt alta yazdıran programı yazıız.
            //int sayi = 1;
            //while (sayi <= 20)
            //{
            //    Console.WriteLine(sayi);
            //    sayi++;
            //}
            //Console.Read();

            //100e kadar olan çift sayıların toplamı kaçtır=?

            //Part 1
            //int sayi2 = 1;
            //int toplam=0;
            //while (sayi2 <100)
            //{
            //    if (sayi2 % 2 == 0)
            //    {
            //        toplam = toplam + sayi2;
            //    }

            //    sayi2++;
            //}
            //Console.WriteLine("Toplam:{0}",toplam);
            //Console.Read();

            ////Part 2
            //int sayı = 0;
            //int toplam = 0;

            //while (sayı < 100)
            //{
            //    toplam = toplam + sayı;
            //    sayı = sayı + 2;

            //}
            //Console.WriteLine("Toplam:{0}",toplam);
            ////Console.Read();
            //PART 3 (Bu şekilde kullanmayı tercih etmeyiniz).
            //int sayı = 1;
            //int toplam = 0;
            //while (true)
            //{
            //    if (sayı % 2 == 0)
            //    {
            //        toplam = toplam + sayı;
            //    }
            //    sayı++;

            //    if (sayı > 99)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("Toplam:{0}", toplam);
            //Console.Read();

            ////Do-While -------------> Koşul doğru veya yanlış farketmeksizin en az 1 kere çalıştırılır. Sonra koşul doğru olarak devam ettikçe işlem devam eder.
            /*
             * do
             * {
             * 
             *  //Yapılacak işlemler
             *  }while(koşul)
             */

            //Girilen şifrenin doğru olup olmadığını kontrol eden kodu yazınız. Doğru değilse yeniden girilmesini isteyiniz.

            //PART 1
            //string sifre = "Burak123";
            //string kullanıcınınGirdigiSifre;
            //Console.WriteLine("Selam Kullanıcı. Lütfen şifreyi giriniz:");
            //do
            //{

            //  kullanıcınınGirdigiSifre = Console.ReadLine();

            //}
            //while (kullanıcınınGirdigiSifre != sifre);            

            //Console.WriteLine("Şifre doğru");
            //Console.Read();
            //PART 2
            //string sifre = "Burak123";
            //string kullanıcınınGirdigiSifre;
            //Console.WriteLine("Selam Kullanıcı. Lütfen şifreyi giriniz:");
            //do
            //{
            //    if (kullanıcınınGirdigiSifre!= null)
            //        Console.WriteLine("Tekrar deneyiniz");
            //    kullanıcınınGirdigiSifre = Console.ReadLine();

            //}
            //while (sifre != kullanıcınınGirdigiSifre);

            //Console.WriteLine("Şifre doğru");
            //Console.Read();

            //Kullanıcıdan sınıf mevcudu alıp, sınıftakilerin isimlerini tek tek isteyip, isim girişi bittikten sonra sınıftakilerin adını aralarına virgü koyarak yazdırınız
            //Console.WriteLine("Sınıf mevcudunu giriniz:");
            //int sinifMevcudu = int.Parse(Console.ReadLine());
            //int girilenOgrenciSayısı = 0;
            //string ogrenciler = "";
            //do
            //{

            //    if (sinifMevcudu - girilenOgrenciSayısı == 1)
            //    {
            //        ogrenciler = ogrenciler + Console.ReadLine();
            //        girilenOgrenciSayısı++;
            //    }

            //    else
            //    {
            //        ogrenciler = ogrenciler + Console.ReadLine() + ",";
            //        girilenOgrenciSayısı++;
            //    }
            //} while (girilenOgrenciSayısı < sinifMevcudu);

            //Console.Write(ogrenciler);
            //Console.Read();
            //Kullanıcıdan sınıf mevcudu almadan, sınıftakilerin isimlerini tek tek isteyip, isim girişi bittikten sonra sınıftakilerin adını aralarına virgü koyarak yazdırınız
            //(Versıon 2).

            //string adSoyad=null;
            //string siniftikalar = "";
            //Console.WriteLine("Çıkış için 0");
            //while(adSoyad!="0")
            //{
            //    Console.WriteLine("Ad Soyad: ");
            //    adSoyad = Console.ReadLine();

            //    if (adSoyad != "0")
            //    {
            //        siniftikalar=siniftikalar+adSoyad+",";
            //    }
            //}
            //Console.WriteLine(siniftikalar);
            //Console.ReadKey();

           //*****
           //*****
           //*****
           //*****
           //2)  *****
           //    *   *
           //    *   * 
           //    *   *
           //    *****
           //  3)*
           //    **
           //    ***
           //    ****
           //    *****
           //   4)*
           //     * *
           //     *   *
           //     *     *
           //     * * * * *
            //1-)
            //int satır = 0;
            //int sütun = 0;
            //while (satır < 5)
            //{
            //    while (sütun < 5)
            //    {
            //        Console.Write("*");
            //        sütun++;
            //    }
            //    Console.Write("\n");
            //    sütun = 0;
            //    satır++;
            //}
            //Console.Read();

            ////2-)
            //int satır = 0;
            //int sütun = 0;
            //while (satır < 5)
            //{
            //    while (sütun < 5)
            //    {
            //        if (satır == 0 || satır == 4)
            //        {
            //            Console.Write("*");
            //            sütun++;
            //        }
            //        else
            //        {
            //            if (sütun == 0 || sütun == 4)
            //            {
            //                Console.Write("*");
            //                sütun++;
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //                sütun++;
            //            }
            //        }

            //    }
            //    sütun = 0;
            //    Console.Write("\n");
            //    satır++;

            //}
            //Console.Read();

            //5)
            //Girilen sayıyı basamaklarına aşağıdaki şekilde ayırınız:
            //345
            //5x1=5
            //4x=10=40
            //3x100=300
            //int sayi = int.Parse(Console.ReadLine());
            //string yazıylaSayı = Console.ReadLine();
            //int sayıUzunluğu = yazıylaSayı.Length;
            //int basamakSayısı = 1;
            //int rakam;
            //int sayi = int.Parse(Console.ReadLine());
            //while (sayi/Convert.ToInt32(Math.Pow(10,basamakSayısı-1))!=0)
            //{
               
            //        rakam = Convert.ToInt32(sayi % Math.Pow(10, basamakSayısı)) / Convert.ToInt32(Math.Pow(10, basamakSayısı - 1));

            //        Console.WriteLine("{0}x{1}={2}", rakam, Math.Pow(10, basamakSayısı - 1), rakam * Math.Pow(10, basamakSayısı - 1));
            //        basamakSayısı++;
                    
               
            //}
            //Console.Read();
            
        }
    }
}
