using Microsoft.Extensions.Configuration;
using RossaryApp.RosaryPrayers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;


namespace RossaryApp
{
    class Program
    {
        public static IConfigurationRoot Configuration { get; set; }
        private static int[,] rosaryTab = new int[Consts.HEIGHT, 40];

        private static int smallBeadCount = 0;
        private static int bigBeadCount = 1;


        static void Main(string[] args)
        {
            IRosaryPray currentPray = new ChapletOfTheDivineMercy();

            var reload = false;

            Console.CursorVisible = false;
            var stopWatch = new Stopwatch();
            stopWatch.Start();

            ConsoleKey key = ConsoleKey.Enter;

            var prayIndex = 0;

            Console.WriteLine("Rozpocznij modlitwę...");

            while ((key = Console.ReadKey(true).Key) != ConsoleKey.Escape && prayIndex != 58)
            {
                if (key == ConsoleKey.L)
                {
                    switch(Console.ReadKey(true).Key)
                    {
                        case ConsoleKey.P:
                            currentPray = GetRosaryPrayForTranslation("pl");
                            break;
                        case ConsoleKey.E:
                            currentPray = GetRosaryPrayForTranslation("en");
                            break;
                        case ConsoleKey.C:
                            currentPray = GetRosaryPrayForTranslation("cs");
                            break;
                        case ConsoleKey.W:
                            currentPray = GetRosaryPrayForTranslation("it-IT");
                            break;
                        default:
                            currentPray = GetRosaryPrayForTranslation("pl");
                            break;
                    }

                    continue;
                }
            

                if ((key != ConsoleKey.Enter) && (key != ConsoleKey.Backspace))
                {
                    continue;
                }

                Console.Clear();

                if (prayIndex <= 0 )
                {
                    DrawCross(currentPray.GetCrossCoordinate());
                    DrawRosary(rosaryTab);
                    prayIndex++;
                    continue;
                }

                if (key == ConsoleKey.Backspace)
                {
                    prayIndex--;
                    var xy = currentPray.Pray[prayIndex].Coordinate;
                    rosaryTab[xy.Key, xy.Value] = 0;
                }
                else
                {
                    prayIndex++;
                    var xy = currentPray.Pray[prayIndex].Coordinate;
                    rosaryTab[xy.Key, xy.Value] = 1;
                }

                DrawPrayText(currentPray.Pray[prayIndex].PrayText, currentPray, prayIndex);


                
                    if (prayIndex > 4)
                    {
                        if (smallBeadCount == 10)
                        {
                            bigBeadCount++;
                            smallBeadCount = -1;
                        }
                        smallBeadCount++;
                    }

                    Console.Write($"{bigBeadCount}.{smallBeadCount}");



                DrawRosary(rosaryTab);
            }

            stopWatch.Stop();

            Console.WriteLine($"Koniec w {GetStopWatchString(stopWatch.Elapsed)}");
            Console.ReadKey();
        }

        private static void DrawPrayText(string prayText, IRosaryPray currentPray, int prayIndex)
        {
            Console.CursorTop = 1;
            Console.CursorLeft = 0;
            Console.WriteLine(currentPray.Pray[prayIndex].PrayText);
        }

        private static IRosaryPray GetRosaryPrayForTranslation(string cutureString)
        {
            IRosaryPray currentPray;
            CultureInfo.CurrentCulture = new CultureInfo(cutureString);
            CultureInfo.CurrentUICulture = new CultureInfo(cutureString);
            currentPray = new ChapletOfTheDivineMercy();
            return currentPray;
        }

        private static void DrawCross(IEnumerable<KeyValuePair<int, int>> cross)
        {
            foreach (var item in cross)
            {
                rosaryTab[item.Key, item.Value] = 1;
            }
        }

        private static string GetStopWatchString(TimeSpan ts)
        {
            return $"{ts.Hours:00}:{ts.Minutes:00}:{ts.Seconds:00}.{(ts.Milliseconds / 10):00}";
        }

        private static void DrawRosary(int[,] rosary)
        {
            for (int i = 0; i < Consts.HEIGHT; i++)
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