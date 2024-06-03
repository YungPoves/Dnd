using Characters;
using System;
using System.Collections.Generic;
using System.Text;

namespace DndCharacters.Helpers
{
  public class CharacterHelper
  {
    public CharacterHelper()
    {
    }

    public Character Character => Helper<Character>();

    public Warrior Warrior => Helper<Warrior>();

    private TCharacterHelperTyper Helper<TCharacterHelperTyper>() where TCharacterHelperTyper : Character
    {
      Type helperType = typeof(TCharacterHelperTyper);

      if (characterHelperByType.ContainsKey(helperType))
        characterHelperByType[helperType] = Activator.CreateInstance(helperType);

      return (TCharacterHelperTyper)characterHelperByType[helperType];
    }

    private readonly Dictionary<Type, object> characterHelperByType = new Dictionary<Type, object>();
  }
}
