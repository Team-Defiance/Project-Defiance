using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DefianceBackendAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ImportController : ControllerBase
{
    [Authorize(AuthenticationSchemes = "ApiKey")]
    [HttpPost("bulk-update")]
    public IActionResult BulkUpdate([FromBody] object payload)
    {
        // Later: validate, map, insert/update Mongo
        return Ok(new { status = "accepted", size = payload?.ToString()?.Length });
    }
}
