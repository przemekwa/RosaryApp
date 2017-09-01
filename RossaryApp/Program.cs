using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace RossaryApp
{
    class Program
    {
        private const int h = 50;

        private static int[,] rosaryTab = new int[h, 40];
        private static List<KeyValuePair<int, int>> rosaryXY;

        public Program()
        {
            SetRosaryTab();
        }

        static void Main(string[] args)
        {
            SetRosaryTab();
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            ConsoleKey key = ConsoleKey.Enter;

            var prayIndex = -2;

              while (key != ConsoleKey.Escape && prayIndex!=58)
            {
                key = Console.ReadKey(true).Key;
                Console.Clear();
                DrawCross();
                prayIndex++;

                KeyValuePair<int, int> xy;

                if (prayIndex >= 0)
                {
                    xy = rosaryXY[prayIndex];
                }

                rosaryTab[xy.Key, xy.Value] = 1;

                DrawRosary(rosaryTab);
            }

            stopWatch.Stop();

            Console.WriteLine($"Koniec w {GetStopWatchString(stopWatch.Elapsed)}");
            Console.ReadKey();

        }

        private static void DrawCross()
        {
            var cross = new List<KeyValuePair<int, int>>
            {
                new KeyValuePair<int, int>(h-4, 18),
                new KeyValuePair<int, int>(h-4, 17),
                new KeyValuePair<int, int>(h-4, 14),
                new KeyValuePair<int, int>(h-4, 15),
                new KeyValuePair<int, int>(h-1, 16),
                new KeyValuePair<int, int>(h-2, 16),
                new KeyValuePair<int, int>(h-3, 16),
                new KeyValuePair<int, int>(h-4, 16),
                new KeyValuePair<int, int>(h-5, 16),
            };

            foreach (var item in cross)
            {
                rosaryTab[item.Key, item.Value] = 1;
            }
        }

        private static void SetRosaryTab()
        {
             rosaryXY = new List<KeyValuePair<int, int>>
            {
                new KeyValuePair<int, int>(h - 15, 18), //5.10
                new KeyValuePair<int, int>(h - 16, 19), //5.9
                new KeyValuePair<int, int>(h - 17, 20), //5.8
                new KeyValuePair<int, int>(h - 18, 21), //5.7
                new KeyValuePair<int, int>(h - 19, 22), //5.6
                new KeyValuePair<int, int>(h - 20, 23), //5.5
                new KeyValuePair<int, int>(h - 21, 24), //5.4
                new KeyValuePair<int, int>(h - 22, 25), //5.3
                new KeyValuePair<int, int>(h - 23, 26), //5.2
                new KeyValuePair<int, int>(h - 24, 27), //5.1

                new KeyValuePair<int, int>(h - 26, 28), //5.0

                new KeyValuePair<int, int>(h - 28, 29), //4.10
                new KeyValuePair<int, int>(h - 29, 29), //4.9
                new KeyValuePair<int, int>(h - 30, 29), //4.8
                new KeyValuePair<int, int>(h - 31, 29), //4.7
                new KeyValuePair<int, int>(h - 32, 29), //4.6
                new KeyValuePair<int, int>(h - 33, 29), //4.5
                new KeyValuePair<int, int>(h - 34, 29), //4.4
                new KeyValuePair<int, int>(h - 35, 29), //4.3
                new KeyValuePair<int, int>(h - 36, 29), //4.2
                new KeyValuePair<int, int>(h - 37, 29), //4.1

                new KeyValuePair<int, int>(h - 39, 29), //4.0
                
                new KeyValuePair<int, int>(h - 41, 28), //3.10
                new KeyValuePair<int, int>(h - 42, 26), //3.9
                new KeyValuePair<int, int>(h - 43, 24), //3.8
                new KeyValuePair<int, int>(h - 44, 21), //3.7
                new KeyValuePair<int, int>(h - 44, 18), //3.6
                new KeyValuePair<int, int>(h - 44, 14), //3.5
                new KeyValuePair<int, int>(h - 44, 11), //3.4
                new KeyValuePair<int, int>(h - 43, 7),  //3.3
                new KeyValuePair<int, int>(h - 42, 5),  //3.2
                new KeyValuePair<int, int>(h - 41, 3),  //3.1

                new KeyValuePair<int, int>(h - 39, 2), //3.0

                new KeyValuePair<int, int>(h - 37, 2), //2.10
                new KeyValuePair<int, int>(h - 36, 2), //2.9
                new KeyValuePair<int, int>(h - 35, 2), //2.8
                new KeyValuePair<int, int>(h - 34, 2), //2.7
                new KeyValuePair<int, int>(h - 33, 2), //2.6
                new KeyValuePair<int, int>(h - 32, 2), //2.5
                new KeyValuePair<int, int>(h - 31, 2), //2.4
                new KeyValuePair<int, int>(h - 30, 2), //2.3
                new KeyValuePair<int, int>(h - 29, 2), //2.2
                new KeyValuePair<int, int>(h - 28, 2), //2.1

                new KeyValuePair<int, int>(h - 26, 3),  //2.0

                new KeyValuePair<int, int>(h - 24, 4),  //1.10
                new KeyValuePair<int, int>(h - 23, 5),  //1.9
                new KeyValuePair<int, int>(h - 22, 6),  //1.8
                new KeyValuePair<int, int>(h - 21, 7),  //1.7
                new KeyValuePair<int, int>(h - 20, 8),  //1.6
                new KeyValuePair<int, int>(h - 19, 9),  //1.5
                new KeyValuePair<int, int>(h - 18, 10), //1.4
                new KeyValuePair<int, int>(h - 17, 11), //1.3
                new KeyValuePair<int, int>(h - 16, 12), //1.2
                new KeyValuePair<int, int>(h - 15, 13), //1.1

                new KeyValuePair<int, int>(h - 13, 16), //1.0

                new KeyValuePair<int, int>(h - 11, 16), 
                new KeyValuePair<int, int>(h - 10, 16), 
                new KeyValuePair<int, int>(h - 9, 16), 

                new KeyValuePair<int, int>(h - 7, 16) 
            };


            rosaryXY.Reverse();
        }

        public static string GetStopWatchString(TimeSpan ts)
        {
            return $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}:{(ts.Milliseconds / 10):00}";
        }

        private static void DrawRosary(int[,] rosary)
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    if (rosary[i, j] == 1)
                    {
                        Console.Write("O");
                    }
                    else
                    {
                        Console.Write(" ");
                    }

                }
                Console.WriteLine("");
            }
        }
    }
}