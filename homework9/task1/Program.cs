// Дан одномерный массив целых чисел, элементом которого, может быть либо 1, либо 0.
//Ваша задача вывести на экран максимальное количество следующих друг за другом 1.
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 0, 1, 1, 1, 1, 1, 1, 0, 1 };  // Пример массива

        int maxOnes = 0;  // Переменная для хранения максимального количества единиц
        int currentOnes = 0;  // Переменная для хранения текущего количества единиц

        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == 1)
            {
                currentOnes++;
                if (currentOnes > maxOnes)
                {
                    maxOnes = currentOnes;
                }
            }
            else
            {
                currentOnes = 0;
            }
        }

        Console.WriteLine("Максимальное количество следующих друг за другом 1: " + maxOnes);
    }
}