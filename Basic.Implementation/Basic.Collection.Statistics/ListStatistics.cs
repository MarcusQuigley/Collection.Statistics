using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Basic.Collection.Statistics
{
  public  class ListStatistics
    {
      private List<int> listInts = null;


      public void Run()
      {
          Console.WriteLine("Testing for List<int>");
          listInts = new List<int>();

          int seqEntriesCount = 500000;
          int randEntriesCount = 5000;

          TimeSpan seqInsertion = AddSequentialEntries(seqEntriesCount);
          double randInsertionMS;
          TimeSpan randInsertion = AddRandonEntries(randEntriesCount, out randInsertionMS);


          TimeSpan retrieveKey = RetrieveByKey(GetRandomInt());
 
          Console.WriteLine("Time for {0} Sequential entries = {1}ms", seqEntriesCount, seqInsertion.TotalMilliseconds);
          Console.WriteLine("Time for {0} Random entries = {1}ms", randEntriesCount, randInsertion.TotalMilliseconds);

          Console.WriteLine("Time for each random insertion = {0}ms", randInsertionMS);

          Console.WriteLine("Time for retrieve key = {0}ms", retrieveKey.TotalMilliseconds);
          Console.WriteLine("------------");
          Console.WriteLine("\n");

      }

          TimeSpan AddSequentialEntries(int count)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            for (int i = 0; i < count; i++)
            {
                listInts.Add(i);
            }

            stopWatch.Stop();
            return stopWatch.Elapsed;
        }

          TimeSpan AddRandonEntries(int count, out double individualTimes)
        {

            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();
            for (int i = 0; i < count; i++)
            {
                int position = GetRandomInt();
                listInts.Insert(position, i);
            }

            stopWatch.Stop();

            individualTimes = stopWatch.ElapsedMilliseconds / (double)count;

            return stopWatch.Elapsed;
        }

          TimeSpan RetrieveByKey(int key)
        {
            Stopwatch stopWatch = new Stopwatch();
            stopWatch.Start();

            int result = listInts[key];

            if (result == -1) return TimeSpan.MinValue;

            stopWatch.Stop();
            return stopWatch.Elapsed;
        }

        private int GetRandomInt()
        {
            return new Random().Next(listInts.Count);
        }

    }
}
