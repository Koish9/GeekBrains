// Напишите программу, которая будет принимать на вход два числа и выводить, Являеися ли второе число кратным первому. Если число 2 не кратно числу 1 , то программа выводит остаток
Console.Write("Введите два числа");
int num_1 = int.Parse(Console.ReadLine());
int num_2 = int.Parse(Console.ReadLine());
if (num_1 % num_2 == 0)
  Console.Write("Кратно");
  else 
  Console.Write($"Остаток от деления = {num_1 % num_2}");