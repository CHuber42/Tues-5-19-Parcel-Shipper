using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System.Collections.Generic;

namespace Parcel.Controllers
{
  public class ParcelController : Controller
  {
    [HttpGet("/NewParcel")]
    public ActionResult NewParcel()
    {
      return View("NewParcel");
    }

    [HttpPost("/AddItem")]
    public ActionResult AddParcel(int height, int length, int width, int weight)
    {
      int[] dimensions = new int[] {height, length, width};
      Package newItem = new Package(dimensions, weight);
      return RedirectToAction("Home", "Home"); 
    }

  }
}
