using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Basic.Collection.Statistics
{
    class Program
    {
        //static List<int> listInts =null;


        static void Main(string[] args)
        {
            ListStatistics listStats = new ListStatistics();
            listStats.Run();

            DictionaryStatistics dictStats = new DictionaryStatistics();
            dictStats.Run();

            Console.Read();


        }

       //static TimeSpan AddSequentialEntries(int count)
       // {
       //     Stopwatch stopWatch = new Stopwatch();
       //     stopWatch.Start();

       //     for (int i = 0; i < count; i++)
       //     {
       //         listInts.Add(i);
       //     }

       //     stopWatch.Stop();
       //     return stopWatch.Elapsed;
       // }

       //static TimeSpan AddRandonEntries(int count, out double individualTimes)
       //{

       //    Stopwatch stopWatch = new Stopwatch();
       //    stopWatch.Start();
       //    for (int i = 0; i < count; i++)
       //    {
       //        int position = GetRandomInt();
       //        listInts.Insert(position, i);
       //    }

       //    stopWatch.Stop();

       //    individualTimes = stopWatch.ElapsedMilliseconds / (double) count;

       //    return stopWatch.Elapsed;
       //}

       //static TimeSpan RetrieveByKey(int key)
       //{
       //    Stopwatch stopWatch = new Stopwatch();
       //    stopWatch.Start();

       //    int result = listInts[key];

       //    if (result == -1) return TimeSpan.MinValue;

       //    stopWatch.Stop();
       //    return stopWatch.Elapsed;
       //}

       //static int GetRandomInt()
       //{
       //    return new Random().Next(listInts.Count);
       //}
    }
}
