// Выполнить бинарный поиск в массиве


internal class Program
{
    private static void Main(string[] args)
    {
        int Request(string massage)
        {
            Console.WriteLine(massage);
            int result = int.Parse(Console.ReadLine());
            return result;
        }

        int[] Array()
        {
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(-10, 11);
                Console.Write($"{array[i]}");
            }
            Console.WriteLine(" ");
            return array;
        }

        bool poisk(int[] array, int number)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == number) return true;
            }
            return false;
        }

        bool poiskbin(int[] array, int number)
        {
            for (int i = array.Length; i = 0; i++)
            {
                for (int i = 0; i < array.Length; i++)
            }
        }

        int[] array = Array();
    }
}