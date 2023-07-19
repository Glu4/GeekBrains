// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]


class Program
{
    static void Main()
    {
       
        Random random = new Random();

        
        int[] arr = new int[8];

        
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(1, 100); 
        }
        
        Console.Write("[");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);

            
            if (i < arr.Length - 1)
            {
                Console.Write(", ");
            }
        }
        Console.WriteLine("]");
    }
}