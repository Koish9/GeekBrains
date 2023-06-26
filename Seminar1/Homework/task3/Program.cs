//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
int[] array = new int[] { 1, 8, 3, 6, 5, 0, 2, 6, 4, 9 };
 
int max = int.MinValue;
foreach(int a in array)
{
    if (a > max)
    {
        max = a;
    }
}
Console.WriteLine ($"Масимальное: {max}" );