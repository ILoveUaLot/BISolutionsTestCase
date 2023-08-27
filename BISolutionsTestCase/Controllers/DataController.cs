using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BISolutionsTestCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        [HttpPost("AddNumbers")]
        public IActionResult SumOddNumbers([FromBody] int[] numbers)
        {
            int sum = 0;
            for (int i = 1; i < numbers.Length; i += 2)
            {
                if (numbers[i] % 2 != 0)
                {
                    sum += numbers[i];
                }
            }
            return Ok(Math.Abs(sum));
        }
    }
}
