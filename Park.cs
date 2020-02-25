using System;
using System.Collections.Generic;

namespace Wildlife
{
  public class Park
  {
    private List<string> _animals = new List<string>();

    public void PrintAnimals()
    {
      Console.WriteLine("The park now contains:");
      foreach (string animal in _animals)
      {
        Console.WriteLine(animal);
      }
    }

    public void AddAnimal(string animal)
    {
      _animals.Add(animal.ToLower());
    }

    public void RemoveAnimal(string animal)
    {
      _animals.Remove(animal.ToLower());
    }
  }
}
