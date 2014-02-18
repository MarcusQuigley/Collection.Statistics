using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//using Collection.Statistics.OutputLibrary;
using Rhino.Mocks;
using Collection.Statistics.InterfacesLibrary;
namespace OutputLibrary.Tests
{
    [TestClass]
    public class ConsoleOutputServiceTests
    {
        [TestMethod]
        public void WriteMessage_Always_CallsConsoleWrite()
        {
            string message = "Test";
            IConsoleOutputService consoleOutputStub = MockRepository.GenerateStub<IConsoleOutputService>();

            consoleOutputStub.Expect(c=>c.WriteMessage(message));

            consoleOutputStub.VerifyAllExpectations();
 
        }
    }
}
