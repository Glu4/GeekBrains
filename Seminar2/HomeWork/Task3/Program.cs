    // Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
    // 6 -> да
    // 7 -> да
    // 1 -> нет
    Console.WriteLine("Введите номер дня недели");
        int number = int.Parse(Console.ReadLine());
        {
            if (number >= 1 && number <= 7)
            {
                if (number > 5)
                {
                    Console.WriteLine("Выходной");
                }
                else
                {
                    Console.WriteLine("Будний день");
                }
            }
            else
            {
                Console.WriteLine("В неделе только 7 дней!");
            }
        }