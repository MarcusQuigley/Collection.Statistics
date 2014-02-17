using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Basic.Collection.Statistics
{
    public abstract class CollectionBase
    {

        public TimeSpan AddSequentialEntries(int count)//, Action<int, int> addAction)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < count; i++)
            {
                //dictInts.Add(i, i);
                // addAction(i, i);
                AddSequentialEntry(i);
            }

            stopWatch.Stop();
            return stopWatch.Elapsed;
        }

        public abstract void AddSequentialEntry(int count);

        public RandomInsertTimes AddRandomEntries(int count)
        {
            RandomInsertTimes insertTimes = new RandomInsertTimes();
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < count; i++)
            {
               // int position = GetRandomInt();
               // listInts.Insert(position, i);
                AddRandomEntry(i);
            }

            stopWatch.Stop();
            insertTimes.IndividualInsertTime = stopWatch.ElapsedMilliseconds / (double)count;

            insertTimes.RandomInsertTime = stopWatch.Elapsed;

            return insertTimes;
        }

        public abstract void AddRandomEntry(int count);

        public TimeSpan RetrieveByKey()
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

          int result=  RetrieveKey();
            //int result = dictInts[key];

            if (result == -1) return TimeSpan.MinValue;

            stopWatch.Stop();
            return stopWatch.Elapsed;
        }

        public abstract int RetrieveKey();

        private int GetRandomInt()
        {
            //TODO NEED TO FIX THIS
            return new Random().Next(50000);
        }

    }

}
