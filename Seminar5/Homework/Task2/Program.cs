//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0


     {   Random random = new Random();

        
        int[] array = new int[8];

        
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(100, 1000); 
        }

    
        Console.WriteLine("Исходный массив:");
        PrintArray(array);

       
        int arraysum = Calculatearraysum(array);

        Console.WriteLine($"Сумма элементов на нечётных позициях: {arraysum}");
    }

    
    static void PrintArray(int[] arr)
    {
        Console.WriteLine("[" + string.Join(", ", arr) + "]");
    }

   
    static int Calculatearraysum(int[] arr)
    {
        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 != 0)
            {
                sum += arr[i];
            }
        }
        return sum;
    }