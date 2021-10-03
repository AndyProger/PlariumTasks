using System;
using PlariumTasks;

namespace Tests
{
    class Testing
    {
        static void Main(string[] args)
        {
            // Task 1.1
            Console.WriteLine(Task1.FindProduct(14, 5, -3, 6, -1));
            Console.WriteLine(Task1.FindProduct(5, 7, 9, 7, 21, 8, -9, 1, 1, 1));
            // вернет -1, так как среди чисел, нет подходящих
            Console.WriteLine(Task1.FindProduct(1, 1, 1, 1, 1));

            // Task 1.2
            Console.WriteLine(string.Join(", ", Task1.IncreaseAmount(1000m, 2.0m)));
            Console.WriteLine(string.Join(", ", Task1.DepositAmount(1000m, 2.0m)));
        }
    }
}
