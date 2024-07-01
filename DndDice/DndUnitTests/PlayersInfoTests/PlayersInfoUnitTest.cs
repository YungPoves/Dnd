using Characters;
using MagicDestroyers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;

namespace DndUnitTests.PlayersInfoTests
{
  [TestClass]
  public class PlayersInfoTests
  {
    [TestMethod]
    public void TestSaveJson()
    {
      PlayersInfo.Save(warrior);

      characterFile = new FileInfo(PlayersInfo.PlayersInfoDirectoryPath + PlayersInfo.CharacterFileName);

      Assert.IsTrue(File.Exists(characterFile.FullName));
    }

    [TestMethod]
    public void TestLoadJson()
    {
      character = PlayersInfo.LoadWarrior("Harald Stenhard");

      Assert.IsNotNull(character);
      Assert.IsTrue(character.HealthPoints != warrior.HealthPoints);
    }

    FileInfo characterFile;

    static readonly Character warrior = new Warrior();
    static readonly Character mage = new Mage();
    private Character character;

    readonly List<Character> characters = new List<Character>
    {
      warrior,
      mage
    };
  }
}
