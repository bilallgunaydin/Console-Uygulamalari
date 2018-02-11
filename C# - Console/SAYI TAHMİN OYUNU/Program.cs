using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("SAYI TAHMİN OYUNU");
            Console.WriteLine();
            Console.WriteLine("Lütfen aşağıdaki zorluk seviyelerinden birisini seçiniz: ");
            int sayı;
            int point = 1000;
            bool seçenek = true;
            bool durum = true;
            Random rnd = new Random();
            int tahmin = rnd.Next(1, 10);
            int tahmin2 = rnd.Next(1, 100);
            int tahmin3 = rnd.Next(1, 1000);
            int counter = 1;
            while (seçenek)
            {
                Console.WriteLine();
                Console.WriteLine("Kolay seviyenin amacı 1 ile 10 arasında bulunan sayılar arasından doğru olanı tahmin etmektir. Kolay seviye için 1'i tuşlayın");
                Console.WriteLine("Orta seviyenin amacı 1 ile 100 arasında bulunan sayılar arasından doğru olanı tahmin etmektir. Orta seviye için 2'i tuşlayın");
                Console.WriteLine("Zor seviyenin amacı 1 ile 1000 arasında bulunan sayılar arasından doğru olanı tahmin etmektir. Zor seviye için 3'i tuşlayın");
                string input = Console.ReadLine();
                durum = int.TryParse(input, out sayı);
                if (durum == false)
                {
                    Console.WriteLine("Yanlış giriş yaptınız: Lütfen menüden belirtilen sayısal ifadelerden birini giriniz");
                }
                else
                {
                    int secim = int.Parse(input);
                    if (secim == 1)
                    {
                        if (durum == false)
                        {
                            Console.Write("Yanlış giriş yaptınız. Lütfen tahmin yaparken sayısal değer girin:");
                        }
                        else
                        {
                            Console.Write("Lütfen tahmininizi yapınız:");
                            string input2 = Console.ReadLine();
                            durum = int.TryParse(input2, out sayı);
                            Console.WriteLine();
                            if (tahmin == sayı)
                            {
                                Console.Write("Tebrikler!!" + tahmin + " Doğru Tahmin!");
                                Console.Write("Oyunu " + counter + " tahminde bitirdiniz.");
                                point = point - (counter * 5) + 5;
                                Console.WriteLine("Puanınız : {0}", point);
                                break;
                            }
                            else
                            {
                                if ((sayı - tahmin >= 7) || (tahmin - sayı >= 7))
                                {
                                    Console.Write("Yanlış tahmin yaptınız. Sayıya yakınlığınız: Soğuk\n");
                                }

                                else if ((sayı - tahmin >= 3) || (tahmin - sayı >= 3))
                                {
                                    Console.Write("Yanlış tahmin yaptınız. Sayıya yakınlığınız: Ilık\n");
                                }

                                else if ((sayı - tahmin >= 0) || (tahmin - sayı >= 0))
                                {
                                    Console.Write("Yanlış tahmin yaptınız. Sayıya yakınlığınız: Sıcak\n");
                                }
                                counter++;
                            }
                        }
                    }
                    else if (secim == 2)
                    {
                        if (durum == false)
                        {
                            Console.Write("Yanlış giriş yaptınız. Lütfen tahmin yaparken sayısal değer girin:");
                        }
                        else
                        {
                            Console.Write("Lütfen tahmininizi yapınız:");
                            string input2 = Console.ReadLine();
                            durum = int.TryParse(input2, out sayı);
                            Console.WriteLine();
                            if (tahmin2 == sayı)
                            {
                                Console.Write("Tebrikler!!" + tahmin + " Doğru Tahmin!");
                                Console.Write("Oyunu " + counter + " tahminde bitirdiniz.");
                                point = point - (counter * 5) + 5;
                                Console.WriteLine("Puanınız : {0}", point);
                                break;
                            }
                            else
                            {
                                if ((sayı - tahmin >= 75) || (tahmin - sayı >= 75))
                                {
                                    Console.Write("Yanlış tahmin yaptınız. Sayıya yakınlığınız: Soğuk\n");
                                }

                                else if ((sayı - tahmin >= 50) || (tahmin - sayı >= 50))
                                {
                                    Console.Write("Yanlış tahmin yaptınız. Sayıya yakınlığınız: Ilık\n");
                                }

                                else if ((sayı - tahmin >= 0) || (tahmin - sayı >= 0))
                                {
                                    Console.Write("Yanlış tahmin yaptınız. Sayıya yakınlığınız: Sıcak\n");
                                }
                                counter++;
                            }
                        }
                    }
                    else if (secim == 3)
                    {
                        if (durum == false)
                        {
                            Console.Write("Yanlış giriş yaptınız. Lütfen tahmin yaparken sayısal değer girin:");
                        }
                        else
                        {
                            Console.Write("Lütfen tahmininizi yapınız:");
                            string input2 = Console.ReadLine();
                            durum = int.TryParse(input2, out sayı);
                            Console.WriteLine();
                            if (tahmin3 == sayı)
                            {
                                Console.Write("Tebrikler!!" + tahmin + " Doğru Tahmin!");
                                Console.Write("Oyunu " + counter + " tahminde bitirdiniz.");
                                point = point - (counter * 5) + 5;
                                Console.WriteLine("Puanınız : {0}", point);
                                break;
                            }
                            else
                            {
                                if ((sayı - tahmin >= 750) || (tahmin - sayı >= 750))
                                {
                                    Console.Write("Yanlış tahmin yaptınız. Sayıya yakınlığınız: Soğuk\n");
                                }

                                else if ((sayı - tahmin >= 400) || (tahmin - sayı >= 400))
                                {
                                    Console.Write("Yanlış tahmin yaptınız. Sayıya yakınlığınız: Ilık\n");
                                }

                                else if ((sayı - tahmin >= 0) || (tahmin - sayı >= 0))
                                {
                                    Console.Write("Yanlış tahmin yaptınız. Sayıya yakınlığınız: Sıcak\n");
                                }
                                counter++;
                            }

                        }
                    }
                }
            }
        }
    }
}
            