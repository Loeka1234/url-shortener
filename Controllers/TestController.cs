using Microsoft.AspNetCore.Mvc;

namespace URLShortener.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class TestController : ControllerBase
  {
    [HttpGet]
    public string Get()
    {
      return "TestController working";
    }
  }
}