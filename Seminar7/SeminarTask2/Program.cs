// Зайдайте думерныймассив Найдите жлементы у которых оба индекса чёиеые и щамените эти жлементы на их квадраты 
Console.WriteLine("Введите кол-во строк: ");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите кол-во столбцов: ");
int column = int.Parse(Console.ReadLine());
int[,] array = new int[row, column];
SetArray(array);
Console.WriteLine("Сгенерированный массив");
GetArray(array);
DoubleOddArray(array);
Console.WriteLine("Изменённый массив");
GetArray(array);



int[,] SetArray(int[,] array)
{
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        array[i,j] = new Random().Next(0,11);
    }
}
return array;
}

void GetArray(int[,] array)
{
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
}

int[,] DoubleOddArray(int[,] array)
{
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < column; j++)
    {
        if (i % 2 == 0 && j % 2 == 0) array[i, j] * array[i, j];
    }
}
return array;
}