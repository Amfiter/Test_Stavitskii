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
            
            /*for (int i = 0; i < order.Result.Count; i++)
            {
                var orderList = new Result()
                {
                    Id = order.Result[i].Id,
                };
                
            }*/

            return Json(order.Result);
        }
    }
}