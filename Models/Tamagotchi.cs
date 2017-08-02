using System.Collections.Generic;

namespace Tamagotchis.Models
{
  public class Tamagotchi
  {
    private string _name;
    private int _food;
    private int _happiness;
    private int _sleep;
    private int _id;

    private static List<Tamagotchi> _allTama = new List<Tamagotchi> {};

    public Tamagotchi(int food = 75, int happiness = 75, int sleep = 75)
    {
      _food = food;
      _happiness = happiness;
      _sleep = sleep;
      _allTama.Add(this);
      _id = _allTama.Count;
    }

    public string GetName()
    {
      return _name;
    }

    public void SetName(string name)
    {
      _name = name;
    }

    public int GetFood()
    {
      return _food;
    }

    public void Feed(int newFood)
    {
      _food += newFood;
    }

    public int GetHappiness()
    {
      return _happiness;
    }

    public void Play(int newHappiness)
    {
      _happiness += newHappiness;
    }

    public int GetSleep()
    {
      return _sleep;
    }

    public void Sleep(int newSleep)
    {
      _sleep += newSleep;
    }

    public static List<Tamagotchi> GetAllTama()
    {
      return _allTama;
    }

    public static void RemoveSpecificTama(int searchId)
    {
      _allTama.RemoveAt(searchId - 1);
    }

    public static Tamagotchi Find(int searchId)
    {
      return _allTama[searchId - 1];
    }

    public int GetId()
    {
      return _id;
    }

    public static void PassTime()
    {
      foreach(Tamagotchi tama in _allTama)
      {
        tama.Feed(-5);
        tama.Play(-5);
        tama.Sleep(-5);
      }
    }

    public bool CheckDeath()
    {
      if (_food < 1 || _happiness < 1 || _sleep < 1)
      {
        return true;
      }
      else
      {
        return false;
      }
    }

  }
}
