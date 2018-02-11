using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _160901_T.C_numarası_Kontrolü
{
    class Program
    {
        static void Main(string[] args)
        {
            bool sayıKontrol = false;
            bool kontrol = false;
            long sayı;
            int index = 0;
            int toplam = 0;
            int toplam2 = 0;
            int toplam3 = 0;
            while (!sayıKontrol)
            {
                Console.Write("Lütfen T.C kimlik numaranızı giriniz:");
                sayıKontrol = long.TryParse(Console.ReadLine(), out sayı);
                if (!sayıKontrol)
                {
                    Console.WriteLine("Yanlış giriş yaptınız, lütfen T.C kimlik numaranızı sayısal değerler kullanarak girin.");
                }
                else
                {
                    while (!kontrol)
                    {
                        string gecis = sayı.ToString();
                        if (gecis.Length == 11)
                        {
                            while (index < gecis.Length)
                            {
                                if (index < 9)
                                {
                                    if (index % 2 == 0)
                                    {
                                     toplam = toplam + Convert.ToInt32(gecis[index].ToString());
                                     toplam3 = toplam3 + Convert.ToInt32(gecis[index].ToString());
                                    }
                                    else
                                    {
                                      toplam2 = toplam2 + Convert.ToInt32(gecis[index].ToString());
                                    }
                                }
                                index++;
                            }

                            toplam = ((toplam * 7) + (toplam2 * 9)) % 10;//10.hane ile kıyaslanacak toplam

                            toplam3 = (toplam3 * 8) % 10;//11.hane ile kıyaslanacak toplam

                            index = 9;
                            if (toplam == Convert.ToInt32(gecis[index].ToString()) 
                                && toplam3 == Convert.ToInt32(gecis[index + 1].ToString()))
                            {
                                Console.WriteLine("Girdiğiniz sayı bir T.C kimlik numarasıdır.");
                                break;
                            }
                            else
                            {
                             Console.WriteLine("Girdiğiniz sayı bir T.C kimlik numarası değildir");
                                break;
                            }
                        }
                        else
                        {
                            Console.Write("11 haneli sayı girmediniz.\nEğer 11 haneli sayı girdiğinizi düşünüyorsanız sayının başına 0 girdiğiniz için kabul edilmiyor. Çünkü hiçbir T.C kimlik numarası 0 ile başlamaz.\nLütfen tekrar sayı giriniz:");
                            sayı = long.Parse(Console.ReadLine());
                        }
                    }
                }
            }
            Console.Read();
        }
    }
}
