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
      Character character = new Character("value");

      Assert.IsTrue(character.Name.Value.Equals("value"));
    }

    [TestMethod]
    public void CharacterWithAbilityScores()
    {      
      strength.Value = 20;
      dexterity.Value = 12;

      Character character = new Character(strength, dexterity);

      Assert.IsTrue(character.AbilityScores[0].Modifier() == 5);
      Assert.IsTrue(character.AbilityScores[1].Modifier() == 1);
    }

    private AbilityScore strength = new AbilityScore();
    private AbilityScore dexterity = new AbilityScore();
  }
}
