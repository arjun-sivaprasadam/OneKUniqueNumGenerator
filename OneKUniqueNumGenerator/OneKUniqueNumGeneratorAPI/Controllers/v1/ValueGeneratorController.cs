using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
using OneKUniqueNumGeneratorAPI.Logic;

namespace OneKUniqueNumGeneratorAPI.Controllers.v1;

[Route("api/v1/[controller]")]
[ApiController]
public class ValueGeneratorController : ControllerBase
{
    // GET: api/v1/ValueGenerator
    /// <summary>
    /// This API will generate and provide 1000 random numbers ranging in between 0 and 65535.
    /// </summary>
    /// <returns>List of 1k random numbers</returns>
    [HttpGet]
    public ActionResult<IEnumerable<ushort>> Get()
    {
        try
        {
            return Ok(UniqueNumberGenerator.GetRandomNumbers());
        }
        catch (Exception)
        {
            // TODO - Logic to log this exception to logfile.

            return BadRequest();
        }
    }
}
