using System.IO;
using System.Reflection;
using NServiceBus;
using NServiceBus.Features;
using NServiceBus.Logging;

namespace SenderReceiver
{
    public class EndpointConfig : IConfigureThisEndpoint
    {
        public void Customize(BusConfiguration configuration)
        {
            configuration.DisableFeature<TimeoutManager>();
            configuration.DisableFeature<SecondLevelRetries>();
            configuration.DisableFeature<AutoSubscribe>();

            configuration.EndpointName("serialization-spike");
            configuration.UsePersistence<InMemoryPersistence>();
            configuration.UseTransport<AzureStorageQueueTransport>();

            var defaultLogFactory = LogManager.Use<DefaultFactory>();
            defaultLogFactory.Level(LogLevel.Debug);
            defaultLogFactory.Directory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            // Default: JSON.NET
            // XML
            //configuration.UseSerialization<XmlSerializer>();
        }
    }
}

