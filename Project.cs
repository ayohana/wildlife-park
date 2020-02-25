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
        string type = Console.ReadLine();
        Console.WriteLine("Enter its sex: (M/F)");
        char sex = char.Parse(Console.ReadLine());
        Console.WriteLine("Enter the year it was sighted:");
        uint yearSighted = Convert.ToUInt32(Console.ReadLine(), 10);
        park.AddAnimal(type, sex, yearSighted);
        park.PrintAnimals();
      }
      else if (response == "remove")
      {
        Console.WriteLine("What type of animal do you want to remove?");
        string type = Console.ReadLine();
        park.RemoveAnimal(type);
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
