// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
void GetBinary(int number)
{
    int temp  = 0;
    int counter = 0;
    string str = String.Empty;
    while (number > 0)
    {
        temp = number % 2;
        number /= 2;
        str = temp + " " + str;
    }
    Console.Write(str);
}







Console.Write("Введите десятичное число: ");
int number = int.Parse(Console.ReadLine());
GetBinary(number);      
