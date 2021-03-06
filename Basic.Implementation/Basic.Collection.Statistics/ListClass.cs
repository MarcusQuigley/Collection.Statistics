﻿using System;
using System.Collections.Generic;

namespace Basic.Collection.Statistics
{
    public class ListClass : CollectionBase
    {
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
