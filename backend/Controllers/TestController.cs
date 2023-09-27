using Microsoft.AspNetCore.Mvc;

namespace backend.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class TestController : ControllerBase
{

    public TestController()
    {
    }

    [HttpGet(Name = "IsAlive")]
    public bool IsAlive()
    {
        return true;
    }
}
