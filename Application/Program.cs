using System;
using Collection.Statistics.InterfacesLibrary;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

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
            UnityContainer container = new UnityContainer();

            UnityConfigurationSection configSection = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            configSection.Containers.Default.Configure(container);

            IStatsExecutor executor = container.Resolve<IStatsExecutor>();

            executor.Run();

            Console.Read();
        }
    }
}
