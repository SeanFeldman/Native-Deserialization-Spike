using System;
using System.Collections.Generic;
using Messages;
using NServiceBus;
using NServiceBus.Pipeline;
using NServiceBus.Pipeline.Contexts;

namespace SenderReceiver.Feature
{
//    class SpecifySupportedNativeTypesBehavior : IBehavior<IncomingContext>
//    {
//        public void Invoke(IncomingContext context, Action next)
//        {
//            var transportMessage = context.PhysicalMessage;
//            if (!IsControlMessage(transportMessage.Headers) && IsNativeMessage(transportMessage.Headers))
//            {
//                transportMessage.Headers[Headers.EnclosedMessageTypes] = typeof (NativeIntegrationMessage).FullName + "; " +
//                                                                         typeof (NativeIntegrationMessageAlso).FullName;
//            }
//            next();
//        }
//
//        private bool IsNativeMessage(Dictionary<string, string> headers)
//        {
//            return headers!= null && !headers.ContainsKey(Headers.EnclosedMessageTypes);
//        }
//
//        private bool IsControlMessage(Dictionary<string, string> headers)
//        {
//            return headers != null && headers.ContainsKey(Headers.ControlMessageHeader);
//        }
//
//        public class SetMessageTypeForDeserializationRegistration : RegisterStep
//        {
//            public SetMessageTypeForDeserializationRegistration()
//                : base("SpecifySupportedNativeTypesBehavior", typeof(SpecifySupportedNativeTypesBehavior), "Specify supported native types")
//            {
//                InsertBefore(WellKnownStep.DeserializeMessages);
//            }
//        }
//    }
}