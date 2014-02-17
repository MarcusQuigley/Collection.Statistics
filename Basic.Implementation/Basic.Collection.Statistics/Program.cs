using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Basic.Collection.Statistics
{
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
            StatsExecutor listExecutor = new StatsExecutor(new TimeResults(),
                new ListClass(),
                outputService,
                countService);

            listExecutor.Run();

            StatsExecutor dictExecutor = new StatsExecutor(new TimeResults(),
               new DictionaryClass(),
               outputService,
               countService);

            dictExecutor.Run();

            Console.Read();
        }
    }
}
