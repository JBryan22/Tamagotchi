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
    public ActionResult FeedTama(int id)
    {
      Tamagotchi.Find(id).Feed(25);

      return View("/", Tamagotchi.GetAllTama());
    }

    [HttpPost("/play/{id}")]
    public ActionResult PlayTama(int id)
    {
      Tamagotchi.Find(id).Play(25);

      return View("/", Tamagotchi.GetAllTama());
    }

    [HttpPost("/sleep/{id}")]
    public ActionResult SleepTama(int id)
    {
      Tamagotchi.Find(id).Sleep(25);

      return View("/", Tamagotchi.GetAllTama());
    }
  }
}
