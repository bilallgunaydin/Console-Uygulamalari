using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _9_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OTOPARK ÜCRET HESAPLAMA PROGRAMI");
            Console.WriteLine();
            Console.WriteLine("Lütfen otoparka bıraktığınız aracın tipini aşağıdaki seçeneklere uygun olarak seçiniz");
            Console.WriteLine("Otomobil için 1’e basın ");
            Console.WriteLine("Motosiklet için 2’ye basın");
            Console.WriteLine("Minibüs için 3’e basın");
            Console.WriteLine("Kamyon (ve diğer ticari araçlar) için 4’e basın ");
            Console.WriteLine("Seçim:");
            bool menü = true;
            bool durum = true;
            bool TryAgain = true;
            while (menü)
            {
                double saat;
                double ödeme = 0;
                char secim = Console.ReadKey(true).KeyChar;
                if (secim == '1')
                {
                    while (TryAgain)
                    {
                        Console.WriteLine("Seçtiğiniz araç türü Otomobil");
                        Console.WriteLine();
                        Console.WriteLine("Araç kaç saat boyunca park alanında kaldı? ");
                        string input = Console.ReadLine();
                        durum = double.TryParse(input, out saat);
                        if (durum == false)
                        {
                            Console.WriteLine("Lütfen geçerli bir sayı yazınız!");
                        }
                        else
                        {
                            if (saat > 0 && saat <= 2)
                            {
                                Console.WriteLine("Ödemeniz gereken tutar 5 tl");
                            }
                            else if (saat > 2 && saat <= 6)
                            {
                                Console.WriteLine("Ödemeniz gereken tutar 10 tl");
                            }
                            else if (saat > 6 && saat <= 12)
                            {
                                Console.WriteLine("Ödemeniz gereken tutar 20 tl");
                            }
                            else if (saat > 12 && saat <= 24)
                            {
                                Console.WriteLine("Ödemeniz gereken tutar 35 tl");
                            }
                            else if (saat > 24)
                            {
                                saat = saat / 24;
                                int sayac = 1;
                                while (sayac < saat)
                                {
                                    ödeme = ödeme + 20;
                                    sayac++;
                                }
                                Console.Write("Ödemeniz gereken tutar:{0}", ödeme+35+"TL");
                            }
                            menü = false;
                            break;
                        }
                    }
                }
                else if (secim == '2')
                {
                    while (TryAgain)
                    {
                        Console.WriteLine("Seçtiğiniz araç türü Motosiklet");
                        Console.WriteLine();
                        Console.WriteLine("Araç kaç saat boyunca park alanında kaldı? ");
                        string input = Console.ReadLine();
                        durum = double.TryParse(input, out saat);
                        if (durum == false)
                        {
                            Console.WriteLine("Lütfen geçerli bir sayı yazınız!");
                        }
                        else
                        {
                            if (saat > 0 && saat <= 2)
                            {
                                Console.WriteLine("Ödemeniz yok.");
                            }
                            else if (saat > 2 && saat <= 6)
                            {
                                Console.WriteLine("Ödemeniz gereken tutar 3 tl");
                            }
                            else if (saat > 6 && saat <= 12)
                            {
                                Console.WriteLine("Ödemeniz gereken tutar 6 tl");
                            }
                            else if (saat > 12 && saat <= 24)
                            {
                                Console.WriteLine("Ödemeniz gereken tutar 12 tl");
                            }
                            else if (saat > 24)
                            {
                                saat = saat / 24;
                                int sayac = 1;
                                while (sayac < saat)
                                {
                                    ödeme = ödeme + 10;
                                    sayac++;
                                }
                                Console.Write("Ödemeniz gereken tutar:{0}", ödeme + 12 + "TL");
                            }
                            menü = false;
                            break;
                        }
                    }
                }
                else if (secim == '3')
                {
                    menü = false;
                    while (TryAgain)
                    {
                        Console.WriteLine("Seçtiğiniz araç türü Minibüs");
                        Console.WriteLine();
                        Console.WriteLine("Araç kaç saat boyunca park alanında kaldı? ");
                        string input = Console.ReadLine();
                        durum = double.TryParse(input, out saat);
                        if (durum == false)
                        {
                            Console.WriteLine("Lütfen geçerli bir sayı yazınız!");
                        }
                        else
                        {
                            if (saat > 0 && saat <= 2)
                            {
                                Console.WriteLine("Ödemeniz gereken tutar 8 tl");
                            }
                            else if (saat > 2 && saat <= 6)
                            {
                                Console.WriteLine("Ödemeniz gereken tutar 16 tl");
                            }
                            else if (saat > 6 && saat <= 12)
                            {
                                Console.WriteLine("Ödemeniz gereken tutar 32 tl");
                            }
                            else if (saat > 12 && saat <= 24)
                            {
                                Console.WriteLine("Ödemeniz gereken tutar 45 tl");
                            }
                            else if (saat > 24)
                            {
                                saat = saat / 24;
                                int sayac = 1;
                                while (sayac < saat)
                                {
                                    ödeme = ödeme + 25;
                                    sayac++;
                                }
                                Console.Write("Ödemeniz gereken tutar:{0}", ödeme + 45 + "TL");
                            }
                            menü = false;
                            break;
                        }
                    }
                }
                else if (secim == '4')
                {
                    while (TryAgain)
                    {
                        Console.WriteLine("Seçtiğiniz araç türü Kamyon ve ticari araç");
                        Console.WriteLine();
                        Console.WriteLine("Araç kaç saat boyunca park alanında kaldı? ");
                        string input = Console.ReadLine();
                        durum = double.TryParse(input, out saat);
                        if (durum == false)
                        {
                            Console.WriteLine("Lütfen geçerli bir sayı yazınız!");
                        }
                        else
                        {
                            if (saat > 0 && saat <= 2)
                            {
                                Console.WriteLine("Ödemeniz gereken tutar 15 tl");
                            }
                            else if (saat > 2 && saat <= 6)
                            {
                                Console.WriteLine("Ödemeniz gereken tutar 30 tl");
                            }
                            else if (saat > 6 && saat <= 12)
                            {
                                Console.WriteLine("Ödemeniz gereken tutar 60 tl");
                            }
                            else if (saat > 12 && saat <= 24)
                            {
                                Console.WriteLine("Ödemeniz gereken tutar 100 tl");
                            }
                            else if (saat > 24)
                            {
                                saat = saat / 24;
                                int sayac = 1;
                                while (sayac < saat)
                                {
                                    ödeme = ödeme + 55;
                                    sayac++;
                                }
                                Console.Write("Ödemeniz gereken tutar:{0}", ödeme + 100 + "TL");
                            }
                            menü = false;
                            break;
                        }
                    }
                }
            }
        }
    }
}
