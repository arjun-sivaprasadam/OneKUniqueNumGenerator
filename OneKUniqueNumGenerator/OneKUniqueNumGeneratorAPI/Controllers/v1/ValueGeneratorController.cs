using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace OneKUniqueNumGeneratorAPI.Controllers.v1;
[Route("api/v1/[controller]")]
[ApiController]
public class ValueGeneratorController : ControllerBase
{
    // GET: api/v1/ValueGenerator
    [HttpGet]
    public ActionResult<IEnumerable<string>> Get()
    {
        return Ok(new string[] { "value1", "value2" });
    }
}
