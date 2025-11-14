using Microsoft.AspNetCore.Mvc;

namespace DefianceBackendAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UnitsController : ControllerBase
{
    [HttpGet]
    public IActionResult GetAllUnits()
    {
        // Later: query MongoDB
        return Ok(new[] { "placeholder_unit" });
    }
    [HttpGet]
    [Route("{id:int}")]
    public IActionResult GetUnitById([FromRoute]int id)
    {
        // Later: query MongoDB
        return Ok(new[] { "placeholder_unit" });
    }
    
}
