using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Collection.Statistics.CommonTypesLib;
using Collection.Statistics.InterfacesLibrary;

namespace Collection.Statistics.Application
{
    public class CollectionExecute : Collection.Statistics.InterfacesLibrary.ICollectionExecute
    {
        private TimeResults timeResults;
        private CountsService counts;
        public ICollectionBase CollectionObject { get; set; }
        public IConsoleOutputService OutputService { get; set; }

        public CollectionExecute(
            ICollectionBase collection, IConsoleOutputService output
           )
        {
            CollectionObject = collection;
            OutputService = output;

            this.counts = new CountsService(50000, 5000);
            this.timeResults = new TimeResults();
        }

        public void Execute()
        {
            OutputService.WriteMessage(string.Format("Starting test for {0} --------------", CollectionObject.Name));

            timeResults.SequentialInsertsTime = CollectionObject.AddSequentialEntries(counts.SeqEntriesCount);
            timeResults.RandomInsertsTime = CollectionObject.AddRandomEntries(counts.RanEntriesCount);
            timeResults.RetrieveTime = CollectionObject.RetrieveByKey();

            OutputResults();
        }

        void OutputResults()
        {
            OutputService.WriteMessage(string.Format(
                "Time for {0} Sequential entries = {1}ms",
                counts.SeqEntriesCount, timeResults.SequentialInsertsTime.TotalMilliseconds));
            OutputService.WriteMessage(string.Format(
                 "Time for {0} Random entries = {1}ms",
                 counts.RanEntriesCount, timeResults.RandomInsertsTime.RandomInsertTime.TotalMilliseconds));
            OutputService.WriteMessage(string.Format(
               "Time for each random insertion = {0}ms", timeResults.RandomInsertsTime.IndividualInsertTime));
            OutputService.WriteMessage(string.Format(
               "Time for retrieve key = {0}ms", timeResults.RetrieveTime.TotalMilliseconds));
            OutputService.WriteMessage("------------\n");
        }

    }
}
