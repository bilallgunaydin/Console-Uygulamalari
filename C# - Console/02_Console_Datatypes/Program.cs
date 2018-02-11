using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console_Datatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            /*
             çoklu
             Yorum
             Satırı
             */
            // değişken Tanımlama
            // [data_tipi] (değişken_adı)
            /*int sayi;
            int sayi1=5;
            int sayi2=4,sayi3=13,sayi4=123123;
            var x = 4;
            var y='Ahmmet';
            var z='c';
            ///////////////////
            //----Değişken isimlendirme kuralları
            //----Sayı ve özel karakterlerle başlayamaz.('_' ve '@' hariç)
            //Değişken isimleri '|','?','(',')','{','}','[',']' içermez.
            //Değişken isimleri büyük/küçük harfe duyarlıdır.
            //Birden fazla kelimenin değişkenler için araya boşluk konulamaz. Çok lazımsa '_' ile ayrılabilir.
           //Genel kabul görmüş bazı değişken isimlendirme standartları vardır:
            // Camel Case : dogumTarihi,adSoyad,degişkeninİlkDeğeri
            // Pascal Case : DoğumTarihi,AdSoyad,DeğişkeninİlkDeğeri
            //Değilken İsimleri anlamlı ve tuttuğu değeri tarih eder.

            //Reserved Keywords: C# için anlamlı olan kelimelerdir. Değişken isimlendirilmelerde reserwed keyword'ler kullanılmaz.
            // Not: Burak, illa da kullanmak istiyorsanız reserved keywordler başına '_' ve '@' ekleyebilirsiniz.

            /*
             * int : tam sayı değerdir. 2 milyar, -2 milyar arası
             * string : metinsel ifade tutar. En fazla kaç karakter? (boyutsuz)
             *bool : True ve False değerlerini alırlar. (1bit)
             *char: Tek bir karakter tutar(Her karakter 1 byte
             *byte: Tam sayı değeri tutar . 0-255 (1 byte)   
             *double, float,decimal: Ondalıklı sayı tutar ------- Araştır
             *long : Tam sayı tutar ------- Araştır
             *object: Her türden veri tutabilir.
             *short,uint,ulong,sbyte --- Buna bak
             */
            /*int deger= 540;
            string metin="Serkan Soydam";
            char harf='A';
            bool durum= True;
            double ondalıklı=5,01;
            byte kucukSayı=125;
            decimal ondaliklı2=0,16;
            float ondalıklı3=3,14F;
            long cokBuyukSayı=15456414645646;
            
            object herhangiBirşey="Test";
            object aşkaBirŞey=323;
            object diğerBişey='x';
            object bisey=5,19;
            object farklıbişey=true;
            bisey="ayça";
            
            var x = 4;
            var y='Ahmmet';
            var z='c';
            var t1=0.34M;

            Console.WriteLine();
            */
            int boyut=sizeof(int);
            Console.WriteLine("int veri tipinin boyutu: "+boyut+"Byte");

            Console.WriteLine("Int veri tipinin max değeri: "+int.MaxValue);
            Console.WriteLine("Int veri tipinin min değeri:"+int.MinValue);

            Console.WriteLine("Size of long:"+sizeof(long)+" byte yer kaplar. Max:"+long.MaxValue+"Min "+long.MinValue);
            Console.WriteLine("Size of long:" + sizeof(short) + " byte yer kaplar. Max:" + short.MaxValue + " Min " + short.MinValue);
            Console.WriteLine("Size of long:" + sizeof(uint) + " byte yer kaplar. Max:" + uint.MaxValue + "Min " + uint.MinValue);

            Console.Beep(660, 125);
            


        }
    }
}
