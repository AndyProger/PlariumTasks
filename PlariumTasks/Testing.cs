using System;
using PlariumTasks;

namespace Tests
{
    class Testing
    {
        static void Main(string[] args)
        {
            var matrix = new int[,] { { 1, 2, 3, 4 },
                                      { 0, 6, 0, 8 },
                                      { 9, 10, 10, 10  } };
            int x;

            Task3.CountColumsWithZeros(matrix, out x);
            Console.WriteLine(x);
            Task3.FindTheLongestRow(matrix, out x);
            Console.WriteLine(x);
        }
    }
}
