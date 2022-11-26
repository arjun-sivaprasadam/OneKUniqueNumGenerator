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
    public async Task<ActionResult<IEnumerable<ushort>>> Get()
    {
        try
        {
            var output = await UniqueNumberGenerator.Get1KMubersInRandomOrder();
            return Ok(output);
        }
        catch (Exception ex)
        {
            // TODO - Logic to log this exception to logfile.

            return BadRequest();
        }
    }
}
