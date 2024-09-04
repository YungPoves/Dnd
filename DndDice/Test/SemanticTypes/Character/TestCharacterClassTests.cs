using Common.Domain.SemanticTypes.Characters;
using Common.SemanticTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.SemanticTypes.Character
{
  [TestClass]
  public class TestCharacterClassTests
  {
    [TestMethod]
    public void CharacterTestWithHitPoints()
    {
      testCharacter = new TestCharacterClass();
      testCharacter.HitPoints = new CharacterHitpoints(100);

      Assert.IsTrue(testCharacter.HitPoints == 100);
    }

    private TestCharacterClass testCharacter;
  }
}
