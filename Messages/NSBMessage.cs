using NServiceBus;

namespace Messages
{
    public class NSBMessage : IMessage
    {
        public string Data { get; set; }
        public string Prop { get; set; }
    }
}