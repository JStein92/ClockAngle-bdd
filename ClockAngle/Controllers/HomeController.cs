using Microsoft.AspNetCore.Mvc;
using ClockAngle.Models;
using System.Collections.Generic;
using System;

namespace ClockAngle.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index ()
    {
      return View();
    }
    [HttpPost("/angle")]
    public ActionResult ClockAngleResult ()
    {
      int hour = int.Parse(Request.Form["hour"]);
      int minute = int.Parse(Request.Form["minute"]);

      ClockAngleFinder clock = new ClockAngleFinder(hour, minute);
      return View(clock);
    }
  }
}
