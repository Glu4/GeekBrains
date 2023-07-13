// See https://aka.ms/new-console-template for more information

class Program
{
    static bool IsPalindrome(int number)
    {
        int temp = number;
        int reversedNumber = 0;

        while (temp != 0)
        {
            int remainder = temp % 10;
            reversedNumber = reversedNumber * 10 + remainder;
            temp /= 10;
        }

        return reversedNumber == number;
    }

    static void Main()
    {
        Console.Write("Введите пятизначное число: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 10000 || number > 99999)
        {
            Console.WriteLine("Введено неверное число.");
            return;
        }

        if (IsPalindrome(number))
        {
            Console.WriteLine("Да, число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Нет, число не является палиндромом.");
        }
    }
}