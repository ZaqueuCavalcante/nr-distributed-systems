using Shared;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[ApiController]
[Consumes("application/json"), Produces("application/json")]
public class NowController : ControllerBase
{
    /// <summary>
    /// Now
    /// </summary>
    [HttpGet("now")]
    public async Task<IActionResult> Now()
    {
        await Task.Delay(0);

        return Ok(new NowOut { Now = DateTime.Now.ToString() });
    }
}
