    //Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
     Console.Write("Введите число a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введите число b: ");
        int b = int.Parse(Console.ReadLine());

    Console.Write("Введите число c: ");
        int c = int.Parse(Console.ReadLine());

        int max = a;

    if (b > a)
        {max=b;
        }
   
         
    if (c > max)
        {max = c;
        }

    if (c > a)
        {max = c;
        }    

    
        {Console.WriteLine($"{max} самое большое число.");
        }