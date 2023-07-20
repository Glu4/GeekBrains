//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


{

    static double FindMaxValue(double[] arr)
    {
        double max = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    
    static double FindMinValue(double[] arr)
    {
        double min = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] < min)
            {
                min = arr[i];
            }
        }
        return min;
    }

  
        double[] numbers = { 3.22, 4.2, 1.15, 77.15, 65.2 };

        
        double maxNumber = FindMaxValue(numbers);
        double minNumber = FindMinValue(numbers);

       
        double difference = maxNumber - minNumber;

        
        Console.WriteLine($"Разница между максимальным и минимальным элементами: {difference}");
    }

