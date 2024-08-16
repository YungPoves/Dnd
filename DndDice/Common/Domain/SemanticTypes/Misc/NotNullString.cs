using System;
using System.Diagnostics;

namespace Common.SemanticTypes
{
  public abstract class NotNullString
  {
    #region Operator overloads
    public static implicit operator string(NotNullString obj) => obj?.ToString();

    public static bool operator ==(NotNullString obj1, NotNullString obj2)
    {
      if (ReferenceEquals(null, obj1))
        return ReferenceEquals(null, obj2);
      
      return obj1.Equals(obj2);
    }

    public static bool operator ==(NotNullString obj1, string value2)
    {
      if (ReferenceEquals(null, obj1))
        return false;

      return obj1.Value.Equals(value2);
    }

    public static bool operator !=(NotNullString obj1 , NotNullString obj2)
    {
      return (obj1 == obj2) == false;
    }

    public static bool operator !=(NotNullString obj1, string value2)
    {
      return (obj1 == value2) == false;
    }
    #endregion

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
      return IsValid(candidate, 1, maxLength);
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

    #region Overrides
    public override bool Equals(object obj)
    {
      NotNullString typedObj = obj as NotNullString;
      if (typedObj == null)
        return false;

      return typedObj.Value.Equals(Value);
    }

    public override int GetHashCode()
    {
      return Value.GetHashCode();
    }
    #endregion

    private const int MaxLength = 2048;
  }
}
