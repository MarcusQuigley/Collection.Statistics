using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic.Collection.Statistics
{
    public class CountsService
    {
        //int seqEntriesCount = 500000;
        //int randEntriesCount = 5000;

        public int SeqEntriesCount { get; set; }
        public int RanEntriesCount { get; set; }

        public CountsService(int sequentialEntriesCount, int randomEntriesCount)
        {
            this.SeqEntriesCount = sequentialEntriesCount;
            this.RanEntriesCount = randomEntriesCount;
        }
    }
}
