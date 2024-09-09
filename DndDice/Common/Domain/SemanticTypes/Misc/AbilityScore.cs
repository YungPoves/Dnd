using System.Reflection;

namespace Common.SemanticTypes
{
  public class AbilityScore : NotNullNumeric
  {
    public static implicit operator int(AbilityScore obj) => obj.Value;

    public AbilityScore(int value) : base(value)
    {
    }

    public int Modifier
    {
      get => (Value - 10) / 2;
    }

    public int GetModifier()
    {
      return (Value - 10) / 2;
    }
  }
}
