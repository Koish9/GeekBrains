//Напишите программу, которая принимает на вход число N и выдает набор произведений чисел от 1 до N.
int Request (string massage)
{
    Console.WriteLine(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}
int Factorial (int number)
{
    if (number <= 0) return -1;

    int j = 1;
    for (int i=1; i <= number; i++)
    {
        j *=i;
    } 
    return j;
}

int number = Request("Введите число");
Console.Write(Factorial(number));