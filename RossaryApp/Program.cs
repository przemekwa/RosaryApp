using System;
using System.Collections.Generic;
using System.Linq;

namespace RossaryApp
{
    class Program
    {

        private const int h = 50;

        private static int[,] rosaryTab = new int[h, 40];

        static void Main(string[] args)
        {

           

            SetRosaryTab();
            ConsoleKey key = ConsoleKey.Enter;

            while (key != ConsoleKey.Escape)
            {

              
                key = Console.ReadKey(true).Key;
                Console.Clear();
                DrawRosary();
            }

            
        }

        private static void SetRosaryTab()
        {
            //Prawa strona

            rosaryTab[h - 44, 18] = 1;
            rosaryTab[h - 44, 21] = 1;
            rosaryTab[h - 43, 24] = 1;
            rosaryTab[h - 42, 26] = 1;
            rosaryTab[h - 41, 28] = 1;

            rosaryTab[h - 39, 29] = 1;

            rosaryTab[h - 37, 29] = 1;
            rosaryTab[h - 36, 29] = 1;
            rosaryTab[h - 35, 29] = 1;
            rosaryTab[h - 34, 29] = 1;
            rosaryTab[h - 33, 29] = 1;
            rosaryTab[h - 32, 29] = 1;
            rosaryTab[h - 31, 29] = 1;
            rosaryTab[h - 30, 29] = 1;
            rosaryTab[h - 29, 29] = 1;
            rosaryTab[h - 28, 29] = 1;

            rosaryTab[h - 26, 28] = 1;

            rosaryTab[h - 24, 27] = 1;
            rosaryTab[h - 23, 26] = 1;
            rosaryTab[h - 22, 25] = 1;
            rosaryTab[h - 21, 24] = 1;
            rosaryTab[h - 20, 23] = 1;
            rosaryTab[h - 19, 22] = 1;
            rosaryTab[h - 18, 21] = 1;
            rosaryTab[h - 17, 20] = 1;
            rosaryTab[h - 16, 19] = 1;
            rosaryTab[h - 15, 18] = 1;

            //Lewa strona


            rosaryTab[h - 44, 14] = 1;
            rosaryTab[h - 44, 11] = 1;
            rosaryTab[h - 43, 7] = 1;
            rosaryTab[h - 42, 5] = 1;
            rosaryTab[h - 41, 3] = 1;

            rosaryTab[h - 39, 2] = 1;

            rosaryTab[h - 37, 2] = 1;
            rosaryTab[h - 36, 2] = 1;
            rosaryTab[h - 35, 2] = 1;
            rosaryTab[h - 34, 2] = 1;
            rosaryTab[h - 33, 2] = 1;
            rosaryTab[h - 32, 2] = 1;
            rosaryTab[h - 31, 2] = 1;
            rosaryTab[h - 30, 2] = 1;
            rosaryTab[h - 29, 2] = 1;
            rosaryTab[h - 28, 2] = 1;

            rosaryTab[h - 26, 3] = 1;

            rosaryTab[h - 24, 4] = 1;
            rosaryTab[h - 23, 5] = 1;
            rosaryTab[h - 22, 6] = 1;
            rosaryTab[h - 21, 7] = 1;
            rosaryTab[h - 20, 8] = 1;
            rosaryTab[h - 19, 9] = 1;
            rosaryTab[h - 18, 10] = 1;
            rosaryTab[h - 17, 11] = 1;
            rosaryTab[h - 16, 12] = 1;
            rosaryTab[h - 15, 13] = 1;
            


            rosaryTab[h - 13, 16] = 1;

            rosaryTab[h - 11, 16] = 1;
            rosaryTab[h - 10, 16] = 1;
            rosaryTab[h - 9, 16] = 1;

            rosaryTab[h - 7, 16] = 1;

            rosaryTab[h - 5, 16] = 1;
            rosaryTab[h - 4, 16] = 1;
            rosaryTab[h - 3, 16] = 1;
            rosaryTab[h - 2, 16] = 1;
            rosaryTab[h - 1, 16] = 1;

            rosaryTab[h - 4, 15] = 1;
            rosaryTab[h - 4, 14] = 1;

            rosaryTab[h - 4, 17] = 1;
            rosaryTab[h-4, 18] = 1;
        }

        private static void DrawRosary()
        {
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < 40; j++)
                {
                    if (rosaryTab[i, j] == 1)
                    {
                        Console.Write("*");
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