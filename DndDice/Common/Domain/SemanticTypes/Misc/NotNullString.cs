using System;
using System.Diagnostics;

namespace Common.SemanticTypes
{
  public abstract class NotNullString
  {
    [DebuggerStepThrough]
    protected NotNullString(string value) : this(value, MaxLength)
    {
    }

    [DebuggerStepThrough]
    protected NotNullString(string value, int maxLength) : this(value, 1, maxLength) 
    {
    }

    [DebuggerStepThrough]
    protected NotNullString(string value, int minLength, int maxLength)
    {
      if (value == null)
        throw new ArgumentNullException(nameof(value));

      if (IsValid(value, minLength, maxLength) == false)
        throw new ArgumentException($"Invalid value: {value}");

      Value = value.Trim();
    }

    public static bool IsValid(string candidate)
    {
      return IsValid(candidate, MaxLength);
    }
    public static bool IsValid(string candidate, int maxLength)
    {
      return IsValid(candidate, 1, MaxLength);
    }
    public static bool IsValid(string candidate, int minLength, int maxLength)
    {
      if (candidate == null)
        return false;

      if(string.IsNullOrWhiteSpace(candidate))
        return false;

      if (candidate.Length > maxLength)
        return false;

      if (candidate.Length < minLength)
        return false;
      
      return true;
    }

    public virtual string Value { get; protected set; }

    private const int MaxLength = 2048;
  }
}
