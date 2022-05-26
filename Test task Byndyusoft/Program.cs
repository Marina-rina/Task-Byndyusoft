using System;
using System.Linq;
using System.Diagnostics;

namespace Test_task_Byndyusoft
{
    public class Program
    {
        /// <summary>
        /// Напишите функцию, на вход которой приходит массив чисел. Функция возвращает сумму двух минимальных элементов массива.
        /// Например, если дан массив[4, 0, 3, 19, 492, -10, 1], то результатом будет -10, потому что два минимальных числа -10 и 0, а их сумма -10.
        /// Напишите минимум 3 модульных теста на эту функцию.
        /// HINT: учти, что массив может быть пустым, или без цифр или состоять из 100 млн.элементов, поэтому надо учесть разные граничные условия.
        /// </summary>
        public static int SumOfTwoMinimalElements(int[] arr)
        {
            if (arr.Length == 0)
                return 0;

            if (arr.Length == 1)
                return arr[0];

            int min1 = arr[0],
                min2 = arr[1];

            for (int i = 1; i < arr.Length; i++)
                if (arr[i] < min1 || arr[i] < min2)
                    if (min2 > min1)
                        min2 = arr[i];
                    else
                        min1 = arr[i];

            return min1 + min2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumOfTwoMinimalElements(new int[] {4, 0, 3, 19, 492, -10, 1 }));
            Console.ReadKey();
        }

    }
}
