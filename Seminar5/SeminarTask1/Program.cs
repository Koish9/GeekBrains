// Задайте массив из 12 элементов Заполните случайными числами из промежутка (-9 9 )
// найдите сумму отрицательных и положительных элементов массива


int[] array = new int[12];

// заполнение массива 
for (int i = 0; i< array.Length; i++)
{
    array [i] = new Random().Next(-9,10);
}



//Подсчёт суммы отрицательных и положительных элементов

int sumPositive = 0;
int sumNegative = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        sumPositive = sumPositive + array [i];
    if (array[i] < 0)
        sumNegative = sumNegative + array[i];
}
Console.WriteLine ($"Сумма пол чисел: {sumPositive}" +
                   $"\n Сумма отрицательных чисел: {sumNegative}");