//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Diagnostics;

//namespace Basic.Collection.Statistics
//{

//    //1. class for output
//    //2. class to get timed results
//    //3. generic dictionary class??
//    //4. generic list class??
//    //Since the coll classes do a lot of the same things maybe a base class.....
//    //5. arg class which contains # of seq entries, # of rand entries and # of retrieves
//    //6. class to run
//  public  class ListStatistics
//    {
//      private List<int> listInts = null;

//      private TimeResults timeResults;

//      public ListStatistics(TimeResults timeResults)
//      {
//          this.timeResults = timeResults;
//      }


//      public void Run()
//      {
//          Console.WriteLine("Testing for List<int>");
//          listInts = new List<int>();

//          int seqEntriesCount = 500000;
//          int randEntriesCount = 5000;

//          timeResults.SequentialInsertsTime = AddSequentialEntries(seqEntriesCount);
//          double randInsertionMS;
//           timeResults.RandomInsertsTime = AddRandonEntries(randEntriesCount, out randInsertionMS);


//          timeResults.RetrieveTime = RetrieveByKey(GetRandomInt());

//          Console.WriteLine("Time for {0} Sequential entries = {1}ms", seqEntriesCount, timeResults.SequentialInsertsTime.TotalMilliseconds);
//          Console.WriteLine("Time for {0} Random entries = {1}ms", randEntriesCount, timeResults.RandomInsertsTime.TotalMilliseconds);

//          Console.WriteLine("Time for each random insertion = {0}ms", randInsertionMS);

//          Console.WriteLine("Time for retrieve key = {0}ms", timeResults.RetrieveTime.TotalMilliseconds);
//          Console.WriteLine("------------");
//          Console.WriteLine("\n");

//      }

//          TimeSpan AddSequentialEntries(int count)
//        {
//            Stopwatch stopWatch = new Stopwatch();
//            stopWatch.Start();

//            for (int i = 0; i < count; i++)
//            {
//                listInts.Add(i);
//            }

//            stopWatch.Stop();
//            return stopWatch.Elapsed;
//        }

//          TimeSpan AddRandonEntries(int count, out double individualTimes)
//        {

//            Stopwatch stopWatch = new Stopwatch();
//            stopWatch.Start();
//            for (int i = 0; i < count; i++)
//            {
//                int position = GetRandomInt();
//                listInts.Insert(position, i);
//            }

//            stopWatch.Stop();

//            individualTimes = stopWatch.ElapsedMilliseconds / (double)count;

//            return stopWatch.Elapsed;
//        }

//          TimeSpan RetrieveByKey(int key)
//        {
//            Stopwatch stopWatch = new Stopwatch();
//            stopWatch.Start();

//            int result = listInts[key];

//            if (result == -1) return TimeSpan.MinValue;

//            stopWatch.Stop();
//            return stopWatch.Elapsed;
//        }

//        private int GetRandomInt()
//        {
//            return new Random().Next(listInts.Count);
//        }

//    }
//}
