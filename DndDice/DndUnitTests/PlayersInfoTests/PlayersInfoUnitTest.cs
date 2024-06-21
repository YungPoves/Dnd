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
    public void TestInitialize()
    {
      PlayersInfo.Initialize(characters);

      Assert.IsTrue(Directory.Exists(PlayersInfo.PlayersInfoDirectoryPath));
    }

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
