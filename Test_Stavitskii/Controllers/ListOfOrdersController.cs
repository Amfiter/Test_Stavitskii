using Microsoft.AspNetCore.Mvc;
using Test_Stavitskii.Classes;
using Test_Stavitskii.Responses;

namespace Test_Stavitskii.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ListOfOrdersController : Controller
    {
       
        public IActionResult GetRequestToken()
        {
          
            return Ok(Authentication.Order());
        }
    }
}