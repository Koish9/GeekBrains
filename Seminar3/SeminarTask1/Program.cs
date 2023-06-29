// [Возвращаемый тип] [имя метод - глагол] ([Параметры  метода])
//{
  //  Код метода
//}
int GetSum(int a, int b)
{
    int sum = a + b;
    return sum;
}

void PrintMassage(string message)
{
    Console.WriteLine(message);
}

//-------------------------------------------------
PrintMassage("Начало работы");

int num1 = 10;
int num2 = 2;
int mySum = GetSum(num1, num2);
PrintMassage(mySum.ToString());