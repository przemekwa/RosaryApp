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

        private static Type prayType;

        static void Main(string[] args)
        {
            ParametrsConfiguration.ManageArgs(args);

            foreach (var item in ParametrsConfiguration.ParamList
                .Where(s=>!string.IsNullOrEmpty(s.ErrorMsg)))
            {
                Console.WriteLine(item.ErrorMsg);
                Console.ReadKey();
                return;
            }

            switch (ParametrsConfiguration.ParamList.First().Value)
            {
                case "ChapletOfTheDivineMercy":
                    prayType = typeof(ChapletOfTheDivineMercy);
                    break;
            }

            IRosaryPray currentPray = (IRosaryPray)Activator.CreateInstance(prayType);

            Console.CursorVisible = false;

            var stopWatch = new Stopwatch();

            stopWatch.Start();

            ConsoleKey key = ConsoleKey.Enter;

            var prayIndex = -1;

            Console.WriteLine("Rozpocznij modlitwę...");

            while ((key = Console.ReadKey(true).Key) != ConsoleKey.Escape && prayIndex != 58)
            {
                if (key == ConsoleKey.L)
                {
                    currentPray = ConsoleChangeLanguage();
                    continue;
                }

                if ((key != ConsoleKey.Enter) && (key != ConsoleKey.Backspace))
                {
                    continue;
                }

                Console.Clear();

                if (prayIndex < 0)
                {
                    DrawCross(currentPray.GetCrossCoordinate());
                    DrawRosary(rosaryTab);
                    prayIndex++;
                    continue;
                }

                var currentXY = currentPray.Pray[prayIndex].Coordinate;

                if (key == ConsoleKey.Backspace)
                {
                    Back(currentXY, currentPray, ref prayIndex);
                }
                else
                {
                    Next(currentXY, currentPray, ref prayIndex); 
                }

                prayIndex++;
            }

            stopWatch.Stop();

            Console.WriteLine($"Koniec w {GetStopWatchString(stopWatch.Elapsed)}");

            Console.ReadKey();
        }

        private static void Back(KeyValuePair<int, int> currentXY, IRosaryPray currentPray, ref int prayIndex)
        {
            prayIndex--;

            currentXY = currentPray.Pray[prayIndex].Coordinate;

            rosaryTab[currentXY.Key, currentXY.Value] = 0;

            prayIndex--;

            currentXY = currentPray.Pray[prayIndex].Coordinate;

            DrawPrayText(currentPray.Pray[prayIndex].PrayText, currentPray, prayIndex);

            DrawRosary(rosaryTab);
        }

        private static void Next(KeyValuePair<int,int> currentXY, IRosaryPray currentPray, ref int prayIndex)
        {
            rosaryTab[currentXY.Key, currentXY.Value] = 1;

            DrawPrayText(currentPray.Pray[prayIndex].PrayText, currentPray, prayIndex);

            DrawRosary(rosaryTab);
        }

        private static IRosaryPray ConsoleChangeLanguage()
        {
            IRosaryPray currentPray;

            switch (Console.ReadKey(true).Key)
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
                    currentPray = GetRosaryPrayForTranslation("it");
                    break;
                default:
                    currentPray = GetRosaryPrayForTranslation("pl");
                    break;
            }

            return currentPray;
        }

        

        private static void DrawPrayText(string prayText, IRosaryPray currentPray, int prayIndex)
        {
            Console.CursorTop = 1;
            Console.CursorLeft = 0;
            Console.WriteLine(currentPray.Pray[prayIndex].PrayText);
            Console.WriteLine(currentPray.Pray[prayIndex].PrayNumber);
        }

        private static IRosaryPray GetRosaryPrayForTranslation(string cutureString)
        {
            CultureInfo.CurrentCulture = new CultureInfo(cutureString);
            CultureInfo.CurrentUICulture = new CultureInfo(cutureString);
            
            return (IRosaryPray)Activator.CreateInstance(prayType);
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