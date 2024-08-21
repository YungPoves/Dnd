using Common.SemanticTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test.SemanticTypes
{
  [TestClass]
  public class TestAbilityScore
  {
    [TestMethod]
    public void AbilityScoreFromInt() 
    {
      AbilityScore strength = new AbilityScore(17);

      Assert.IsTrue(strength.Modifier() == 3);
    }
  }
}
