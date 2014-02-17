using System;
namespace Collection.Statistics.InterfacesLibrary
{
   public interface ICollectionBase
    {
        Collection.Statistics.CommonTypesLib.RandomInsertTimes AddRandomEntries(int count);
        void AddRandomEntry(int count);
        TimeSpan AddSequentialEntries(int count);
        void AddSequentialEntry(int count);
        TimeSpan RetrieveByKey();
        int RetrieveKey();
    }
}
