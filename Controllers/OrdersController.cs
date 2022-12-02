using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Web.Resource;

namespace Projects.Controllers;

[ApiController]
[Route("[controller]")]
[Authorize]
public class OrdersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllOrders()
    {
        return Ok(new[] {"Order 1", "Order 2"});
    }
}