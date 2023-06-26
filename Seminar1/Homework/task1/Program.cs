// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
int a,b,max,min;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
max = a;
min = b;
if (b > a)
    max = b;
    min = a;
Console.WriteLine($"Максимальное число = {max}");
Console.WriteLine($"Минимальное число = {min}");