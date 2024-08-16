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
  }
}
