using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Test_Stavitskii.Classes;
using Test_Stavitskii.Responses;

namespace Test_Stavitskii.Controllers
{
    [Route("api/[controller]")]
    public class ListOfOrdersController : Controller
    {
       [HttpGet]
        public IActionResult GetRequestToken()
        {
            var order = Authentication.Order();
            return Json(order.Result);
        }
    }
}
