// Создайте двумерный массив размером М на Н Заполненный случайными целыми

Console.WriteLine("Введите кол-во строк: ");
int countRow = int.Parse(Console.ReadLine());

Console.WriteLine("Введите кол-во столбцов: ");
int countColumn = int.Parse(Console.ReadLine());

int[,] array = new int[countRow , countColumn];

//Заполнение массива случайными числами(посстрочно)
for (int i = 0; i < countRow; i++)// двигается по строкам
{
    for (int h = 0; h < countColumn; h++); // двигается по столбцам
    {
        array[i, h] = new Random().Next(1,11);
    }
}

//Вывод массива в консоль
for (int i = 0; i < countRow; i++)
{
    for (int h = 0; h < countColumn; h++);
    {
        Console.Write(array[i, h] + " ");
    }
    Console.WriteLine();
}


for (int i = 0; i < countRow; i++)
{
    int sum = 0;
    for(int h = 0; h < countColumn; h++)
    {
        sum = sum + array[i, h];
    }
    Console.WriteLine($"В строке [{i}] Сумма элементов равна: {sum}");
}