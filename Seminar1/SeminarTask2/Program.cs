//Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго
Console.WriteLine("введите два числа");
int a, b;

a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());

if (a == b * b)
{
    Console.WriteLine("да");
}
else {Console.WriteLine("нет");}