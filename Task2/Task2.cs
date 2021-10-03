using System.Collections.Generic;

namespace PlariumTasks
{
    class Task2
    {
        /*
         * Task 2.1
         * Дано натуральное число n (n < 27). Найти все трехзначные числа, сумма цифр которых равна п. 
         * Операции деления, целочисленного деления и определения остатка не использовать.
         */
        public static List<int> FindNumbers(int number)
        {
            var listOfNumbers = new List<int>();
            string tmp;

            // можно также и через три цикла сделать, но этот вариант нравится мне больше
            for(var i = 100; i <= 999; i++)
            {
                tmp = i.ToString();

                var a = tmp[0] - '0';
                var b = tmp[1] - '0';
                var c = tmp[2] - '0';

                if (a + b + c == number)
                    listOfNumbers.Add(i);
            }

            return listOfNumbers;
        }

        /*
         * Task 2.2.1
         * Дано натуральное число. Определить, есть ли в нем цифры а и b.
         */
        public static bool HaveSuchDigits(int number, int digitA, int digitB)
        {
            string strNumber = number.ToString();
            return strNumber.Contains(digitA.ToString()) && strNumber.Contains(digitB.ToString());
        }

        /*
         * Task 2.2.2
         * Дано натуральное число. Найти число, получаемое при прочтении его цифр справа налево
         */
        public static int ReverseNumber(int number)
        {
            var reversed = 0;

            while (number > 0)
            {
                reversed = reversed * 10 + number % 10;
                number /= 10;
            }

            return reversed;
        }

        /*
         * Task 2.2.3
         * Дано натуральное число. Найти число, получаемое удалением из исходного всех цифр а.
         * UPDATE: Также можно вводить, сразу несколько цифер/чисел для удаления их из числа.
         */
        public static void RemoveDigits(ref int number, params int[] a)
        {
            string strNumber = number.ToString();

            for(var i = 0; i < a.Length; i++)
            {
                strNumber = strNumber.Replace(a[i].ToString(), string.Empty);
            }

            int.TryParse(strNumber, out number);
        }
    }
}
