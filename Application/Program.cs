using System;
using Collection.Statistics.CommonTypesLib;
using Collection.Statistics.OutputLibrary;
using Collection.Statistics.CollectionTypesLibrary;
using Collection.Statistics.InterfacesLibrary;

namespace Collection.Statistics.Application
{
    //1. class for output
    //2. class to get timed results
    //3. generic dictionary class??
    //4. generic list class??
    //7. Since the coll classes do a lot of the same things maybe a base class.....
    //5. arg class which contains # of seq entries, # of rand entries and # of retrieves
    //6. class to run

    //Now add classes to assembles
    //1. Collection lib to hold 3,4,7
    //2. output lib to hold 1
    //3. COmmontypes to hold 2,5
    //4. Assembly for Execute class 6
    //5. Application Lib to hold Program.cs and Unity config

    class Program
    {
        static void Main(string[] args)
        {
            //ListStatistics listStats = new ListStatistics(new TimeResults());
            //listStats.Run();

            //DictionaryStatistics dictStats = new DictionaryStatistics();
            //dictStats.Run();

            CountsService countService = new CountsService(50000, 5000);
            ConsoleOutputService outputService = new ConsoleOutputService();

           IStatsExecutor listExecutor = new StatsExecutor(new TimeResults(),
                new ListClass(),
                outputService,
                countService);
            outputService.WriteMessage("Testing for List<int>");
            listExecutor.Run();

            IStatsExecutor dictExecutor = new StatsExecutor(new TimeResults(),
               new DictionaryClass(),
               outputService,
               countService);
            outputService.WriteMessage("Testing for Dictionary<int, int>");
            dictExecutor.Run();

            Console.Read();
        }
    }
}
