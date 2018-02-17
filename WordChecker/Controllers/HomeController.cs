using Microsoft.AspNetCore.Mvc;
using WordChecker.Models;
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
    // [HttpPost("/Result")]
    // public ActionResult Result()
    // {
    //   string word = Request.Form[("keyWord")];
    //   string sentence = Request.Form[("sentence")];
    //   new WordCheckerVariable(word,sentence);
    //   return View("Result", WordCheckerVariable.GetCount());
    // }
  }
}
