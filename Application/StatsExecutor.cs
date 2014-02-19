using Collection.Statistics.InterfacesLibrary;
using System.Collections.Generic;
using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System.Configuration;

namespace Collection.Statistics.Application
{
    public class StatsExecutor : IStatsExecutor
    {
        private List<ICollectionBase> collectionObjects;
        private IConsoleOutputService outputObject;

        public StatsExecutor(IConsoleOutputService output)
        {
            UnityContainer container = new UnityContainer();
            UnityConfigurationSection configSection = (UnityConfigurationSection)ConfigurationManager.GetSection("unity");
            configSection.Containers.Default.Configure(container);

            this.collectionObjects = new List<ICollectionBase>(container.ResolveAll<ICollectionBase>());
            this.outputObject = output;
        }

        public void Run()
        {
            foreach (ICollectionBase item in collectionObjects)
            {
                ICollectionExecute executeObject = new CollectionExecute(item, outputObject);
                executeObject.Execute();
            }
        }
    }
}
