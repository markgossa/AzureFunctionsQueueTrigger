using System;
using Microsoft.Azure.WebJobs;
using Newtonsoft.Json.Linq;
using Microsoft.Extensions.Logging;

namespace QueueTrigger
{
    public static class QueueTrigger
    {
        [FunctionName("QueueTrigger")]
        public static void Run([QueueTrigger(queueName:"queue1", Connection = "AZURE_QUEUE_CONNECTION_STRING")]string inputObject, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {inputObject}");

            Console.WriteLine(inputObject);
        }
    }
}
