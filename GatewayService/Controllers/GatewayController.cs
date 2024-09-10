using Microsoft.AspNetCore.Mvc;

namespace GatewayService.Controllers; 

[ApiController]
[Route("api/[controller]")]
public class GatewayController: ControllerBase{
    [HttpGet("identity")]
    public async Task<IActionResult> GetIdentityInfo(){
        using (var client = new HttpClient()){
            var response = await client.GetAsync("signup url"); // http://identityservice/api/identity/signup
            var content = await response.Content.ReadAsStringAsync();
            return Ok(content);
        }
    }
}