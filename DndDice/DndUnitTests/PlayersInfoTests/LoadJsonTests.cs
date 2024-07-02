using Characters;
using MagicDestroyers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Linq;
using System.IO;

namespace DndUnitTests.PlayersInfoTests
{
  [TestClass]
  public class LoadJsonTests
  {
    [TestMethod]
    public void TestLoadCharacterWarrior()
    {
      jObjectTest = JObject.Parse(File.ReadAllText(Path.Combine(PlayersInfo.PlayersInfoDirectoryPath, warriorFileName)));
      TestWarrior = jObjectTest.ToObject<Warrior>();

      CharacterToTest = PlayersInfo.LoadCharacter<Warrior>("Harald Stenhard");

      Assert.IsNotNull(CharacterToTest);
      Assert.IsTrue(CharacterToTest.HealthPoints == TestWarrior.HealthPoints);
      Assert.IsTrue(CharacterToTest.Name != TestWarrior.Name);
    }
    [TestMethod]
    public void TestLoadCharacterKnight()
    {
      jObjectTest = JObject.Parse(File.ReadAllText(Path.Combine(PlayersInfo.PlayersInfoDirectoryPath, knightFileName)));
      TestKnight = jObjectTest.ToObject<Knight>();

      CharacterToTest = PlayersInfo.LoadCharacter<Knight>("k1");

      Assert.IsNotNull(CharacterToTest);
      Assert.IsTrue(CharacterToTest.HealthPoints == TestKnight.HealthPoints);
      Assert.IsTrue(CharacterToTest.Name != TestKnight.Name);
    }

    private const string warriorFileName = "Warrior.json";
    private const string knightFileName = "Knight.json";

    private Character CharacterToTest;
    private Warrior TestWarrior;
    private Knight TestKnight;
    private JObject jObjectTest;
  }
}
