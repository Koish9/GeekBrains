// Не используя рекурсию выведите первые н чисел фибоначчи первые два числа фибоначчи 0 и 1

void GetFibonacci()
{
    int F = 0;
    Console.Write("Введите десятичное число: ");
    int N = int.Parse(Console.ReadLine());
    for(int i = 1; i <= N; i+= F)
    {
        F = (i - F);
        Console.Write(" " + F); 
    }
}
GetFibonacci();
