using System;
using System.IO;
using System.Reflection;
using Messages;
using NServiceBus;
using NServiceBus.Features;
using NServiceBus.Logging;

namespace NSBMessageSender
{
    static class NSBMessageSernderProgram
    {
        static void Main(string[] args)
        {
            var config = new BusConfiguration();

            config.DisableFeature<TimeoutManager>();
            config.DisableFeature<SecondLevelRetries>();
            config.DisableFeature<AutoSubscribe>();

            config.EndpointName("serialization-spike-nsb-sender");
            config.UseTransport<AzureStorageQueueTransport>()
                            .ConnectionString("UseDevelopmentStorage=true");
            config.UsePersistence<InMemoryPersistence>();
            config.EnableInstallers();
            config.DefineCriticalErrorAction((s, exception) => Console.WriteLine("Critical error: \"{0}\" with exception: {1}", s, exception));

            var defaultLogFactory = LogManager.Use<DefaultFactory>();
            defaultLogFactory.Directory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));

            // Default: JSON.NET
            // XML
            //config.UseSerialization<XmlSerializer>();

            var bus = Bus.Create(config).Start();

            Console.WriteLine("press any key to send a message, ESC to exit.");

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                var command = new NSBMessage { Data = "hello from NSBSender " + DateTime.Now.ToString("HH:mm:ss"), Prop = DateTime.Now.ToString("HH:mm:ss") };
                bus.Send("serialization-spike", command);
                Console.WriteLine("Message sent");    
            }
        }
    }
}
