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
      testCharacter = new TestCharacterClass
      {
        HitPoints = new CharacterHitpoints(100)
      };

      Assert.IsTrue(testCharacter.HitPoints == 100);
    }

    [TestMethod]
    public void CharacterWithAbilityScore()
    {
      TestCharacterClass testCharacter = new TestCharacterClass(30, 8, 14, 15, 20, 19, 11);

      Assert.IsTrue(testCharacter.HitPoints == 30);
      Assert.IsTrue(testCharacter.Strength == 8);
      Assert.IsTrue(testCharacter.Dexterity == 14);
      Assert.IsTrue(testCharacter.Constitution == 15);
      Assert.IsTrue(testCharacter.Intelligence == 20);
      Assert.IsTrue(testCharacter.Wisdom == 19);
      Assert.IsTrue(testCharacter.Charisma == 11);
      Assert.IsTrue(testCharacter.Strength.GetModifier() == (8 - 10) / 2);
      Assert.IsTrue(testCharacter.Dexterity.GetModifier() == (14 - 10) / 2);
      Assert.IsTrue(testCharacter.Constitution.GetModifier() == (15 - 10) / 2);
      Assert.IsTrue(testCharacter.Intelligence.GetModifier() == (20 - 10) / 2);
      Assert.IsTrue(testCharacter.Wisdom.GetModifier() == (19 - 10) / 2);
      Assert.IsTrue(testCharacter.Charisma.GetModifier() == (11 - 10) / 2);
    }

    [TestMethod]
    public void CharacterWithAbilityScores()
    {
      TestCharacterClass testCharacter = new TestCharacterClass
      {
        HitPoints = new CharacterHitpoints(7),
        Strength = new AbilityScore(8),
        Dexterity = new AbilityScore(14),
        Constitution = new AbilityScore(10),
        Intelligence = new AbilityScore(10),
        Wisdom = new AbilityScore(8),
        Charisma = new AbilityScore(8)
      };

      Assert.IsTrue(testCharacter.Strength.Modifier == (testCharacter.Strength - 10) / 2);
      Assert.IsTrue(testCharacter.Dexterity.Modifier == (testCharacter.Dexterity - 10) / 2);
      Assert.IsTrue(testCharacter.Constitution.Modifier == (testCharacter.Constitution - 10) / 2);
      Assert.IsTrue(testCharacter.Intelligence.Modifier == (testCharacter.Intelligence - 10) / 2);
      Assert.IsTrue(testCharacter.Wisdom.Modifier == (testCharacter.Wisdom - 10) / 2);
      Assert.IsTrue(testCharacter.Charisma.Modifier == (testCharacter.Charisma - 10) / 2);
    }

    private TestCharacterClass testCharacter;
  }
}
