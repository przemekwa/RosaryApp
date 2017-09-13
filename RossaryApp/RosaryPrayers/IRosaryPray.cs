﻿using System.Collections.Generic;
using RossaryApp.Models;

namespace RossaryApp.RosaryPrayers
{
    public interface IRosaryPray
    {
        IEnumerable<KeyValuePair<int, int>> GetCrossCoordinate();
        IEnumerable<RosaryPrayModel> GetRosary();
    }
}