using System;

namespace The_absolute_difference
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите любое число: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (n > 48)
                Console.WriteLine("Ответ: " + (n - 123) * 3);
            else
                Console.WriteLine("Ответ: " + Math.Abs(n - 123));
        }
    }
}
