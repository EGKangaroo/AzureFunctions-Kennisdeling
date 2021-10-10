using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace AzureFunctions_Kennisdeling
{
    public static class ReadFromQueue
    {
        [FunctionName("ReadFromQueue")]
        public static void Run([ServiceBusTrigger("azqueue")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# ServiceBus queue trigger function processed message: {myQueueItem}");
        }
    }
}
