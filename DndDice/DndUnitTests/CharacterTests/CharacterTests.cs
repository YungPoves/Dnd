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
    public void CharacterHelperTests()
    {
      Warrior warrior = CharacterHelper.NewWarrior();

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
    public void NewWarriorByType()
    {
      Character character = ViewModel.CharacterHelper.NewCharacter<Warrior>();

      Assert.IsNotNull(character);
      Assert.IsTrue(character is Warrior);
      Assert.IsTrue(character.Name == Constants.Warrior.DefaultName);
      Assert.IsTrue(character.Level == Constants.Warrior.DefaultLevel);
      Assert.IsTrue(character.HealthPoints == Constants.Warrior.DefaultHealth);
    }
    [TestMethod]
    public void NewMageByType()
    {
      Character character = ViewModel.CharacterHelper.NewCharacter<Mage>();

      Assert.IsNotNull(character);
      Assert.IsTrue(character is Mage);
      Assert.IsTrue(character.Name == Constants.Mage.DefaultName);
      Assert.IsTrue(character.Level == Constants.Mage.DefaultLevel);
      Assert.IsTrue(character.HealthPoints == Constants.Mage.DefaultHealth);
    }
  }
}
