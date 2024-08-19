using System;
using System.Collections.Generic;
using System.Text;

namespace Common.SemanticTypes
{
  public class AbilityScore
  {
    public int Value { get; set; }

    public int Modifier()
    {
      return (Value - 10) / 2;
    }
  }
}
