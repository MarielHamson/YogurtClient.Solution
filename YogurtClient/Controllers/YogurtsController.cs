using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YogurtClient.Models;

namespace YogurtClient.Controllers
{
  public class YogurtsController : Controller
  {
    public IActionResult Index()
    {
      var allYogurts = Yogurt.GetYogurts();
      return View(allYogurts);
    }

    [HttpPost]
    public IActionResult Index(Yogurt yogurt)
    {
      Yogurt.Post(yogurt);
      return RedirectToAction("Index");
    }

    public IActionResult Details(int id)
    {
      var yogurt = Yogurt.GetDetails(id);
      return View(yogurt);
    }

    public IActionResult Edit(int id)
    {
      var yogurt = Yogurt.GetDetails(id);
      return View(yogurt);
    }

    [HttpPost]
    public IActionResult Details(int id, Yogurt yogurt)
    {
      yogurt.YogurtId = id;
      Yogurt.Put(yogurt);
      return RedirectToAction("Details", id);
    }

    public IActionResult Delete(int id)
    {
      Yogurt.Delete(id);
      return RedirectToAction("Index");
    }
  }
}