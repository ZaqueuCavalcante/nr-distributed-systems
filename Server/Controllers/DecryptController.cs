using Shared;
using Serilog;
using Microsoft.AspNetCore.Mvc;

namespace Server.Controllers;

[ApiController]
[Consumes("application/json"), Produces("application/json")]
public class DecryptController : ControllerBase
{
    /// <summary>
    /// Decrypt
    /// </summary>
    [HttpPost("decrypt")]
    public async Task<IActionResult> Decrypt([FromBody] DecryptIn data)
    {
        await Task.Delay(0);

        var result = Decrypt(data.Encrypted, 9);

        Log.Information("{0} -> {1}", data.Encrypted, result);

        return Ok(new DecryptOut { Encrypted = data.Encrypted, Message = result });
    }

    private static string Decrypt(string input, int key)
    {
        var chars = Enumerable.Range(Convert.ToInt32('a'), 26).Select(Convert.ToChar).ToArray();
        Array.Reverse(chars);

        var decryptedText = string.Empty;
        foreach (char c in input)
        {
            var ch = c;

            if (char.IsLetter(ch))
            {
                var isUpper = char.IsUpper(ch);

                ch = char.ToLower(ch);
                ch = GetCharWithStepAndWrap(chars, ch, key);

                if (isUpper)
                {
                    ch = char.ToUpper(ch);
                }
            }

            decryptedText += ch;
        }

        return decryptedText;
    }

    private static char GetCharWithStepAndWrap(char[] chars, char ch, int step)
    {
        var index = Array.IndexOf(chars, ch);

        index += step;
        index %= chars.Length;

        return chars[index];
    }
}
