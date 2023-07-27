// Даны два положительных целых числа, представленных в виде строк. Необходимо получить сумму чисел, которые представлены этими строками. Причем полученная сумма должна быть преобразована в строку.
using System;
using System.Text;

class Program
{
    static string AddStrings(string num1, string num2)
    {
        int n1 = num1.Length - 1;
        int n2 = num2.Length - 1;
        int carry = 0;
        StringBuilder result = new StringBuilder();

        while (n1 >= 0 || n2 >= 0 || carry > 0)
        {
            int digit1 = n1 >= 0 ? num1[n1] - '0' : 0;
            int digit2 = n2 >= 0 ? num2[n2] - '0' : 0;
            int sum = digit1 + digit2 + carry;
            int remainder = sum % 10;
            carry = sum / 10;

            result.Insert(0, remainder);
            n1--;
            n2--;
        }

        return result.ToString();
    }

    static void Main(string[] args)
    {
        string num1 = "11";
        string num2 = "123";
        string result = AddStrings(num1, num2);
        Console.WriteLine(result);

        num1 = "456";
        num2 = "77";
        result = AddStrings(num1, num2);
        Console.WriteLine(result);

        num1 = "0";
        num2 = "0";
        result = AddStrings(num1, num2);
        Console.WriteLine(result);
    }
}