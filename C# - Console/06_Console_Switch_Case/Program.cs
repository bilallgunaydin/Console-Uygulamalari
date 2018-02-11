using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Console_Switch_Case
{
    class Program
    {
        static void Main(string[] args)
        {
            //Switch-Case
            /*
             *switch(değişken) 
             * {
             * case durum:
             * //
             * işlemler
             * break;
             * case durum2;
             * //işlemler
             * break;
             * ...
             * default:
             * //işlemler
             * }
             * 
             * 
             * 
             */
            //Kullanıcının girdiği 1-7 arasındaki değere göre haftanın mevcut gün karşılığını veren programı yazın.

            //Console.WriteLine("1 ile 7 arasında bir sayı giriniz:");
            //int gun = int.Parse(Console.ReadLine());
            //switch (gun)
            //{
            //    case 1:
            //        Console.WriteLine("Pazartesi");
            //        break;
            //    case 2:
            //        Console.WriteLine("Salı");
            //        break;
            //    case 3:
            //        Console.WriteLine("Çarşamba");
            //        break;
            //    case 4:
            //        Console.WriteLine("Perşembe");
            //        break;
            //    case 5:
            //        Console.WriteLine("Cuma");
            //        break;
            //    case 6:
            //        Console.WriteLine("Cumartesi");
            //        break;
            //    case 7:
            //        Console.WriteLine("Pazar");
            //        break;

            //    default:
            //        Console.WriteLine("Hatalı değer girdiniz");
            //        break;
                    
            
            //}
            //Console.Read();
            

            //Kullanıcıya kaçınca ayda olduğunu sorarak hangi mevsimde bulunduğunu gösteren kodu yazınız.
            Console.WriteLine("Kaçıncı aydasınız?");
            int ay = int.Parse(Console.ReadLine());

            switch (ay)
            {
                case 12:
                    Console.WriteLine("kış");
                    break;
                case 1:
                    Console.WriteLine("Kış");
                    break;
                case 2:
                    Console.WriteLine("Kış");
                    break;
               case 3:
                    Console.WriteLine("İlkbahar");
                    break;
                case 4:
                    Console.WriteLine("İlkbahar");
                    break;
                case 5:
                    Console.WriteLine("İlkbahar");
                    break;
                case 6:
                    Console.WriteLine("yaz");
                    break;
                case 7:
                    Console.WriteLine("yaz");
                    break;
                case 8:
                    Console.WriteLine("yaz");
                    break;
                case 9:
                    Console.WriteLine("sonbahar");
                    break;
                case 10:
                    Console.WriteLine("sonbahar");
                    break;
                case 11:
                    Console.WriteLine("sonbahar");
                    break;
                    
                default:
                    Console.WriteLine("Yanlış girdiniz");
                    break;
                   
            }
            Console.Read();

            //---------ALTERNATİF-------------
            //Console.WriteLine("Kaçıncı aydasınız?");
            //int ay = int.Parse(Console.ReadLine());

            //switch (ay)
            //{
            //    case 12:
            //    case 1:
            //    case 2:
            //        Console.WriteLine("Kış");
            //        break;
            //    case 3:
            //    case 4:
            //    case 5:
            //        Console.WriteLine("İlkbahar");
            //        break;
            //    case 6:
            //    case 7:
            //    case 8:
            //        Console.WriteLine("yaz");
            //        break;
            //    case 9:
            //    case 10:
            //    case 11:
            //        Console.WriteLine("sonbahar");
            //        break;

            //    default:
            //        Console.WriteLine("Yanlış girdiniz");
            //        break;

            //}
            //Console.Read();
            }
       
        }
    }

