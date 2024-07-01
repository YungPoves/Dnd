using Characters;
using MagicDestroyers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace DndUnitTests.PlayersInfoTests
{
  [TestClass]
  public class LoadJsonTests
  {
    [TestMethod]
    public void TestLoadCharacterWarrior()
    {
      Character character = PlayersInfo.LoadCharacter<Warrior>("Harald Stenhard");

      Assert.IsNotNull(character);
      Assert.IsTrue(character.HealthPoints == 399);
    }
    [TestMethod]
    public void TestLoadCharacterKnight()
    {
      Character character = PlayersInfo.LoadCharacter<Knight>("k1");

      Assert.IsNotNull(character);
      Assert.IsTrue(character.HealthPoints == 299);
    }
  }
}
