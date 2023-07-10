
//Напигите программу замена элементов массива
//Положительный элемент замените на соотвествубщие отрицательные и наоборот
    
    int[] PrintArray (int[]mas)
    {
        Console.Write("Исходный массив: ");
        for (int i = 0; i < mas.Length; i++)
        {
            mas[i] = new Random().Next(-10,10);
             Console.Write(" " + mas[i]);
        }
        return mas;
    }
    
    void ChangeNum(int[ ]mas)
    {
        Console.Write("Новый массив: "+ mas);
        for (int i= 0; i < mas.Length; i++)
        {
         mas[i] *= -1;
         Console.Write(" " + mas[i]);
        }
        
    }
     
     int[] mas = new int[10];
     PrintArray (mas);
     ChangeNum (mas);