using Microsoft.AspNetCore.Mvc;

namespace FridayProject.Controllers
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