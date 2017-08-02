using System.Collections.Generic;

namespace Tamagotchis.Models
{
  public class Tamagotchi
  {
    private string _name;
    private int _food;
    private int _happiness;
    private int _sleep;

    private static List<Tamagotchi> _allTama = new List<Tamagotchi> {};

    public Tamagotchi(int food = 75, int happiness = 75, int sleep = 75)
    {
      _food = food;
      _happiness = happiness;
      _sleep = sleep;
      _allTama.add(this);
      _id = allTama.Count;
    }

    public int GetName()
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

    public void Feed(newFood)
    {
      _food += newFood;
    }

    public int GetHappiness()
    {
      return _happiness;
    }

    public void Play(newHappiness)
    {
      _happiness += newFood;
    }

    public int GetSleep()
    {
      return _sleep;
    }

    public void Sleep(newSleep)
    {
      _sleep += newSleep;
    }

    public static List<Tamagotchi> GetAllTama()
    {
      return _allTama;
    }

    public static void RemoveSpecificTama(int searchId)
    {
      _allTama.RemoveAt(searchId - 1)
    }

    public static Tamagotchi Find(int searchId)
    {
      return _allTama[searchId - 1];
    }

  }
}
