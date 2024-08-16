using System;
using System.Collections.Generic;
using System.Text;

namespace Common.SemanticTypes
{
  public class CharacterRace : NotNullString
  {
    const int MinLength = 1;
    const int MaxLength = 50;

    public CharacterRace(string value) : base(value, MinLength, MaxLength)
    {
    }
  }
}
