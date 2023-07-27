// Дан одномерный массив целых однозначных чисел (элемент массива содержит число от 1 до 9).
//Ваша задача вывести на экран число, которое формируется элементами массива слева-направо + 1.
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 1, 2, 1, 1, 5 }; // Исходный массив

        int number = 0;

        foreach (int digit in array)
        {
            number = number * 10 + digit; // Формируем число из элементов массива
        }

        number += 1; // Прибавляем 1 к числу

        Console.WriteLine(number); // Выводим результат
    }
}


