using System;
using System.Collections.Generic;

namespace Collection.Statistics.CollectionTypesLibrary
{
    public class DictionaryClass : CollectionBase
    {
        public DictionaryClass()
        {
            this.Name = "Dictionary";
        }

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
