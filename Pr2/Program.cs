using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введіть три цілих числа:");

        Console.Write("Число 1: ");
        int number1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Число 2: ");
        int number2 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Число 3: ");
        int number3 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Числа, що належать інтервалу [1, 18]:");
        if (number1 >= 1 && number1 <= 18)
        {
            Console.WriteLine(number1);
        }
        if (number2 >= 1 && number2 <= 18)
        {
            Console.WriteLine(number2);
        }
        if (number3 >= 1 && number3 <= 18)
        {
            Console.WriteLine(number3);
        }

        Console.ReadLine();
    }
}
