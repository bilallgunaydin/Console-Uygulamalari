using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Console_RefParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Belirsiz miktarda sayı okuma algoritması
            //int[] numbers = new int[0];

            //while (true)
            //{
            //    Console.Write("Lütfen yeni sayıyı yazınız: ");
            //    string input = Console.ReadLine();

            //    if (input == "end")
            //        break;

            //    int number = int.Parse(input);

            //    int newSize = numbers.Length + 1;

            //    Array.Resize(ref numbers, newSize);

            //    numbers[numbers.Length - 1] = number;
            //}


            //Console.WriteLine("Dizideki elemanlar:");
            //int index = 0;
            //while (index < numbers.Length)
            //{
            //    Console.WriteLine(numbers[index]);

            //    index++;
            //} 
            #endregion

            string name = "Tsubasa";

            ChangeName(ref name, "Ishizaki");


            Console.ReadLine();
        }

        static void ChangeItem(string[] array, int index, string newItem)
        {
            if (index < array.Length)
            {
                array[index] = newItem;
            }
        }

        static void ResizeArray(ref string[] names, int newSize)
        {
            string[] newArray = new string[newSize];

            int index = 0;
            while (index < newArray.Length && index < names.Length)
            {
                newArray[index] = names[index];

                index++;
            }

            names = newArray;


            /*
             * names dizisi 1 elemanlıydı
             * newsize argümanı 4 olarak gönderildi
             * newArray = string[5];
             * newArray[0] = names[0]
             * newArray[1] = names[1]
             * newArray[2] = names[2]
             * newArray[3] = names[3]
             * names = newArray
             * 
             */

        }

        static void ResetArray(string[] array)
        {
            array = null;
        }

        static void ChangeName(ref string oldName, string newName)
        {
            oldName = newName;
        }

        static void ChangeCharacter(char[] value, int index, char newChar)
        {
            value[index] = newChar;
        }

        static void SquareOf(ref int number)
        {
            number = number * number;
        }

    }
}