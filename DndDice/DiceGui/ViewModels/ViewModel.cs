using Characters;
using DiceProject;
using DndCharacters.Helpers;
using MagicDestroyers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGui.ViewModels
{
  public class ViewModel
  {
    public string D4()
    {
      return DiceRoller.D4s.Roll().ToString();
    }
    public string D6()
    {
      return DiceRoller.D6s.Roll().ToString();
    }
    public string D8()
    {
      return DiceRoller.D8s.Roll().ToString();
    }
    public string D10()
    {
      return DiceRoller.D10s.Roll().ToString();
    }
    public string D12()
    {
      return DiceRoller.D12s.Roll().ToString();
    }
    public string D20()
    {
      return DiceRoller.D20s.Roll().ToString();
    }
    public string D100()
    {
      return DiceRoller.D100s.Roll().ToString();
    }

    public Warrior CreateWarrior()
    {
      return CharacterHelper.Warriors;
    }
    public Mage CreateMage()
    {
      return CharacterHelper.Mages;
    }
    public Character LoadCharacter(string characterName)
    {
      return PlayersInfo.LoadCharacter<Warrior>(characterName);
    }

    private static DiceRoller diceRoller;
    private static CharacterHelper characterHelper;

    public static DiceRoller DiceRoller => diceRoller = new DiceRoller();
    public static CharacterHelper CharacterHelper => characterHelper = new CharacterHelper();
  }
}
