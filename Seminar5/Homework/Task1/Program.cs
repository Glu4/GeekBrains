//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


        Random random = new Random();

        
        int[] numbers = new int[8];

        
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = random.Next(100, 1000); 
        }

        
        Console.WriteLine("Сгенерированный массив:");
        foreach (int num in numbers)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

       
        int countEven = 0;
        foreach (int num in numbers)
        {
            if (num % 2 == 0)
            {
                countEven++;
            }
        }

        
        Console.WriteLine("Количество четных чисел в массиве: " + countEven);