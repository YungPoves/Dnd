using Characters;
using MagicDestroyers.Constants;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DndUnitTests.CharacterTests
{
  [TestClass]
  public class Character
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
  }
}
