using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BISolutionsTestCase.Controllers
{
    [Route("api/PalindromCheck")]
    [ApiController]
    public class PalindromCheckController : ControllerBase
    {
        [HttpGet]
        public IActionResult PalindromCheck(string str)
        {
            string normalizedStr = str.ToLower(); // To lower for check equals of symbols
            string reversedString = new string(normalizedStr.Reverse().ToArray());

            if (normalizedStr == reversedString)
            {
                return Ok(true);
            }
            else
            {
                return Ok(false);
            }
        }
    }
}
