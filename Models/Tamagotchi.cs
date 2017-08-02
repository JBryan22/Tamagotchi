using System.Collections.Generic;

namespace Tamagotchis.Models
{
  public class Tamagotchi
  {
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

    public int GetFood()
    {
      return _food;
    }

    public void AddFood(newFood)
    {
      _food += newFood;
    }

    public int GetHappiness()
    {
      return _happiness;
    }

    public void AddHappiness(newHappiness)
    {
      _happiness += newFood;
    }

    public int GetSleep()
    {
      return _sleep;
    }

    public void AddSleep(newSleep)
    {
      _sleep += newSleep;
    }

    public static List<Tamagotchi>

  }
}
