        //Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
        //645 -> 5
        //78 -> третьей цифры нет
        //32679 -> 6
        Console.Write("Введите число: ");
        int number = int.Parse(Console.ReadLine());
        
        
        {    if (number < 99)
        {
            Console.WriteLine("В числе нет третьей цифры");
        return;
            }}
           
        string numberString = number.ToString(); 
        
        char thirdChar = numberString[2]; 
        int thirdDigit = int.Parse(thirdChar.ToString()); 

        Console.WriteLine($"Третья цифра: {thirdDigit}"); 


        