using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Rhino.Mocks;
using Collection.Statistics.InterfacesLibrary;
namespace CollectionTypesLibrary.Tests
{
    [TestClass]
    public class CollectionBaseTests
    {
        [TestMethod]
        public void AddSequentialEntries_Called_AddSequentialEntry()
        {
            int count = 10;
            ICollectionBase collectionStub = MockRepository.GenerateStub<ICollectionBase>();
            collectionStub.AddSequentialEntries(count);
            collectionStub.Expect(c => c.AddSequentialEntry(count));

             collectionStub.VerifyAllExpectations();
        }

        [TestMethod]
        public void AddSequentialEntries_NotCalled_AddSequentialEntry()
        {
            int count = 0;
            ICollectionBase collectionStub = MockRepository.GenerateStub<ICollectionBase>();
            collectionStub.AddSequentialEntries(count);
            //collectionStub.Expect(c => c.AddSequentialEntry(count));

            collectionStub.AssertWasNotCalled(c => c.AddSequentialEntry(count));
        }

        //public TimeSpan AddSequentialEntries(int count)
        //{
        //    Stopwatch stopWatch = new Stopwatch();
        //    stopWatch.Start();

        //    for (int i = 0; i < count; i++)
        //    {
        //        AddSequentialEntry(i);
        //    }

        //    stopWatch.Stop();
        //    return stopWatch.Elapsed;
        //}
    }
}
