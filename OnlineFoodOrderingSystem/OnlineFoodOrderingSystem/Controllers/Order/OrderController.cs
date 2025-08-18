using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OnlineFoodOrderingSystem.Models;

namespace OnlineFoodOrderingSystem.Controllers.Order
{

    [Authorize]
    [Route("api/[controller]")]
    [ApiController]

    public class OrderController : ControllerBase
    {

        [HttpGet("secure")]

        public IActionResult GetSecureData()
        {
            return Ok("You accessed a protected endpoint!");
        }


        [HttpGet("OrderStatus")]
        [Authorize(Roles ="Admin")]
        [Authorize(Roles = "Chef")]
        public IActionResult OrderStatus()
        {
            return Ok("Return Order Status");
        }






    }
}
