namespace DndDice.Die
{
  public abstract class BaseDice
  {
    #region ctor
    protected BaseDice() : this(NumberOfSides, DiceName)
    {
    }

    protected BaseDice(int numberOfSides, string? diceName)
    {
      NumberOfSides = numberOfSides;
      DiceName = diceName;
      Random = new Random();
    } 
    #endregion

    public static int Roll(int numberOfSides)
    {
      BaseDice.Result = BaseDice.Random.Next(Minimum, numberOfSides);

      return BaseDice.Result;
    }

    private const int Minimum = 1;

    #region Properties
    public static int Result
    {
      get => result;
      set => result = value;
    }
    public static Random Random
    {
      get
      {
        random ??= new Random();
        return random;
      }
      set => random = value;
    }

    public static int NumberOfSides
    {
      get => numberOfSides;
      set => numberOfSides = value;
    }
    public static string? DiceName
    {
      get => diceName;
      set => diceName = value;
    }
    #endregion

    #region Fields
    private static int numberOfSides;
    private static string? diceName;

    private static Random? random;
    private static int result;
    #endregion
  }
}
