using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondColl
{
    internal class Functions
    {


       



        public int[] createRandomArray(int n, int a, int b)
        {
            Random rnd = new Random();
            int[] newArray = new int[n];

            for (int i = 0; i < n; i++)
            {
                newArray[i] = rnd.Next(a, b + 1); // Генерация случайного числа в диапазоне от a до b
            }

            return newArray;
        }

        public int[] createArrayFromString(string str)
        {

            string[] numbers = str.Split(','); // Разделяем строку на массив строк по пробелу

            int[] array = new int[numbers.Length];

            for (int i = 0; i < numbers.Length; i++)
            {
                if (int.TryParse(numbers[i], out int number))
                {
                    array[i] = number;
                }
                else
                {
                    // Если не удалось преобразовать строку в число, можно принять какое-то значение по умолчанию или обработать ошибку
                    Console.WriteLine($"Ошибка преобразования числа: {numbers[i]}");
                }
            }

            return array;
        }
    }
}
