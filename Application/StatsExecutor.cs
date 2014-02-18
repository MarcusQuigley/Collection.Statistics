using System;
using Collection.Statistics.CommonTypesLib;
using Collection.Statistics.CollectionTypesLibrary;
using Collection.Statistics.OutputLibrary;
using Collection.Statistics.InterfacesLibrary;

namespace Collection.Statistics.Application
{
    public class StatsExecutor  : IStatsExecutor
    {
        private TimeResults timeResults;
        private ICollectionBase collectionObject;
        private IConsoleOutputService outputService;
        private CountsService counts;

        public StatsExecutor(TimeResults timeResults,
            ICollectionBase collection,
            IConsoleOutputService outputService,
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
