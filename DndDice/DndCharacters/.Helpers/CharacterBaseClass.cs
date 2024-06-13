using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacters.Helpers
{
  public class CharacterBaseClass
  {
    public CharacterBaseClass() { }

    private static CharacterHelper characterHelper;

    public static CharacterHelper CharacterHelper => characterHelper = new CharacterHelper();
  }
}
