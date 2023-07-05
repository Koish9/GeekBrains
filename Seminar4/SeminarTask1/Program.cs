// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да
bool IspaLidrome(int number)
{
    if ( number < 0)
    {
        return false;
    }
    int revNumber = 0;
    int tempSourceNumber = number;
    while (tempSourceNumber != 0)
    {
        //Крайнее правая цифра исходного чила
        int temp = tempSourceNumber % 10;

        //Формируем новое число
        revNumber = (revNumber * 10) + temp;

        // Уменьшение исходного числа
        tempSourceNumber = tempSourceNumber / 10;
    } 
    if (revNumber == number)
       return true;
    return false;
}

//
Console.WriteLine(IspaLidrome(number: 100001));