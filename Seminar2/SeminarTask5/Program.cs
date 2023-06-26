// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
Console.Write("Введите два числа: ");
int num_1 = int.Parse(Console.ReadLine());
int num_2 = int.Parse(Console.ReadLine());

if (num_1 / num_2 == num_2)
   Console.Write("Первое число является квадратом второго");
else
   Console.Write("Первое число не является квадратом второго");

   