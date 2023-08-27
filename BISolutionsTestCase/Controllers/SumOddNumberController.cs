using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BISolutionsTestCase.Controllers
{
    [Route("api/SumOddNumber")]
    [ApiController]
    public class SumOddNumberController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetSumOfOddNumber(List<int> ints)
        {
            int OddCounter = 0;
            int sum = 0;
            for (int i = 0; i < ints.Count; i++)
            {
                if (ints[i] % 2 == 1)
                {
                    OddCounter++;
                    if (OddCounter % 2 == 0) sum += ints[i];
                }
            }
            return Ok(Math.Abs(sum));
        }
    }
}
