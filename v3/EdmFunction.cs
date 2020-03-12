using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.Edm.Library;
using Microsoft.Extensions.Logging;

namespace AzureFunctionsWithEdm
{
    public static class EdmFunction
    {
        [FunctionName("EdmFunction")]
        public static Task<IActionResult> Run([HttpTrigger(AuthorizationLevel.Function, "GET", Route = null)] HttpRequest req, ILogger log)
        {
            EdmModelBase x = null;
            return Task.FromResult<IActionResult>(new OkResult());
        }
    }
}
