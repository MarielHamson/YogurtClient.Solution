using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using YogurtClient.Models;

namespace YogurtClient.Controllers
{
  public class YogurtsController : ControllerBase
  {
    public IActionResult Index()
    {
      var allYogurts = Yogurt.GetYogurts();
      return View(allYogurts);
    }
}