using System;
using System.Linq;
using System.Diagnostics;

namespace Test_task_Byndyusoft
{
    public class Program
    {

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
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int[] arr = Enumerable.Range(0, 100000000).ToArray();
            //int[] arr = Enumerable.Range(0, 100000000).ToArray();

            stopWatch.Stop();
            TimeSpan ts = stopWatch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                        ts.Hours, ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);

            stopWatch = new Stopwatch();
            stopWatch.Start();
            //Console.WriteLine(SumOfTwoMinimalElements(new int[] {4, 0, 3, 19, 492, -10, 1 }));
            Console.WriteLine(SumOfTwoMinimalElements(arr));
            stopWatch.Stop();
            ts = stopWatch.Elapsed;
            elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                        ts.Hours, ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);
            Console.WriteLine("SumOfTwoMinimalElements " + elapsedTime);

            Console.ReadKey();

        }

    }
}
