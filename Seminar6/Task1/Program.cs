    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числа (для завершения введите '0'):");

            int[] numbers = new int[100]; // Предполагаем, что пользователь не введет больше 100 чисел
            int count = 0;

            // Читаем числа из ввода и сохраняем в массив до тех пор, пока не введем 0 или не достигнем максимального размера массива (100)
            for (int i = 0; i < 100; i++)
            {
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    break; // Если пользователь ввел 0, прекращаем ввод чисел
                }

                numbers[i] = number;
                count++;
            }

            int countPositive = 0;

            // Подсчет количества положительных чисел в массиве
            for (int i = 0; i < count; i++)
            {
                if (numbers[i] > 0)
                {
                    countPositive++;
                }
            }

            Console.WriteLine("Количество чисел больше 0: " + countPositive);
        }
    }