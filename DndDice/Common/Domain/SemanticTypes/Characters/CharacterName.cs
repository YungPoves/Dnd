using System;
using System.Diagnostics;

namespace Common.SemanticTypes
{
  public class CharacterName : NotNullString
  {
    public const int MinLength = 1;
    public const int MaxLength = 50;

    public static new bool IsValid(string candidate)
    {
      return NotNullString.IsValid(candidate);
    }

    [DebuggerStepThrough]
    public CharacterName(string value) : base(value, MinLength, MaxLength)
    {
      if (IsValid(value) == false)
        throw new FormatException($"Invalid value: {value}");
    }
  }
}
