using Characters;
using System;
using System.Collections.Generic;

namespace DndCharacters.Enumerations
{
  public static class CharacterClassRepository
  {
    //public static readonly List<string> Classes = new List<string>()
    //{
    //  typeof(Warrior).Name,
    //  typeof(Mage).Name,
    //  typeof(Assassin).Name
    //};
    public static readonly List<Type> Classes = new List<Type>()
    {
      typeof(Warrior),
      typeof(Mage),
      typeof(Assassin)
    };
  }
}
