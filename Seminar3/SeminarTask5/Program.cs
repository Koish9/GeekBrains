﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
// от 1 до N.

void PrintSqrTab(int N)
{
    if (N<1)
    {
        Console.WriteLine("There are no valod numbers");
    
    }
    else
    {
         Console.WriteLine($"{N}-->");
         for (int i = 1; i<=N; i++)
         {
            Console.Write($"{Math.Pow(i,2)}; ");
         }
         Console.WriteLine(" ");
    }
    
}

//                 

Console.WriteLine("Please n: ");
int num = int.Parse(Console.ReadLine());
PrintSqrTab(num);