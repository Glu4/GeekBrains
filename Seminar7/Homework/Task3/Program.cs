     // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

        int[,] array = new int[,]
        {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

       
        int m = array.GetLength(0);
        int n = array.GetLength(1);

    
        double[] columnAverages = new double[n];


        for (int j = 0; j < n; j++)
        {
            double sum = 0;
            for (int i = 0; i < m; i++)
            {
                sum += array[i, j];
            }
            columnAverages[j] = sum / m;
        }

        Console.Write("Среднее арифметическое каждого столбца: ");
        for (int j = 0; j < n; j++)
        {
            Console.Write(columnAverages[j]);
            if (j < n - 1)
            {
                Console.Write("; ");
            }
        }