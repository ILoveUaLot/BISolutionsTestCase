using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BISolutionsTestCase.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisplayController : ControllerBase
    {
        IHttpClientFactory _client;
        public DisplayController(IHttpClientFactory client)
        {
            _client = client;
        }


        [HttpGet("displaySum")]
        public async Task<IActionResult> GetSumOfOddNumbers([FromQuery]int[] nums)
        {
            var client = _client.CreateClient("PostingDataClient");
            HttpResponseMessage response = await client.PostAsJsonAsync($"{client.BaseAddress}/AddNumbers", nums);
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync();
                return Ok(result.Result);
            }
            return BadRequest();
        }

        [HttpGet("displayPalindrom")]
        public async Task<IActionResult> GetPalindromCheckResult([FromQuery] string str)
        {
            var client = _client.CreateClient("PostingDataClient");
            HttpResponseMessage response = await client.PostAsJsonAsync($"{client.BaseAddress}/CheckPalindrom", str);
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync();
                return Ok(result.Result);
            }
            return BadRequest();
        }

        [HttpGet("displaySortedNumbers")]
        public async Task<IActionResult> GetSortingNumbers([FromQuery] int[] nums)
        {
            var client = _client.CreateClient("PostingDataClient");
            HttpResponseMessage response = await client.PostAsJsonAsync($"{client.BaseAddress}/SortingIntegralNumbers", nums);
            if (response.IsSuccessStatusCode)
            {
                var result = response.Content.ReadAsStringAsync();
                return Ok(result.Result);
            }
            return BadRequest();
        }
    }
}
