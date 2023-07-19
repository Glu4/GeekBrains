// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

class Program
{

        static int CalculateDigit(int num)
    {
        int sum = 0;
        while (num != 0)
        {
            int digit = num % 10; // Получаем последнюю цифру числа
            sum += digit; // Добавляем цифру к сумме
            num /= 10; // Убираем последнюю цифру числа
        }
        return sum;
    }

    static void Main()
    {
        Console.WriteLine("Введите число:");
        int number = int.Parse(Console.ReadLine());

        int sum = CalculateDigit(number);
        Console.WriteLine("Сумма цифр числа: " + sum);
    }


}