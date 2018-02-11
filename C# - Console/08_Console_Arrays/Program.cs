using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //int sayi = 6;
            //string metin = "diziler";

            ////Bir sınıfa ait kişilerin isimleri:
            ////String adSoyad1,adSoyad2,adSoyad3...adSoyadN

            ////Bir sınıftaki kişilerin not ortalamaları:

            //int[] sınıfNotları = new int[15];
            //sınıfNotları[0] = 30;
            //sınıfNotları[1] = 29;
            //sınıfNotları[2] = 79;
            //sınıfNotları[3] = 11;
            //sınıfNotları[4] = 20;
            //sınıfNotları[5] = 60;
            //sınıfNotları[6] = 1;
            //sınıfNotları[7] = 90;
            //sınıfNotları[14] = 90;
            ////Console.WriteLine(sınıfNotları[0]);
            ////Console.WriteLine(sınıfNotları[1]);
            ////Console.WriteLine(sınıfNotları[2]);
            ////Console.WriteLine(sınıfNotları[3]);
            ////Console.WriteLine(sınıfNotları[4]);
            ////Console.WriteLine(sınıfNotları[5]);
            ////Console.WriteLine(sınıfNotları[6]);
            ////Console.WriteLine(sınıfNotları[7]);
            ////Console.WriteLine(sınıfNotları[10]);

            //int index = 0;
            //while (index < 15)
            //{
            //    Console.WriteLine(sınıfNotları[index]);
            //    index++;
            //}
            //----------------------------
            //int a=new int();
            //Console.WriteLine(a);

            //int[]sınıfNotları=new int[15]
            //int[] sınıfNotları2 = new int[10] { 2, 5, 9, 0, 11, 23, 44, 53, 100, 10 };
            //int[] sınıfNotları3 = new[] { 2, 5, 9, 0, 11, 23, 44, 53, 100, 10 };
            //int[] sınıfNotları4 = { 2, 5, 9, 0, 11, 23, 44, 53, 100, 10 };

            //string[] mevsimler = new string[4]{"İlkbahar", "yaz", "sonbahar", "kış"};
            //int index = 0;
            //while (index < 4)
            //{
            //    Console.WriteLine(mevsimler[index]);
            //    index++;
            //}

            //string[] mevsimler = new string[4] { "İlkbahar", "yaz", "sonbahar", "kış" };
            //int index = 0;
            //while (index < mevsimler.Length) ////////----------->Alternatif
            //{
            //    Console.WriteLine(mevsimler[index]);
            //    index++;
            //}
            //1//
            //10 elemanlı bir sayı dizisinin ortalamasını hesaplayınız.
            //int[] sayı = new int[10] { 2, 5, 6, 7, 8, 9, 10, 11, 15, 90 };
            //int index=0;
            //int toplam=0;
            //while (index < sayı.Length)
            //{
            //    toplam=toplam+sayı[index];
            //    index++;
            //}
            //Console.WriteLine(toplam/10);
            //2//

            //5 elemanlı bir sayı dizisini büyükten küçüğe sıralayınız. // bouble sshort

            //int[] dizi = { 2, 7, 5, 3, 19 };
            //int sayac = 0;
            //int kova;
            //bool durum = true;
            //while (durum)
            //{
            //    durum = false;
            //    while (sayac < dizi.Length - 1)
            //    {
            //        if (dizi[sayac] < dizi[sayac + 1])
            //        {
            //            kova = dizi[sayac];
            //            dizi[sayac] = dizi[sayac + 1];
            //            dizi[sayac + 1] = kova;
            //            durum = true;
            //        }
            //        sayac++;
            //    }
            //    sayac = 0;
            //}
            //int index = 0;
            //while (index < dizi.Length)
            //{
            //    Console.WriteLine(dizi[index]);
            //    index++;
            //}
            //Console.Read();
            string[]players={"Tsubasa","Misaki","Hyuga","Misugi","Wakabayashi"};
            int counter=0;
            int halfLength=players.Length/2;
            while(counter<halfLength){
                string name=players[counter];
                players[counter]=players[players.Length-1-counter];
                players[players.Length-1-counter]=name;
                counter++;
            }
            counter = 0;
            while (counter < players.Length)
            {
                Console.WriteLine(players[counter]);
                counter++;
            }
            Console.Read();
                          
        }
    }
}
