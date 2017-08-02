using Microsoft.AspNetCore.Mvc;
using Tamagotchis.Models;
using System.Collections.Generic;
using System;

namespace Tamagotchis.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    [HttpGet("/AddTama")]
    public ActionResult AddTama()
    {
      return View();
    }

    [HttpPost("/")]
    public ActionResult IndexAdd()
    {
      Tamagotchi myTama = new Tamagotchi();
      myTama.SetName(Request.Form["tama-name"]);

      return View("/", Tamagotchi.GetAllTama());
    }

    [HttpPost("/feed/{id}")]
    public ActionResult Feed()
    {
      Tamagotchi.Find()
    }
  }
}
