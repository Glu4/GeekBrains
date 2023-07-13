//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да


class Program
{
    static bool Palindrome(int number)
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

        if (Palindrome(number))
        {
            Console.WriteLine("Да, число является палиндромом.");
        }
        else
        {
            Console.WriteLine("Нет, число не является палиндромом.");
        }
    }
}