using Microsoft.AspNetCore.Mvc;

namespace AutoMapper.Controllers;



[ApiController]
[Route("api/[controller]")]
public class UserControlle: ControllerBase
{
    [HttpGet]
    public IActionResult GetUser()
    {
        
        return Ok();
    }
    
    
}