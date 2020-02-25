using System;
using System.Collections.Generic;

namespace Wildlife
{
  public class Project
  {
    public static void AddOrRemove(Park park)
    {
      Console.WriteLine("What would you like to do? (Add/Remove)");
      string response = Console.ReadLine().ToLower();
      if (response == "add")
      {
        Console.WriteLine("What type of animal did you spot?");
        string animal = Console.ReadLine();
        park.AddAnimal(animal);
        park.PrintAnimals();
      }
      else if (response == "remove")
      {
        Console.WriteLine("What type of animal do you want to remove?");
        string animal = Console.ReadLine();
        park.RemoveAnimal(animal);
        park.PrintAnimals();
      }
    }

    public static void Main()
    {
      Park park = new Park();
      Console.WriteLine("Welcome to the Wildlife Park!");
      Console.WriteLine("Would you like to track animals? (Yes/No)");
      string run = Console.ReadLine().ToLower();
      while (run == "yes")
      {
        AddOrRemove(park);
        Console.WriteLine("Would you like to continue tracking animals? (Yes/No)");
        run = Console.ReadLine().ToLower();
      }
    }
  }
}
