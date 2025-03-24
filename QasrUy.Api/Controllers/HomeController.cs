using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace QasrUy.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
       public ActionResult<string> Get()=>
            Ok("Hello, Mario. The princes is in another castle.");
    }
}
