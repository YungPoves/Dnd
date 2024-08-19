using System;
using System.Diagnostics;

namespace Common.SemanticTypes
{
  public abstract class NotNullNumeric
  {
    [DebuggerStepThrough]
    protected NotNullNumeric(int? value) 
    {
      if (value == null)
        throw new ArgumentNullException(nameof(value));
    }

    public static bool IsValid(int candidate)
    {
      return false;
    }

    public int Value { get; protected set; }
  }
}
