using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OneKUniqueNumGeneratorAPI.Controllers;
[Route("api/[controller]")]
[ApiController]
public class ValueGeneratorController : ControllerBase
{
    // GET: api/<ValueGeneratorController>
    [HttpGet]
    public IEnumerable<string> Get()
    {
        return new string[] { "value1", "value2" };
    }
}
