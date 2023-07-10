// Создайте массив напишите программу которая определяет присутствует ли заданное число в массиве


int Prompt (int[]mas)
    {
        Console.Write("Исходный массив: ");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = new Random().Next(-10,10);
             Console.Write(" " + mas[i]);
        }
        return mas;
    }
    bool IsNumber (int [] mas, num)
    {
        for (int i = 0; i < mas.Length; i++)
        {
            if (num == mas[i])
                    return true;
        }
        return false;
    }

int[] mas = new int[10];
FillArray(mas);
int num = Prompt("Введите число: ");
if (IsNumber (mas, num) == true)
    Console.Write("Такое число есть в массиве");
else
 Console.Write("Такое число есть в массиве нет");