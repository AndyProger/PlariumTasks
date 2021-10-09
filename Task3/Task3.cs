using System;

namespace PlariumTasks
{
    class Task3
    {
        /* Task 3.1.1
         * В одномерном целочисленном массиве переставить элементы в обратном порядке, 
         * не используя других массивов.
         */
        public static void Reverse(int[] array) => Array.Reverse(array);
        
        // + не такой простой вариант
        // также можно решить эту задачу рекурсивно, но это не так эффективно 
        public static void Reversev2(int[] array)
        {
            var leftIndex = 0;
            var rightIndex = array.Length - 1;
            
            while(leftIndex < rightIndex)
            {
                // swap с помощью кортежей 
                (array[leftIndex], array[rightIndex]) = (array[rightIndex], array[leftIndex]);

                leftIndex++;
                rightIndex--;
            }
        }

        /* Task 3.1.2
         * Найти количество элементов массива, встречающихся в нем один раз. 
         */
        public static int FindQuantityUnicElemnts(int[] array)
        {
            var isRepeated = false;
            var counter = 0;

            for(var i = 0; i < array.Length; i++)
            {
                isRepeated = false;

                for (var j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j] && i != j)
                    {
                        isRepeated = true;
                    }
                }

                if (!isRepeated)
                {
                    counter++;
                }
            }

            return counter;
        }

        /* Task 3.1.3
         * В одномерном целочисленном массиве x[1]…x[n+m], рассматриваемом как соединение 
         * двух его отрезков: начала x[1]…x[n] длины n и конца x[n]… [n+m] длины m, переставить 
         * местами начало и конец, не используя дополнительных массивов. 
         */
        public static void ChangeArray(int[] array)
        {
            var leftPointer = 0;
            var rightPointer = array.Length / 2;

            while(rightPointer != array.Length)
            {
                (array[leftPointer], array[rightPointer]) = (array[rightPointer], array[leftPointer]);
                leftPointer++;
                rightPointer++;
            }
        }

        /* Task 3.2
         * Дана целочисленная прямоугольная матрица. Определить:
         * количество столбцов, содержащих хотя бы один нулевой элемент;
         * номер строки, в которой находится самая длинная серия одинаковых элементов.
         */

        //номер строки, в которой находится самая длинная серия одинаковых элементов.
        // вернет -1, если такой индекс не будет найден
        public static void FindTheLongestRow(int[,] array, out int resultIndex)
        {
            var tmp = 0;
            var kMax = -1;
            resultIndex = -1;
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1) - 1; j++)
                {
                    if (array[i, j] == array[i, j + 1])
                    {
                        tmp++;
                        if (tmp > kMax)
                        {
                            kMax = tmp;
                            resultIndex = j;
                        }
                    }
                    else
                    {
                        tmp = 1;
                    }
                }
            }
        }

        // количество столбцов, содержащих хотя бы один нулевой элемент.
        public static void CountColumsWithZeros(int[,] matrix, out int numOfColums)
        {
            numOfColums = 0;

            for (var i = 0; i < matrix.GetLength(1); i++)
            {
                for (var j = 0; j < matrix.GetLength(0); j++)
                {
                    if (matrix[j, i] == 0)
                    {
                        numOfColums++;
                        break;
                    }
                }
            }
        }

    }
}
