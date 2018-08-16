
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;

using Alexa.NET;
using Alexa.NET.Request;
using Alexa.NET.Request.Type;

namespace AlaskaAir.AskTheDso
{
    public static class AskTheDsoFunction
    {
        [FunctionName("AskTheDsoFunction")]
        public static IActionResult Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]SkillRequest req, ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            if (req.Request is LaunchRequest)
            {
                return new OkObjectResult(ResponseBuilder.Tell("you launched from method param"));
            }

            return new OkObjectResult(ResponseBuilder.Empty());;
        }
    }
}
