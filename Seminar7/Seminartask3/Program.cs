internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите кол-во строк: ");
        int row = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите кол-во столбцов: ");
        int column = int.Parse(Console.ReadLine());
        int[,] array = new int[row, column];
        SetArray(array);
        Console.WriteLine("Сгенерированный массив");
        GetArray(array);
        Console.WriteLine($"Сумма элементов диагонали ровна {DoubleIJArray(array)}");




        int[,] SetArray(int[,] array)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    array[i, j] = new Random().Next(0, 11);
                }
            }
            return array;
        }

        void GetArray(int[,] array)
        {
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    Console.Write(array[i, j] + "   ");
                }
                Console.WriteLine();
            }
        }

        int[,] DoubleIJArray(int[,] array)
        {
            int sum = 0;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    if (i == j) sum += array[i, j];
                }
            }
            return sum;
        }
    }
}