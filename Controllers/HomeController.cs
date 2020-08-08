using Microsoft.AspNetCore.Mvc;
namespace Razor_Fun
{
  public class RazorController : Controller
  {
    [HttpGet("")]
    public ViewResult Food()
    {
      return View();
    }
  }
}