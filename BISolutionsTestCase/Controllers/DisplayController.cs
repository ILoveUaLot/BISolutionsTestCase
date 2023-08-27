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

    }
}
