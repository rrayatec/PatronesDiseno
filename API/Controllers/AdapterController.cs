using Microsoft.AspNetCore.Mvc;
namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class AdapterController : ControllerBase
{

    [HttpGet]
    public string Get()
    {
        

        return "Hola";
    }
}
