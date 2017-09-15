using System;
using System.Collections.Generic;
using System.Text;

namespace RossaryApp
{
    internal static class ParametrsConfiguration
    {
        public static List<Param> ParamList { get; set; } = new List<Param>();

        public static void ManageArgs(string[] args)
        {
            if (args.Length == 0)
            {
                ParamList.Add(new Param
                {
                    ErrorMsg = "Brak parametru. Podaj parametr(rodzaj modlitwy) dla różańca"
                });

                return;
            }

            if (string.IsNullOrEmpty(args[0]))
            {
                ParamList.Add(new Param
                {
                    ErrorMsg = "Brak zdefiniowanej modlitwy w argumentach"
                });

                return;
            }


            if (!Consts.PRAY_LIST.Contains(args[0]))
            {
                ParamList.Add(new Param
                {
                    ErrorMsg = "Nie obsługiwana modlitwa"
                });

                return;
            }

            ParamList.Add(new Param
            {
                Value = args[0]
            });

        }
    }
}
