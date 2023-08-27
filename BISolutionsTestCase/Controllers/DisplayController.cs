﻿using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> GetSumOfOddNumbers(int[] nums)
        {
            var client = _client.CreateClient("PostingDataClient");
            HttpResponseMessage response = await client.PostAsJsonAsync("AddNumbers", nums);
            var result = response.Content.ReadAsStringAsync();
            return Ok(result);
        }


    }
}
