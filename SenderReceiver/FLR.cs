using NServiceBus.Config;
using NServiceBus.Config.ConfigurationSource;

namespace SenderReceiver
{
    class FLR : IProvideConfiguration<TransportConfig>
    {
        public TransportConfig GetConfiguration()
        {
            return new TransportConfig
            {
                MaxRetries = 3
            };
        }
    }
}