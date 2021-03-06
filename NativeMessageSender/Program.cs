﻿using System;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Queue;

namespace NativeMessageSender
{
    static class NativeMessageSender
    {
        static void Main(string[] args)
        {
            var account = CloudStorageAccount.DevelopmentStorageAccount;
            var client = account.CreateCloudQueueClient();

            var queue = client.GetQueueReference("serialization-spike");

            Console.WriteLine("press any key to send a message, ESC to exit.");

            while (Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                // JSON.NET
                var message = new CloudQueueMessage(@"{'$type':'Messages.NativeIntegrationMessage', 'Text': 'native msg @ " + DateTime.Now.ToString("HH:mm:ss") + "'}");
                // XML
                //var message = new CloudQueueMessage(@"<Messages.NativeIntegrationMessage><Text>hello from linqpad " + DateTime.Now.ToString("HH:mm:ss") + "</Text></Messages.NativeIntegrationMessage>");
                queue.AddMessage(message);
                Console.WriteLine("TestIt message added to queue " + client.StorageUri.PrimaryUri);
            }
        }
    }
}
