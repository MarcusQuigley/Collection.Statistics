using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic.Collection.Statistics
{
    public class TimeResults
    {

        public TimeSpan SequentialInsertsTime { get; set; }
        public RandomInsertTimes RandomInsertsTime { get; set; }
        public TimeSpan RetrieveTime { get; set; }
    }

    public class RandomInsertTimes
    {
        public TimeSpan RandomInsertTime { get; set; }
        public double IndividualInsertTime { get; set; }
    }
}
