//Напишите программу, которая принимает на вход число (целое, любой размерности, до int). Программа должна получить число обратное введенному и вывести его на экран.
Console.Write("Введите число: "); 
int num = int.Parse(Console.ReadLine());

int num_length = num;
int i=0;
for (i = 0; num_length/10 != 0 ; i++)
     {Console.WriteLine(num_length = num_length/10);}
Console.WriteLine($"i= {i}");
i++;
for(int j = 0; j < i; j++ )
    