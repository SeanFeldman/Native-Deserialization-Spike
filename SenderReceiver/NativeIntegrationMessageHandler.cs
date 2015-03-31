using Messages;
using NServiceBus;
using NServiceBus.Logging;

namespace SenderReceiver
{
    public class NativeIntegrationMessageHandler : IHandleMessages<NativeIntegrationMessage>
    {
        private ILog logger = LogManager.GetLogger<StartStopLogger>();

        public void Handle(NativeIntegrationMessage message)
        {
            logger.Info("Received 3rd party message: " + message.Text);    
        }
    }
}