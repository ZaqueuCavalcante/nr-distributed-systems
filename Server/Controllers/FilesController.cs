using Serilog;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[ApiController]
[Produces("application/json")]
public class FilesController : ControllerBase
{
    /// <summary>
    /// Files
    /// </summary>
    [HttpPost("files")]
    public async Task<IActionResult> Files([FromForm] IFormFile file)
    {
        var stream = System.IO.File.OpenWrite(file.FileName);
        await file.CopyToAsync(stream);

        stream.Close();

        Log.Information("Arquivo recebido com sucesso: {0}", file.FileName);

        return Ok();
    }
}
