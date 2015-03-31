using NServiceBus;

namespace Messages
{
    public class NativeIntegrationMessage : IMessage
    {
        public string Text { get; set; }
    }
}