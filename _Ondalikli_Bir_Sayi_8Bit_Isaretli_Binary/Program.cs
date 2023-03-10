using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _Ondalikli_Bir_Sayi_8Bit_Isaretli_Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ondalıklı olarak 8 bitlik ve işaretli (+ ya da -) bir sayının binary sistemde çıktısını veren uygulama 

            float number;
            float remainder, numberFirst = 0, numberLast = 0;
            string result = "";
            string fullNumber = string.Empty;
            bool isNegative;
            bool isDecimal = false;
            Console.WriteLine("Sayı Giriniz: ");
            number = float.Parse(Console.ReadLine());
            if (number.ToString().Contains(","))
            {
                numberFirst = int.Parse(number.ToString().Split('.').First());
                numberLast = int.Parse(number.ToString().Split('.').Last());
                isDecimal = true;
            }

            isNegative = number < 0;
            number = isNegative ? (number * (-1)) : number;

            if (isDecimal)
            {
                float[] numbers = { numberFirst, numberLast };
                for (int i = 0; i <= 1; i++)
                {
                    number = numbers[i];
                    while (number >= 2)
                    {
                        remainder = number % 2;
                        result = result.Insert(0, remainder.ToString());
                        number /= 2;
                    }
                    result = result.Insert(0, number.ToString());
                    result = result.PadLeft(8, '0');
                    if (number == numbers[1])
                        result = result.Insert(0, (isNegative ? "1" : "0"));

                    fullNumber += result;
                    Console.WriteLine("Sonuc: " + fullNumber);
                }

            }
            else
            {
                while (number >= 2)
                {
                    remainder = number % 2;
                    result = result.Insert(0, remainder.ToString());
                    number /= 2;
                }
                result = result.Insert(0, number.ToString());
                result = result.PadLeft(7, '0');
                result = result.Insert(0, (isNegative ? "1" : "0"));
                Console.WriteLine("Sonuc: " + result);
            }

            Console.ReadLine();


        }
    }
}
