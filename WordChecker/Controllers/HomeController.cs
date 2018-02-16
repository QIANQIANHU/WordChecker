using Microsoft.AspNetCore.Mvc;
// using WordChecker.Models;
using System.Collections.Generic;
using System;

namespace WordChecker.Controllers
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
