// Напишите программу, которая выводит случаное число из отрезка (10, 99)

int randomNumber = new Random().Next(10, 100);
Console.WriteLine($"Случайное число: {randomNumber}");

int firstDigit = randomNumber / 10;
int secondDigit = randomNumber % 10;

 if (firstDigit > secondDigit)
 {
    Console.WriteLine($"наибольшее чесло: {firstDigit}");
 }
  else
{
    Console.WriteLine($"наибольшее чесло: {secondDigit}");
}