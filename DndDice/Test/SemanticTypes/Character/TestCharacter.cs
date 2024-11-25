using Microsoft.VisualStudio.TestTools.UnitTesting;
using Common.SemanticTypes;

namespace Test.SemanticTypes
{
  [TestClass]
  public class TestCharacter
  {
    [TestMethod]
    public void CharacterWithStringName()
    {
      character = new Common.SemanticTypes.Character("value");

      Assert.IsTrue(character.Name.Value.Equals("value"));
    }

    [TestMethod]
    public void CharacterWithAbilityScores()
    {
      character = new Common.SemanticTypes.Character(strength, dexterity, constitution, intelligence, wisdom, charisma);

      Assert.IsTrue(character.Strength.GetModifier() == (12 - 10) / 2);
      Assert.IsTrue(character.Dexterity.GetModifier() == (18 - 10) / 2);
      Assert.IsTrue(character.Constitution.GetModifier() == (20 - 10) / 2);
      Assert.IsTrue(character.Intelligence.GetModifier() == (11 - 10) / 2);
      Assert.IsTrue(character.Wisdom.GetModifier() == (10 - 10) / 2);
      Assert.IsTrue(character.Charisma.GetModifier() == (13 - 10) / 2);
    }

    [TestMethod]
    public void CharacterWithHitPoints()
    {
      character = new Common.SemanticTypes.Character(hitpoints);

      Assert.IsTrue(character.HitPoints == 100);
    }

    [TestMethod]
    public void CharacterWithArmorClass()
    {
      character = new Common.SemanticTypes.Character(strength, dexterity, constitution, intelligence, wisdom, charisma)
      {
        ArmorClass = new ArmorClass(15)
      };

      Assert.IsTrue(character.ArmorClass.Value == 15);
    }

    [TestMethod]
    public void CharacterWithLevel()
    {
      character = new Common.SemanticTypes.Character(strength, dexterity, constitution, intelligence, wisdom, charisma)
      {
        Level = new CharacterLevel(5)
      };

      Assert.IsTrue(character.Level.Value == 5);
    }

    Common.SemanticTypes.Character character;

    private readonly AbilityScore strength = new AbilityScore(12);
    private readonly AbilityScore dexterity = new AbilityScore(18);
    private readonly AbilityScore constitution = new AbilityScore(20);
    private readonly AbilityScore intelligence = new AbilityScore(11);
    private readonly AbilityScore wisdom = new AbilityScore(10);
    private readonly AbilityScore charisma = new AbilityScore(13);
    private readonly CharacterHitpoints hitpoints = new CharacterHitpoints(100);
  }
}
