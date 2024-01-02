using Microsoft.AspNetCore.Mvc;

namespace RecapApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RecapController : ControllerBase
{

    [HttpGet]
    public ActionResult GetHello()
    {
        return Ok("Hello World");

    }
}
