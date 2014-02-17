using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Collection.Statistics.InterfacesLibrary;

namespace Collection.Statistics.OutputLibrary
{
  public  class ConsoleOutputService : IConsoleOutputService
    {
      public void WriteMessage(string message)
      {
          Console.WriteLine(message);
      }
    }
}
