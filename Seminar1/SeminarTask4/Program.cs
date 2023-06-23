
Console.WriteLine("введите трехзначное число");
int a,b;
a = int.Parse(Console.ReadLine());

b = a % 10;

Console.WriteLine($"последняя цифра числа =  {b}");