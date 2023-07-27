    // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
       
       
        int[,] array = new int[,]
        {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        
        Console.Write("Введите индекс строки: ");
        int rowIndex = int.Parse(Console.ReadLine());

        Console.Write("Введите индекс столбца: ");
        int colIndex = int.Parse(Console.ReadLine());

        
        if (rowIndex >= 0 && rowIndex < array.GetLength(0) && colIndex >= 0 && colIndex < array.GetLength(1))
        {
           
            int value = array[rowIndex, colIndex];
            Console.WriteLine($"Значение элемента: {value}");
        }
        else
        {
            Console.WriteLine("Неверные координаты элемента. Проверьте ввод.");
        }