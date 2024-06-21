using Characters;
using DiceGui.ViewModels;
using DndCharacters.Helpers;
using MagicDestroyers.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DndUnitTests.CharacterTests
{
  [TestClass]
  public class CharacterTests : CharacterBaseClass
  {
    [TestInitialize]
    public void Setup() 
    {
    }
    [TestMethod]
    public void DefaultWarrior()
    {
      Warrior warrior = new Warrior();

      Assert.IsNotNull(warrior);
      Assert.IsTrue(warrior.Name == Constants.Warrior.DefaultName);
      Assert.IsTrue(warrior.Level == Constants.Warrior.DefaultLevel);
      Assert.IsTrue(warrior.HealthPoints == Constants.Warrior.DefaultHealth);
      Assert.IsTrue(warrior.AbilityPoints == Constants.Warrior.DefaultAbilityPoints);
    }

    [TestMethod]
    public void WarriorWithUserValues()
    {
      Warrior warrior = new Warrior("WarriorName", 5, 300);

      Assert.IsNotNull(warrior);
      Assert.IsTrue(warrior.Name == "WarriorName");
      Assert.IsTrue(warrior.Level == 5);
      Assert.IsTrue(warrior.HealthPoints == 300);
      Assert.IsTrue(warrior.AbilityPoints == Constants.Warrior.DefaultAbilityPoints);
    }
    [TestMethod]
    public void WarriorWithStrength()
    {
      Warrior warrior = new Warrior();
      warrior.Strength = 20;
      int mod = warrior.StrengthModifier;

      Assert.IsNotNull(warrior);
      Assert.IsTrue(warrior.Strength == 20);
      Assert.IsTrue(warrior.StrengthModifier == 5);
    }

    [TestMethod]
    public void WarriorWithParameters()
    {
      character = CharacterHelper.WarriorWithParams(parameters);

      Assert.IsNotNull(character);
      Assert.IsTrue(character.Name == (string)parameters[0]);
      Assert.IsTrue(character.Level == (int)parameters[1]);
      Assert.IsTrue(character.HealthPoints == (int)parameters[2]);
      Assert.IsTrue(character.Faction == MagicDestroyers.Enumerations.Factions.Melee);
    }

    [TestMethod]
    public void WarriorWith2Parameters()
    {
      Character warrior = CharacterHelper.WarriorWithParams("Name", 3);

      Assert.IsNotNull(warrior);
      Assert.IsTrue(warrior.Name == "Name");
      Assert.IsTrue(warrior.Level == 3);
    }
    [TestMethod]
    public void CharacterHelperTests()
    {
      Warrior warrior = CharacterHelper.Warriors;

      Assert.IsNotNull(warrior);
    }

    [TestMethod]
    public void NewWarrior()
    {
      Character warrior = new Warrior();

      Assert.IsNotNull(warrior);
      Assert.IsTrue(warrior.Name == Constants.Warrior.DefaultName);
      Assert.IsTrue(warrior.Level == Constants.Warrior.DefaultLevel);
      Assert.IsTrue(warrior.HealthPoints == Constants.Warrior.DefaultHealth);
      Assert.IsTrue(warrior is Warrior);
    }

    [TestMethod]
    public void MageWithParams()
    {
      character = CharacterHelper.MageWithParams(parameters);

      Assert.IsNotNull(character);
      Assert.IsTrue(character.Name == parameters[0].ToString());
      Assert.IsTrue(character.Level == (int)parameters[1]);
      Assert.IsTrue(character.HealthPoints == (int)parameters[2]);
      Assert.IsTrue(character.Faction == MagicDestroyers.Enumerations.Factions.Spellcaster);
    }

    private Character character;
    private readonly object[] parameters = { "Harald", 25, 350 };
  }
}
