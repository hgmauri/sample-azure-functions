using System;
using Microsoft.Azure.Functions.Worker.Pipeline;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace Sample.AzureFunctions.DotNet5.Functions
{
    public static class FunctionTimerTrigger
    {
        [FunctionName(nameof(FunctionTimerTrigger))]
        public static void Run([TimerTrigger("0 */1 * * * *")] MyInfo timerInfo, FunctionExecutionContext executionContext)
        {
            var log = executionContext.Logger;

            log.LogInformation($"C# Timer trigger function executed at: {timerInfo?.ScheduleStatus?.Next}, next: {timerInfo?.ScheduleStatus?.Last}");
        }
        public class MyInfo
        {
            public MyScheduleStatus ScheduleStatus { get; set; }

            public bool IsPastDue { get; set; }
        }

        public class MyScheduleStatus
        {
            public DateTime Last { get; set; }

            public DateTime Next { get; set; }

            public DateTime LastUpdated { get; set; }
        }
    }
}

