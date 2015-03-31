using System;
using System.Globalization;
using NServiceBus;
using NServiceBus.Logging;

namespace SenderReceiver
{
    class StartStopLogger : IWantToRunWhenBusStartsAndStops
    {
        private ILog logger = LogManager.GetLogger<StartStopLogger>();
        public IBus Bus { get; set; }

        public void Start()
        {
            logger.Info("Started bus");
        }

        public void Stop()
        {
            logger.Info("Stopped bus");
        }
    }
}