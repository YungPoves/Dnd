using Characters;
using DndCharacters.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacters
{
  public class CharacterViewModel : CharacterBaseClass
  {
    public string Test()
    {
      Warrior warrior = new Warrior();
      return warrior.ToString();
      //return CharacterHelper.Warrior.ToString();
    }
  }
}
