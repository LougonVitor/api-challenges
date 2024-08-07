using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FirstApiChallenge02.Communication.Requests;
using FirstApiChallenge02.Communication.Response;

namespace FirstApiChallenge02.Controllers;

[Route("api/[controller]")]
[ApiController]
public abstract class BookBaseController : ControllerBase
{
    public List<ResponseRegisterBookJson> books = new List<ResponseRegisterBookJson>();

    [HttpGet("heathy")]
    protected IActionResult Heathy()
    {
        return Ok("It's Working!");
    }

    protected string GetCustomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
}