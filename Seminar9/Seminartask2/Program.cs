// Напишите программу которая на вход принимает два числа а и в и возводит а в целую степень в с помощью рекурсии


int Request(string massage)
{
    Console.Write(massage);
    int result = int.Parse(Console.ReadLine());
    return result;
}

int Pow(int A, int B)
{
    if(B == 1) return A;
    int C = Pow(A,B-1)*A;
    return C;
}

int numberA = Request("Число A: ");
int numberB = Request("число B: ");

Pow(numberA,numberB);
Console.WriteLine(Pow(numberA,numberB));
