using System;
using System.Collections.Generic;
using System.Text;

namespace RossaryApp.RosaryPrayers
{
    using Models;
    using System.Linq;

    public class ChapletOfTheDivineMercy : IRosaryPray
    {
        public List<RosaryPrayModel> Pray { get; private set; }
        
        public ChapletOfTheDivineMercy()
        {
            this.Pray = this.GetRosary().ToList();
        }

        private IEnumerable<RosaryPrayModel> GetRosary()
        {
            var rosary = new List<RosaryPrayModel>
            {
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 15, 18), Translations.ChapletOfTheDivineMercy_SmallBeads), //5.10
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 16, 19), Translations.ChapletOfTheDivineMercy_SmallBeads), //5.9
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 17, 20), Translations.ChapletOfTheDivineMercy_SmallBeads), //5.8
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 18, 21), Translations.ChapletOfTheDivineMercy_SmallBeads), //5.7
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 19, 22), Translations.ChapletOfTheDivineMercy_SmallBeads), //5.6
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 20, 23), Translations.ChapletOfTheDivineMercy_SmallBeads), //5.5
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 21, 24), Translations.ChapletOfTheDivineMercy_SmallBeads), //5.4
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 22, 25), Translations.ChapletOfTheDivineMercy_SmallBeads), //5.3
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 23, 26), Translations.ChapletOfTheDivineMercy_SmallBeads), //5.2
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 24, 27), Translations.ChapletOfTheDivineMercy_SmallBeads), //5.1

                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 26, 28), Translations.ChapletOfTheDivineMercy_TheEternalFather), //5.0

                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 28, 29), Translations.ChapletOfTheDivineMercy_SmallBeads), //4.10
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 29, 29), Translations.ChapletOfTheDivineMercy_SmallBeads), //4.9
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 30, 29), Translations.ChapletOfTheDivineMercy_SmallBeads), //4.8
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 31, 29), Translations.ChapletOfTheDivineMercy_SmallBeads), //4.7
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 32, 29), Translations.ChapletOfTheDivineMercy_SmallBeads), //4.6
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 33, 29), Translations.ChapletOfTheDivineMercy_SmallBeads), //4.5
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 34, 29), Translations.ChapletOfTheDivineMercy_SmallBeads), //4.4
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 35, 29), Translations.ChapletOfTheDivineMercy_SmallBeads), //4.3
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 36, 29), Translations.ChapletOfTheDivineMercy_SmallBeads), //4.2
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 37, 29), Translations.ChapletOfTheDivineMercy_SmallBeads), //4.1

                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 39, 29), Translations.ChapletOfTheDivineMercy_TheEternalFather), //4.0
                
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 41, 28), Translations.ChapletOfTheDivineMercy_SmallBeads), //3.10
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 42, 26), Translations.ChapletOfTheDivineMercy_SmallBeads), //3.9
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 43, 24), Translations.ChapletOfTheDivineMercy_SmallBeads), //3.8
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 44, 21), Translations.ChapletOfTheDivineMercy_SmallBeads), //3.7
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 44, 18), Translations.ChapletOfTheDivineMercy_SmallBeads), //3.6
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 44, 14), Translations.ChapletOfTheDivineMercy_SmallBeads), //3.5
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 44, 11), Translations.ChapletOfTheDivineMercy_SmallBeads), //3.4
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 43, 7),  Translations.ChapletOfTheDivineMercy_SmallBeads), //3.3
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 42, 5), Translations.ChapletOfTheDivineMercy_SmallBeads),  //3.2
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 41, 3), Translations.ChapletOfTheDivineMercy_SmallBeads),  //3.1

                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 39, 2), Translations.ChapletOfTheDivineMercy_TheEternalFather), //3.0

                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 37, 2), Translations.ChapletOfTheDivineMercy_SmallBeads), //2.10
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 36, 2), Translations.ChapletOfTheDivineMercy_SmallBeads), //2.9
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 35, 2), Translations.ChapletOfTheDivineMercy_SmallBeads), //2.8
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 34, 2), Translations.ChapletOfTheDivineMercy_SmallBeads), //2.7
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 33, 2), Translations.ChapletOfTheDivineMercy_SmallBeads), //2.6
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 32, 2), Translations.ChapletOfTheDivineMercy_SmallBeads), //2.5
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 31, 2), Translations.ChapletOfTheDivineMercy_SmallBeads), //2.4
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 30, 2), Translations.ChapletOfTheDivineMercy_SmallBeads), //2.3
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 29, 2), Translations.ChapletOfTheDivineMercy_SmallBeads), //2.2
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 28, 2), Translations.ChapletOfTheDivineMercy_SmallBeads), //2.1

                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 26, 3), Translations.ChapletOfTheDivineMercy_TheEternalFather),  //2.0

                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 24, 4), Translations.ChapletOfTheDivineMercy_SmallBeads),  //1.10
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 23, 5), Translations.ChapletOfTheDivineMercy_SmallBeads),  //1.9
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 22, 6), Translations.ChapletOfTheDivineMercy_SmallBeads),  //1.8
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 21, 7), Translations.ChapletOfTheDivineMercy_SmallBeads),  //1.7
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 20, 8), Translations.ChapletOfTheDivineMercy_SmallBeads),  //1.6
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 19, 9), Translations.ChapletOfTheDivineMercy_SmallBeads),  //1.5
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 18, 10), Translations.ChapletOfTheDivineMercy_SmallBeads), //1.4
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 17, 11), Translations.ChapletOfTheDivineMercy_SmallBeads), //1.3
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 16, 12), Translations.ChapletOfTheDivineMercy_SmallBeads), //1.2
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 15, 13), Translations.ChapletOfTheDivineMercy_SmallBeads), //1.1

                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 13, 16), Translations.ChapletOfTheDivineMercy_TheEternalFather), //1.0

                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 11, 16), Translations.ChapletOfTheDivineMercy_HolyGod),
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 10, 16), Translations.ChapletOfTheDivineMercy_HailMary),
                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 9, 16), Translations.ChapletOfTheDivineMercy_OurFather),

                new RosaryPrayModel(new KeyValuePair<int, int>(Consts.HEIGHT - 7, 16), "")
            };

            rosary.Reverse();

            return rosary;
        }

        public IEnumerable<KeyValuePair<int,int>> GetCrossCoordinate()
        {
            return new List<KeyValuePair<int, int>>
            {
                new KeyValuePair<int, int>(Consts.HEIGHT-4, 18),
                new KeyValuePair<int, int>(Consts.HEIGHT-4, 17),
                new KeyValuePair<int, int>(Consts.HEIGHT-4, 14),
                new KeyValuePair<int, int>(Consts.HEIGHT-4, 15),
                new KeyValuePair<int, int>(Consts.HEIGHT-1, 16),
                new KeyValuePair<int, int>(Consts.HEIGHT-2, 16),
                new KeyValuePair<int, int>(Consts.HEIGHT-3, 16),
                new KeyValuePair<int, int>(Consts.HEIGHT-4, 16),
                new KeyValuePair<int, int>(Consts.HEIGHT-5, 16),
            };
        }
    }
}
