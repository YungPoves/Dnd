using Characters;
using MagicDestroyers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace DndUnitTests.PlayersInfoTests
{
  [TestClass]
  public class LoadJsonTests
  {
    [TestInitialize] public void Setup()
    {
    }

    [TestMethod]
    public void TestLoadCharacterWarrior()
    {
      CharacterFileName = string.Concat("Warrior.json");
      characterFile = new FileInfo(Path.Combine(PlayersInfoDirectoryPath, CharacterFileName));
      dynamic jObject = JObject.Parse(File.ReadAllText(characterFile.FullName));

      Character character = PlayersInfo.LoadCharacter<Warrior>("Harald Stenhard");

      Assert.IsNotNull(character);
      //Assert.IsTrue(character.HealthPoints == jObject.HealthPoints);
      Assert.IsTrue(character.HealthPoints == 75);
    }
    [TestMethod]
    public void TestLoadCharacterKnight()
    {
      Character character = PlayersInfo.LoadCharacter<Knight>("k1");

      Assert.IsNotNull(character);
      Assert.IsTrue(character.HealthPoints == 299);
    }

    private const string PlayersInfoDirectoryPath = @"Info\";
    private string CharacterFileName;
    FileInfo characterFile;
  }
}
