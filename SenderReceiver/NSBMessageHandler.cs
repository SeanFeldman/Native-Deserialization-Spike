using Messages;
using NServiceBus;
using NServiceBus.Logging;

namespace SenderReceiver
{
    public class NSBMessageHandler : IHandleMessages<NSBMessage>
    {
        private ILog logger = LogManager.GetLogger<StartStopLogger>();

        public void Handle(NSBMessage message)
        {
            logger.Info("Received NSBMessage message: " + message.Data);    
        }
    }
}