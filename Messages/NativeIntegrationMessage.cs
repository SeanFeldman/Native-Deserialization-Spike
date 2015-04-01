using NServiceBus;

namespace Messages
{
    public class NativeIntegrationMessage : IMessage
    {
        public string Text { get; set; }
    }
}

// ReSharper disable once InconsistentNaming
    public class java_x_nim : IMessage
    {
        public string Text { get; set; }
    }
