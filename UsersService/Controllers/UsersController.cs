using Microsoft.AspNetCore.Mvc;

namespace UsersService.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController : ControllerBase
{
    [HttpGet]
    public IActionResult GetUsers() => Ok(new[] { new { Id = 1, Name = "Milan" } });
}