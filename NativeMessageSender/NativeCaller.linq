<Query Kind="Program">
  <NuGetReference>Newtonsoft.Json</NuGetReference>
  <NuGetReference>WindowsAzure.Storage</NuGetReference>
  <Namespace>Microsoft.WindowsAzure</Namespace>
  <Namespace>Microsoft.WindowsAzure.Storage</Namespace>
  <Namespace>Microsoft.WindowsAzure.Storage.Queue</Namespace>
  <Namespace>Newtonsoft.Json</Namespace>
  <Namespace>System.Runtime.Serialization.Formatters</Namespace>
</Query>

void Main()
{
	var account = CloudStorageAccount.DevelopmentStorageAccount;
	var client = account.CreateCloudQueueClient();
	
	var queue = client.GetQueueReference("serialization-spike");
	var message = new CloudQueueMessage(@"{'$type':'NativeIntegrationMessage', 'Text': 'native msg @ " + DateTime.Now.ToString("HH:mm:ss") + "'}");
	queue.AddMessage(message);
	Console.WriteLine ("TestIt message added to queue " + client.StorageUri.PrimaryUri);
	Console.WriteLine (Assembly.GetExecutingAssembly().CodeBase);
}