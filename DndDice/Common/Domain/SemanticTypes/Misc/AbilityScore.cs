namespace Common.SemanticTypes
{
  public class AbilityScore : NotNullNumeric
  {
    public AbilityScore(int value) : base(value)
    {
      base.Value = value;
    }

    public int Modifier()
    {
      return (Value - 10) / 2;
    }
  }
}
