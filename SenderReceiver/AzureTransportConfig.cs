using NServiceBus.Config;
using NServiceBus.Config.ConfigurationSource;

namespace SenderReceiver
{
    class AzureTransportConfig : IProvideConfiguration<AzureQueueConfig>
    {
        public AzureQueueConfig GetConfiguration()
        {
            return new AzureQueueConfig
            {
                ConnectionString = "UseDevelopmentStorage=true"
            };
        }
    }
}