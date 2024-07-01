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
    public void TestLoadJson()
    {
      Character character = PlayersInfo.LoadWarrior("Harald Stenhard");

      Assert.IsNotNull(character);
      Assert.IsTrue(character.HealthPoints == 800);
    }
  }
}
