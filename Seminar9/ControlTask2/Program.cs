﻿        //         Дан одномерный массив целых однозначных чисел (элемент массива содержит число от 1 до 9).
        // Ваша задача вывести на экран число, которое формируется элементами массива слева-направо + 1.

        // Пример 1:
        // Исходный массив: [1, 2, 1, 1, 4]
        // Результат: 12115 (целое число).
        // Объяснение: если мы пройдем по элементам массива слева-направо, то последовательность элементов представляет из себя число 12004. Дальше мы плюсуем к этому числу 1 и получаем 12115
        
        {
            int[] array1 = { 1, 9, 4, 5, 5 };
        

            
            Console.WriteLine("Исходный массив: " + string.Join(", ", array1));
            int result1 = NumberAddOne(array1);
            Console.WriteLine("Результат: " + result1);

        }

        static int NumberAddOne(int[] nums)
        {
            int result = 0;

            foreach (int num in nums)
            {
                result = result * 10 + num;
            }

            return result + 1;
        }