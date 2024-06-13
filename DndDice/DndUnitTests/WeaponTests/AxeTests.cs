using Characters;
using MagicDestroyers.Equipment;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Equipment.Weapons.Sharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DndUnitTests.WeaponTests
{
  [TestClass]
  public class AxeTests
  {
    [TestMethod]
    public void AxeDefault()
    {
      axe = new Axe();

      Assert.IsTrue(axe.Damage == Constants.Axe.DefaultDamage);
    }
    [TestMethod]
    public void AxeWithWarrior()
    {
      warrior = new Warrior("Warrior Name", 2, 300);
      warrior.Strength = 20;

      axe = new Axe(warrior);
      Assert.IsTrue(axe.DamageModifier == warrior.StrengthModifier);
      Assert.IsTrue(axe.DamageTotal == axe.Damage + warrior.StrengthModifier);
    }

    private Warrior warrior;
    private Axe axe;
  }
}
