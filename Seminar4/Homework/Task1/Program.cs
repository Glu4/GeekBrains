// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
class Program
{
    static int CalculatePower(int a, int b)
    {
        int result = 1;
        for (int i = 0; i < b; i++)
        {
            result *= a;
        }
        return result;
    }


    static void Main()
    {
        Console.WriteLine("Введите число A:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Введите число B:");
        int b = int.Parse(Console.ReadLine());

        int result = CalculatePower(a, b);
        Console.WriteLine("Результат: " + result);
    }

    
}