using Microsoft.AspNetCore.Mvc;
using Log.Models;

namespace Log.Controllers

{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}