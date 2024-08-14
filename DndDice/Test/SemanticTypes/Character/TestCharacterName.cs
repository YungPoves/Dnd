using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Common.SemanticTypes;

namespace Test.SemanticTypes
{
  [TestClass]
  public class TestCharacterName
  {
    [TestMethod]
    [ExpectedException(typeof(ArgumentNullException))]
    public void Null()
    {
      CharacterName obj = new CharacterName(null);

      Assert.IsTrue(obj.Value == null);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Empty()
    {
      CharacterName obj = new CharacterName(string.Empty);

      Assert.IsTrue(obj.Value == string.Empty);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void TooLong()
    {
      string value = "-".PadRight(257);

      CharacterName obj = new CharacterName(value);
    }

    [TestMethod]
    public void OK()
    {
      CharacterName obj = new CharacterName("value");

      Assert.IsTrue(obj.Value == "value");
    }
  }
}
