using Characters;
using System;
using System.Collections.Generic;

namespace DndCharacters.Helpers
{
  public class CharacterHelper
  {
    public CharacterHelper()
    {
    }

    public Character Characters => Helper<Character>();

    public Warrior Warriors => Helper<Warrior>();

    public Mage Mages => Helper<Mage>();

    private TCharacterHelperTyper Helper<TCharacterHelperTyper>() where TCharacterHelperTyper : Character
    {
      Type helperType = typeof(TCharacterHelperTyper);

      if (characterHelperByType.ContainsKey(helperType) == false)
        characterHelperByType[helperType] = Activator.CreateInstance(helperType);

      return (TCharacterHelperTyper)characterHelperByType[helperType];
    }

    private readonly Dictionary<Type, object> characterHelperByType = new Dictionary<Type, object>();
  }
}
