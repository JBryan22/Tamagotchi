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

      return View("index", Tamagotchi.GetAllTama());
    }

    [HttpPost("/feed/{id}")]
    public ActionResult FeedTama(int id)
    {
      Tamagotchi.Find(id).Feed(20);
      Tamagotchi.PassTime();

      // List<int> tamaIds = new List<int> {};
      //
      // foreach (Tamagotchi tama in Tamagotchi.GetAllTama())
      // {
      //   if(tama.CheckDeath())
      //   {
      //     tamaIds.Add(tama.GetId());
      //   }
      // }
      // int j = 2;
      // if (tamaIds.Count > 0){
      //   for (int i = tamaIds[tamaIds.Count - 1]; i > 0; i = i)
      //   {
      //     Tamagotchi.RemoveSpecificTama(i);
      //     j++;
      //     if (tamaIds.Count > j)
      //     {
      //       i = tamaIds[tamaIds.Count - j];
      //     }
      //   }

      //}

      return View("index", Tamagotchi.GetAllTama());
    }

    [HttpPost("/play/{id}")]
    public ActionResult PlayTama(int id)
    {
      Tamagotchi.Find(id).Play(20);
      Tamagotchi.PassTime();

      // List<int> tamaIds = new List<int> {};
      //
      // foreach (Tamagotchi tama in Tamagotchi.GetAllTama())
      // {
      //   if(tama.CheckDeath())
      //   {
      //     tamaIds.Add(tama.GetId());
      //   }
      // }
      // int j = 2;
      // if (tamaIds.Count > 0){
      //   for (int i = tamaIds[tamaIds.Count - 1]; i > 0; i = i)
      //   {
      //     Tamagotchi.RemoveSpecificTama(i);
      //     j++;
      //     if (tamaIds.Count > j)
      //     {
      //       i = tamaIds[tamaIds.Count - j];
      //     }
      //   }
      //}

      // if (Tamagotchi.Find(id).CheckDeath())
      // {
      //   Tamagotchi.RemoveSpecificTama(id);
      // }

      return View("index", Tamagotchi.GetAllTama());
    }

    [HttpPost("/sleep/{id}")]
    public ActionResult SleepTama(int id)
    {
      Tamagotchi.Find(id).Sleep(20);
      Tamagotchi.PassTime();

      // List<int> tamaIds = new List<int> {};
      //
      // foreach (Tamagotchi tama in Tamagotchi.GetAllTama())
      // {
      //   if(tama.CheckDeath())
      //   {
      //     tamaIds.Add(tama.GetId());
      //   }
      // }
      // int j = 2;
      // if (tamaIds.Count > 0){
      //   for (int i = tamaIds[tamaIds.Count - 1]; i > 0; i = i)
      //   {
      //     Tamagotchi.RemoveSpecificTama(i);
      //     j++;
      //     if (tamaIds.Count > j)
      //     {
      //       i = tamaIds[tamaIds.Count - j];
      //     }
      //   }
      //}


      return View("index", Tamagotchi.GetAllTama());
    }

    // [HttpPost("/time")]
    // public ActionResult PassTime()
    // {
    //   foreach (Tamagotchi tama in Tamagotchi.GetAllTama())
    //   {
    //     tama.PassTime();
    //   }
    //   foreach (Tamagotchi tama in Tamagotchi.GetAllTama())
    //   {
    //     if (tama.CheckDeath())
    //     {
    //       Tamagotchi.RemoveSpecificTama(tama.GetId());
    //     }
    //   }
    //
    //   return View("index", Tamagotchi.GetAllTama());
    // }
  }
}
