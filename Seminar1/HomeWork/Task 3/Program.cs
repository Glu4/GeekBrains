// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
     Console.Write("Введите число: ");
        int a = int.Parse(Console.ReadLine());

    if (a % 2 == 0)
        {Console.WriteLine("Чётное");
        }

    else 
    {Console.WriteLine("Не чётное");}