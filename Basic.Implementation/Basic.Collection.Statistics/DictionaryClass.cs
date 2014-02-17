using System;
using System.Collections.Generic;

namespace Basic.Collection.Statistics
{
    public class DictionaryClass : CollectionBase
    {
        private Dictionary<int, int> dictInts = new Dictionary<int, int>();

         public override void AddSequentialEntry(int count)
        {
            dictInts.Add(count, count);
        }

        public override void AddRandomEntry(int count)
        {
            dictInts[GetRandomInt] = count; 
        }

        public override int RetrieveKey( )
        {
            return dictInts[GetRandomInt];
        }

        private int GetRandomInt
        {
            get { return new Random().Next(dictInts.Count); }
        }
    }
}
