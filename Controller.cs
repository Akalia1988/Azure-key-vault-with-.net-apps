using AzureKeyVaultLabs.Demo.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;

namespace AzureKeyVaultLabs.Demo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public CustomerController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        [Route("get-settings")]
        public IActionResult GetSettings()
        {
            var settings = new Settings
            {
                AppName = _configuration["Settings-AppName"],
                Language = _configuration["Settings-Language"],
                Messages = _configuration["Settings-Messages"]
            };

            return Ok(settings);
        }
    }
}