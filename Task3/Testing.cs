using System;
using PlariumTasks;

namespace Tests
{
    class Testing
    {
        static void Main(string[] args)
        {
            // Task 3.1.1
            var array = new int[] { 1, 2, 3, 4, 5, 6, 7 };
            Task3.Reverse(array);
            Console.WriteLine(string.Join(", ", array));
            Task3.Reversev2(array);
            Console.WriteLine(string.Join(", ", array));

            // Task 3.1.2
            Console.WriteLine(Task3.FindQuantityUnicElemnts(array)); // 7
            array = new int[] { 1, 1, 2, 2, 3, 3, 4, 4, 5 };
            Console.WriteLine(Task3.FindQuantityUnicElemnts(array)); // 1

            // Task 3.1.3
            array = new int[] { 2, 2, 2, 7, 7, 7 }; // четное количество
            Task3.ChangeArray(array);
            Console.WriteLine(string.Join(", ", array));
            array = new int[] { 2, 2, 2, 7, 7, 7, 7 }; // нечетное количество
            Task3.ChangeArray(array);
            Console.WriteLine(string.Join(", ", array));

            // Task 3.2
            var matrix = new int[,] { { 1, 2, 3, 4 },
                                      { 0, 6, 0, 8 },
                                      { 9, 10, 10, 10  } };
            int x;

            Task3.CountColumsWithZeros(matrix, out x); 
            Console.WriteLine(x); // 2
            Task3.FindTheLongestRow(matrix, out x);
            Console.WriteLine(x); // 2
            // если в рядах матрицы нет повторяющихся чисел
            matrix = new int[,] { { 1, 2, 3, 4 },
                                  { 5, 6, 7, 8 },
                                  { 9, 10, 11, 12  } };
            Task3.FindTheLongestRow(matrix, out x);
            Console.WriteLine(x); // -1
        }
    }
}
