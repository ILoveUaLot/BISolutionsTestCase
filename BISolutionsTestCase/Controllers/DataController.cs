using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using LinkedList;
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

        [HttpPost("CheckPalindrom")]
        public IActionResult PalindromCheckController([FromBody]string str)
        {
            string normalizedStr = str.ToLower(); // To lower for check equals of symbols
            string reversedString = new string(normalizedStr.Reverse().ToArray());
            return Ok(str.Equals(reversedString));
        }

        [HttpPost("SortingIntegralNumbers")]
        public IActionResult SortingNumbers([FromBody] int[] numbers)
        {
            if(numbers.Length == 0 || numbers == null) return BadRequest();
            LinkedList.LinkedList<int> list = new LinkedList.LinkedList<int>();
            foreach (var item in numbers)
            {
                list.Add(item);
            }
            list.InsertionSort();
            return Ok(list.GetValues());
        }
    }
}
