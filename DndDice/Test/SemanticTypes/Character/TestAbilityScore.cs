using Common.SemanticTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.SemanticTypes
{
  [TestClass]
  public class TestAbilityScore
  {
    [TestMethod]
    public void StrengthModifier()
    {
      AbilityScore strength = new AbilityScore();
      strength.Value = 18;

      Assert.IsTrue(strength.Modifier() == (18 - 10) / 2);
    }
  }
}
