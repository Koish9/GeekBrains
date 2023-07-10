// Задайте одномерный массив из 123 случайных чисел
//найдите кол жлементов массива значения которыз лежат в отрезке(10 99)
 int[] FillArray (int[]mas)
    {
        Console.Write("Исходный массив: ");
        for (int i = 0; i < mas.Length; i++)
        {
                    mas[i] = new Random().Next(0,150);
             Console.Write(" " + mas[i]);
        }
        return mas;
    }
void FindCount (int[] mas)
{
    int count = 0;
    for (int i = 0; i < mas.Length; i++)
        {
            if (mas[i] > 9 && mas[i] < 100)
                count++;
        }
        Console.Write("Количество элементов массива, значения которых лежат в отрезке [10 99]");
}
int[] mas = new int [8];
FillArray (mas);