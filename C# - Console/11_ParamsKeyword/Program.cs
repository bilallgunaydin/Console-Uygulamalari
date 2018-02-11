using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsKeyword
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Girdiğiniz 1.Sayı: {0], 2.Sayı: {1],Sayıların toplamı: {3},Sayıların çarpımı: {4}",
            //number1,number2,number1+number2,(double)(number1*number2)); ----------->>>> Console.WriteLine içerisinde istediğimiz kadar parametre gönderebileceğimiz Params komutu vardır

            int result = sum(4, 5, 55, 12, 1345, 134, 1345, 1);

        }

       //Params ile birlikte başka tipte parametreler de fonksiyon alınabilir.
       //Params ifadesi, parametre tanımlarının mutlaka sonuncusu olmalıdır.
       //Bir fonksiyonda en fazla 1 adet params kullanılabilir.
       //Params argüman(değer) almak zorunda değildir.

        static int sum(params int[] numbers)
        {
            int total = 0;
            int index = 0;
            while (index < numbers.Length)
            {
                total = total + numbers[index];
                index += 1;
            }
            return total;
        }
    }
}
