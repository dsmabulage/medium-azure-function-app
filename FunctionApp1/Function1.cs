using System.IO;
using System.Threading.Tasks;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace FunctionApp1
{
    public class Function1
    {
        private readonly ILogger<Function1> _logger;

        public Function1(ILogger<Function1> logger)
        {
            _logger = logger;
        }

        [Function(nameof(Function1))]
        public async Task Run([BlobTrigger("test/{name}", Connection = "CONN_STRING")] Stream stream, string name)
        {
           _logger.LogInformation("Deployment with Zip upload");
            _logger.LogInformation($"C# Blob trigger function Processed blob Name: {name}");
        }
    }
}
