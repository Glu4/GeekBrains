            // Даны два положительных целых числа, представленных в виде строк. Необходимо получить сумму чисел, которые представлены этими строками. Причем полученная сумма должна быть преобразована в строку.
            // Для решения этой задачи запрещено преобразовывать входные строки сразу напрямую в целое число при помощи встроенной функции. Необходимо сделать это самостоятельно.

            // Пример 1:
            // Входные значения: num1 = "11", num2 = "123"
            // Результат: "134"

            // Пример 2:
            // Входные значения: num1="456", num2 = "77"
            // Результат: "533"

            // Пример 3:
            // Входные значения: num1 = "0", num2 = "0"
            // Результат: "0"


        {
            Console.WriteLine("Введите первое число:");
            string num1 = (Console.ReadLine());
            Console.WriteLine("Введите второе число:");
            string num2 = (Console.ReadLine());
            
            
            Console.WriteLine("Результат: " + AddStrings(num1, num2));
        }


        static string AddStrings(string num1, string num2)
        {
            int i = num1.Length - 1;
            int j = num2.Length - 1;
            int carry = 0;
            string result = "";

            while (i >= 0 || j >= 0 || carry > 0)
            {
                int digit1 = i >= 0 ? num1[i] - '0' : 0;
                int digit2 = j >= 0 ? num2[j] - '0' : 0;

                int sum = digit1 + digit2 + carry;
                carry = sum / 10;
                result = (sum % 10).ToString() + result;

                i--;
                j--;
            }

            return result;
        }