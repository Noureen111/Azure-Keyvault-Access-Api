using Azure.Security.KeyVault.Secrets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace keyvaults.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VaultController : ControllerBase
    {
        private readonly SecretClient _secretClient;

        public VaultController(SecretClient secretClient) 
        { 
            _secretClient = secretClient;
        }

        [HttpGet("secret")]
        public async Task<IActionResult> GetSecret()
        {
            try
            {
                var secret = await _secretClient.GetSecretAsync("secret");
                return Ok(secret?.Value.Value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
