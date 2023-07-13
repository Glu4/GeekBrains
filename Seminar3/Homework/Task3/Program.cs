//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
    class Program
    {
        static void PrintCube(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                int cube = i * i * i;
                Console.WriteLine(cube);
            }
        }
    
    
    static void Main(string[] args)
        {
            Console.WriteLine("Введите число N:");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Таблица кубов чисел от 1 до " + n + ":");
            PrintCube(n);
        }
    }    

        
    
