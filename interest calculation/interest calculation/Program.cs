using System;

namespace Question2360271
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму вклада");
            double sum = Convert.ToDouble(Console.ReadLine());
            // int x = int.Parse(Console.ReadLine());

            if (sum < 10000)
            {
                sum += sum * 0.2;
            }
            else if (sum <= 100000)
            {
                sum += sum * 0.15;
            }
            else
            {
                sum += sum * 0.1;
            }
            Console.WriteLine($"Сумма клада после начисления процентов: {sum}");
        }

    }
}


