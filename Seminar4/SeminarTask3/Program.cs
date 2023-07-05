// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

{
  Console.Write("Введите число : ");
  int num=int.Parse(Console.ReadLine());
  int i=0;
  while(num>0) {
   i++;
   num/=10;
  }
  Console.WriteLine("Количество цифр введенного числа : {0}", i);
  Console.ReadKey();
  return 0;
 }
