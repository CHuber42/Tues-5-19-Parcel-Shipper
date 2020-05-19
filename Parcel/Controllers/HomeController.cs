using Microsoft.AspNetCore.Mvc;
using Parcel.Models;
using System.Collections.Generic;

namespace Parcel.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Home()
    {
      List<Package> packages = Package.GetAll();
      return View("Index", packages);
    }

  }
}

  // [HttpGet("/")]
  //   public ActionResult Index(Item myItem)
  //   {
  //     List<Item> allItems = Item.GetAll();
  //     return View("Index", allItems);
  //   }



//  [HttpPost("/items")]
//     public ActionResult Create(string description)
//     {
//       Item myItem = new Item(description);
//       return RedirectToAction("Index", myItem);
//     }
    
//   }