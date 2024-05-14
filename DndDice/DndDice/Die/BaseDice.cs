namespace DndDice.Die
{
  public abstract class BaseDice
  {
    #region ctor
    protected BaseDice()
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

    public int NumberOfSides
    {
      get => numberOfSides;
      set => numberOfSides = value;
    }
    public string? DiceName
    {
      get => diceName;
      set => diceName = value;
    }
    #endregion

    #region Fields
    private int numberOfSides;
    private string? diceName;

    private static Random? random;
    private static int result;
    #endregion
  }
}
