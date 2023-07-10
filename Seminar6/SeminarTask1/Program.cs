// Задайте массив вещественных чисел Найдите разницу между максимальным и минимальным элементов массива

// получение массива вещественных чисел

double[] GetRandomDoubleArray(int size)
{
    double[] array = new double[size];
    for (int i=0; i < array.Length; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() * new Random().Next(1,11), 2);
    }

    return array;
}

//вывод массива в консоль
void PrintDoubleArrayToConsole(double[] array)
{
     string str= string.Join(' ', array);
    Console.Write($"Массив: {str}");
    
}

//     

double[] array = GetRandomDoubleArray(size: 10);
PrintDoubleArrayToConsole(array);

double max = array.Max();
double min = array.Min();


Console.WriteLine($"Разница между макс: {max} и мин: {min} элементом {max-min}");