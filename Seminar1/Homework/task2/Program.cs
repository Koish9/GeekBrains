// Напишите прогшрамму которая принимает на вход число (>0) и выводит все числа от 1 до этого числа
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int evenNumber = 2;

if(number > 1)
{
    while(evenNumber <= number)
    {
        Console.Write(evenNumber + ", ");
        evenNumber = evenNumber + 2;
    }
}
