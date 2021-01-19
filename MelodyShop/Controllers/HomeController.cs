using System.Web.Mvc;

namespace MelodyShop.Controllers
{
  public class HomeController : Controller
  {
    public ActionResult Index()
    {
      return View();
    }

    public ActionResult About()
    {
      ViewBag.Message = "O mnie";

      return View();
    }

    public ActionResult Contact()
    {
      ViewBag.Message = "Kontakt";

      return View();
    }
  }
}