using System;
using System.Collections.Generic;

namespace Collection.Statistics.CollectionTypesLibrary
{
    public class ListClass : CollectionBase
    {
        public ListClass()
        {
            this.Name = "List<Int>";
        }

        private List<int> listInts = new List<int>();

        public override void AddSequentialEntry(int count)
        {
            listInts.Add(count);
        }

        public override void AddRandomEntry(int count)
        {
            listInts[GetRandomInt] = count;
        }

        public override int RetrieveKey()
        {
            return listInts[GetRandomInt];
        }

        private int GetRandomInt
        {
            get { return new Random().Next(listInts.Count); }
        }

         
        
    }
}
