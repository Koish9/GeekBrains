// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

//A (3,6); B (2,1) -> 5,09 
//A (7,-5); B (1,-1) -> 7,21

double CalcDist(int x1, int y1, int x2, int y2)
{
double distance = 0;
distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
return distance;
}
Console.Write("Введите координаты Х1:");
int x1 = int.Parse(Console.ReadLine());

Console.Write("ВВедите координаты У1: ");
int y1=int.Parse(Console.ReadLine());

Console.Write("Введите координаты Х2:");
int x2 = int.Parse(Console.ReadLine());

Console.Write("ВВедите координаты У2: ");
int y2=int.Parse(Console.ReadLine());

Console.WriteLine($"Расстояние между точками  A u B = {CalcDist(x1,x2,y1,y2)} ");

