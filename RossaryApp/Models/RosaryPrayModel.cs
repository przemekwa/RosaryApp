using System;
using System.Collections.Generic;
using System.Text;

namespace RossaryApp.Models
{
    public class RosaryPrayModel 
    {
        public KeyValuePair<int, int> Coordinate { get; private set; }
        public string PrayText { get; private set; }

        public RosaryPrayModel(KeyValuePair<int, int> coor, string prayText)
        {
            this.Coordinate = coor;
            this.PrayText = prayText;
        }
    }
}
