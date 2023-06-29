// Напишите программу которая принимает на вход координаты точки (Х и У) причём Х не= 0 и У не= 0 И выдаёт номер четверти полоски в которой находится эта точка
int GetAreaNumber(int x, int y)
{
    int numberArea = 0;

    if (x > 0 && y > 0)
    numberArea = 1;

    if (x < 0 && y > 0)
     numberArea = 2;

    if (x < 0 && y < 0)
    numberArea = 3;

    if (x > 0 && y < 0)
    numberArea = 4;
    
    return numberArea;
}

//------------------------------
Console.WriteLine("Введите координату X: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y: ");
int y = int.Parse(Console.ReadLine());

if (x == 0 || y == 0);
{
    Console.WriteLine("Координаты должны быть не равны 0");
}
else
{
    int result = GetAreaNumber(x, y);
    Console.WriteLine($"номер четверти вашей точки: {result}");
}