using Microsoft.AspNetCore.Mvc;

namespace DefianceBackendAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SystemController : ControllerBase
{
    [HttpGet("ping")]
    public IActionResult Ping()
    {
        return Ok(new { status = "ok", message = "Defiance API online" });
    }
}
