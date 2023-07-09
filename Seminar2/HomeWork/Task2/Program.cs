        //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        //645 -> 5
        //78 -> третьей цифры нет
        //32679 -> 6
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        while(true)
        {

        
            if (number < 99)
    
       

        Console.WriteLine("В числе нет третьей цифры");
        
         
        {
            break;
        }
            
        }


        int thirdDigit = number % 10;

        if (thirdDigit != 0)
        {
            Console.WriteLine($"Третья цифра числа: {thirdDigit}");
            }

        