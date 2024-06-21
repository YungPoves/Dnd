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

    public Warrior WarriorWithParams(params object[] parameters) => Helper<Warrior>(parameters);

    public Mage Mages => Helper<Mage>();

    private TCharacterHelperTyper Helper<TCharacterHelperTyper>() where TCharacterHelperTyper : Character
    {
      Type helperType = typeof(TCharacterHelperTyper);

      if (characterHelperByType.ContainsKey(helperType) == false)
        characterHelperByType[helperType] = Activator.CreateInstance(helperType);

      return (TCharacterHelperTyper)characterHelperByType[helperType];
    }

    //private TCharacterHelperTyper Helper<TCharacterHelperTyper>(object[] parameters) where TCharacterHelperTyper : Character
    //{
    //  Type helperType = typeof(TCharacterHelperTyper);

    //  if (characterHelperByType.ContainsKey(helperType) == false)
    //    characterHelperByType[helperType] = Activator.CreateInstance(helperType, parameters);

    //  return (TCharacterHelperTyper)characterHelperByType[helperType];
    //}

    private TCharacterHelperTyper Helper<TCharacterHelperTyper>(params object[] parameters) where TCharacterHelperTyper : Character
    {
      Type helperType = typeof(TCharacterHelperTyper);

      if (characterHelperByType.ContainsKey(helperType) == false)
        characterHelperByType[helperType] = Activator.CreateInstance(helperType, parameters);

      return (TCharacterHelperTyper)characterHelperByType[helperType];
    }

    private object[] parameters;
    private readonly Dictionary<Type, object> characterHelperByType = new Dictionary<Type, object>();
  }
}
