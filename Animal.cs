using System;
using System.Collections.Generic;

namespace Wildlife
{
  public class Animal
  {
    private string _type;
    private char _sex;
    private uint _yearSighted;

    public Animal(string type, char sex, uint yearSighted)
    {
      _type = type;
      _sex = sex;
      _yearSighted = yearSighted;
    }

    public string GetInfo()
    {
      return $"{_type}, {_sex}, {_yearSighted}";
    }

    public string GetAnimalType()
    {
      return _type;
    }

  }
}