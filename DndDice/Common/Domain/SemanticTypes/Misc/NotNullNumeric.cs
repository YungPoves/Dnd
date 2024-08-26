using System;
using System.Diagnostics;

namespace Common.SemanticTypes
{
  public abstract class NotNullNumeric
  {
    #region Operator Overloads
    public static bool operator ==(NotNullNumeric obj1, NotNullNumeric obj2)
    {
      if (ReferenceEquals(null, obj1))
        return ReferenceEquals(null, obj2);

      return obj1.Equals(obj2);
    }

    public static bool operator ==(NotNullNumeric obj1, int value2)
    {
      if (ReferenceEquals(null, obj1))
        return false;

      return obj1.Value.Equals(value2);
    }

    public static bool operator !=(NotNullNumeric obj1, NotNullNumeric obj2)
    {
      return (obj1 == obj2) == false;
    }

    public static bool operator !=(NotNullNumeric obj1, int value2)
    {
      return (obj1 == value2) == false;
    }
    #endregion

    [DebuggerStepThrough]
    protected NotNullNumeric(int value) : this(value, 1)
    {
    }

    [DebuggerStepThrough]
    protected NotNullNumeric(int value, int minValue)
    {
      if (value == null)
        throw new ArgumentNullException(nameof(value));

      if (value < minValue)
        throw new ArgumentException($"Value too low: {nameof(value)}");

      Value = value;
    }

    public static bool IsValid(int? candidate)
    {
      return IsValid(candidate, MinValue);
    }
    public static bool IsValid(int? candidate, int minvalue)
    {
      if (candidate == null)
        return false;

      if (candidate < minvalue)
        return false;

      return true;
    }

    #region Overrides
    public override bool Equals(object obj)
    {
      NotNullNumeric typedObj = obj as NotNullNumeric;
      if (typedObj == null)
        return false;

      return typedObj.Value.Equals(Value);
    }

    public override int GetHashCode()
    {
      return Value.GetHashCode();
    }
    #endregion

    public int Value { get; protected set; }

    private const int MinValue = 0;
  }
}
