namespace Common.SemanticTypes
{
  public class CharacterProficiency : NotNullNumeric
  {
    public CharacterProficiency(int value) : base(value)
    {
      base.Value = value;
    }
  }
}
