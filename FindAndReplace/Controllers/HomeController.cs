using Microsoft.AspNetCore.Mvc;
using FindAndReplace.Models;

namespace FindAndReplace.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      string fakeString = "";
      return View("Index");
    }
    [HttpPost("/result")]
    public ActionResult Result()
    {
      string inputString = Request.Form["input-string"];
      string findString = Request.Form["find-string"];
      string replaceString = Request.Form["replace-string"];
      FindAndReplaceGenerator newFindAndReplaceGenerator = new FindAndReplaceGenerator(inputString, findString, replaceString);
      string displayString = newFindAndReplaceGenerator.ReturnString();
      return View("Index", displayString);

    }
  }
}
