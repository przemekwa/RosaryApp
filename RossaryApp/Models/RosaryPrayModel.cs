using System;
using System.Collections.Generic;
using System.Text;

namespace RossaryApp.Models
{
    public class RosaryPrayModel 
    {
        public KeyValuePair<int, int> Coordinate { get; private set; }
        public string PrayText { get; private set; }
        public string PrayNumber { get; set; }

        public RosaryPrayModel(KeyValuePair<int, int> coor, string prayText, string prayNumber)
        {
            this.Coordinate = coor;
            this.PrayText = prayText;
            this.PrayNumber = prayNumber;
        }
    }
}
