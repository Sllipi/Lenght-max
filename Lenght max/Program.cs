using System;

namespace Lenght_max
{
    class Program
    {
        static void Main(string[] args)
        {
            byte lengght = 30, count = 0, num = 0, nam = 0, randMax = 5;
            byte[] array = new byte[lengght];
            Random rand = new Random();
            for (byte i = 0; i < array.Length; i++)
            {
                Console.Write ($"{array[i] = (byte)rand.Next(randMax)} ");
            }
            for (byte i = 0; i < 20; i++)
            {
                for (byte j = 0; j < array.Length; j++)
                {
                    if (i == array[j])
                    {
                        count++;
                        if (nam < count)
                        {
                            nam = count;
                            num = i;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }
            }
            Console.WriteLine($"\nЧисло = {num}, Повторений {nam}");
        }
    }
}
/*В массиве чисел найдите самый длинный подмассив из одинаковых чисел.
Дано 30 чисел. Вывести в консоль сам массив, число, которое само больше раз повторяется подряд и количество повторений.
Дополнительный массив не надо создавать.
Пример: {5, 5, 9, 9, 9, 5, 5} - число 9 повторяется большее число раз подряд.*/