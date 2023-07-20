// Задайте двумерный массив из целых чисел
//Определить столбец с наименьшей суммой элементов 



//Генерация двумерного массива
int[,] GetDoubleArray(int countRow, int countColum)
{
    int[,] array = new int[countRow,countColum];
    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColum; j++)
        {
            array[i,j] = new Random().Next(1,11);
        }
    }

    return array;
}
// печать двумерного массива в консоль

void PrintDoubleArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int GetMinSumColumnFromArray(int[,] array)
{
    int resultColumn = 0;
    int min = array[0, 0];
//обход строки
    for(int i = 0; i < array.GetLength(1); i++)
    {
        //обход солбца в массиве
        int tempSum = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {
            min = tempSum + array[j,i];
        }
        if (tempSum < min)
        {
            min = tempSum;
            resultColumn = i;
        }
    }



    return resultColumn;
}

int[,] array = GetDoubleArray(5,7);

PrintDoubleArray(array);
Console.WriteLine($"Номер столбца с наименьшей суммой: {GetminColumnFromArray(array)}");