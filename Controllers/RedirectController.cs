using System;
using Microsoft.AspNetCore.Mvc;

namespace URLShortener.Controllers
{
  [ApiController]
  [Route("/")]
  public class RedirectController : ControllerBase
  {
    [HttpGet("/{path}")]
    public RedirectResult GetRedirect(string path)
    {
      Console.WriteLine(path);
      return RedirectPermanent("https://www.google.com");
    }
  }
}