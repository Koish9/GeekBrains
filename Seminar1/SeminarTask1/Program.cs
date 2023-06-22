//Напишите программу, которая на вход принимает число
// и выдаёт его квадрат (число умноженное на само себя)

//Исходное число
Console.Write("Введите число: " );
int numberA = int.Parse(Console.ReadLine());

if (numberA <= 10){
    Console.WriteLine("Ваше число меньше 10-ти");
}
else
{
//Результат: квадрата исходного числа
int numberB =numberA * numberA;

//Вывод результата
Console.WriteLine($"Квадрат вашего числа = {numberB}");
}
Console.WriteLine("Конец программы");