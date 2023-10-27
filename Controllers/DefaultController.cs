using Microsoft.AspNetCore.Mvc;

namespace GraphQL.Dotnet.Controllers
{
    [ApiController]
    [Route("/")]
    public class DefaultController : ControllerBase
    {


        public DefaultController() { }

        [HttpGet]
        public string Get()
        {
            return "Please refer to the /graphql or /ui/playground endpoints";
        }
    }
}