// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int Prompt(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}
bool IsTriangle(int num1, int num2, int num3)
{
    if (num1 < (num2 + num3) && num2 < (num1 + num3) && num3 <(num1 + num2))
        return true;
    return false;    
}
int num1 = Prompt("Ведите первое число: ");
int num2 = Prompt("Ведите Второе число: ");
int num3 = Prompt("Ведите Третье число: ");
if  (IsTriangle(num1, num2, num3))
    Console.Write("Треугольник возможен");
else 
    Console.Write("Треугольник не возможен");