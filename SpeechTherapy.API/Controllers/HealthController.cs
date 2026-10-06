
using Microsoft.AspNetCore.Mvc;

namespace SpeechTherapy.API.Controllers;

[ApiController]
[Route("api/health")]
public class HealthController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new { message = "API çalışıyor." });
    }
}