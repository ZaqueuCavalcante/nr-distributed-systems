using Shared;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[ApiController]
[Consumes("application/json"), Produces("application/json")]
public class EchoController : ControllerBase
{
    /// <summary>
    /// Echo
    /// </summary>
    [HttpPost("echo")]
    public async Task<IActionResult> Echo([FromBody] EchoIn data)
    {
        await Task.Delay(0);

        return Ok(new EchoOut { Message = data.Message });
    }
}
