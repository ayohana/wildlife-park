using System;
using System.Collections.Generic;

namespace Wildlife
{
  public class Park
  {
    private List<Animal> _animals = new List<Animal>();

    public void PrintAnimals()
    {
      Console.WriteLine("The park now contains:");
      foreach (Animal animal in _animals)
      {
        Console.WriteLine(animal.GetInfo());
      }
    }

    public void AddAnimal(string type, char sex, uint yearSighted)
    {
      Animal animal = new Animal(type.ToLower(), char.ToUpper(sex), yearSighted);
      _animals.Add(animal);
    }

    public void RemoveAnimal(string type)
    {
      foreach (Animal animal in _animals)
      {
        if (animal.GetAnimalType() == type)
        {
          _animals.Remove(animal);
          break;
        }
      }
    }
  }
}
