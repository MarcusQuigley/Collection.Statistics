using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Basic.Collection.Statistics
{
    public class StatsExecutor
    {
        private TimeResults timeResults;
        private CollectionBase collectionObject;
        private ConsoleOutputService outputService;
        private CountsService counts;

        public StatsExecutor(TimeResults timeResults,
            CollectionBase collection,
            ConsoleOutputService outputService,
            CountsService countsService)
        {
            this.timeResults = timeResults;
            this.collectionObject = collection;
            this.outputService = outputService;
            this.counts = countsService;
        }


        public void Run()
        {
             timeResults.SequentialInsertsTime = collectionObject.AddSequentialEntries(counts.SeqEntriesCount);
            timeResults.RandomInsertsTime = collectionObject.AddRandomEntries(counts.RanEntriesCount);
            timeResults.RetrieveTime = collectionObject.RetrieveByKey();

            OutputResults();
        }

        void OutputResults()
        {
            outputService.WriteMessage(string.Format(
                "Time for {0} Sequential entries = {1}ms",
                counts.SeqEntriesCount, timeResults.SequentialInsertsTime.TotalMilliseconds));
            outputService.WriteMessage(string.Format(
                 "Time for {0} Random entries = {1}ms",
                 counts.RanEntriesCount, timeResults.RandomInsertsTime.RandomInsertTime.TotalMilliseconds));
            outputService.WriteMessage(string.Format(
               "Time for each random insertion = {0}ms", timeResults.RandomInsertsTime.IndividualInsertTime));
            outputService.WriteMessage(string.Format(
               "Time for retrieve key = {0}ms", timeResults.RetrieveTime.TotalMilliseconds));
            outputService.WriteMessage("------------\n");
        }

    }
}
