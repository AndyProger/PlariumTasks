using System;
using PlariumTasks;

namespace Tests
{
    class Testing
    {
        static void Main(string[] args)
        {
            // Task 2.1
            Console.WriteLine(string.Join(", ", Task2.FindNumbers(27)));
            Console.WriteLine(string.Join(", ", Task2.FindNumbers(1)));
            Console.WriteLine(string.Join(", ", Task2.FindNumbers(5)));

            // Task 2.2.1
            Console.WriteLine(Task2.HaveSuchDigits(123456, 3, 6)); // true
            Console.WriteLine(Task2.HaveSuchDigits(123456, 0, 6)); // false

            // Task 2.2.2
            Console.WriteLine(Task2.ReverseNumber(654321));

            // Task 2.2.3
            int number = 12345;
            Task2.RemoveDigits(ref number, 2, 3, 4, 5);
            Console.WriteLine(number);
        }
    }
}
