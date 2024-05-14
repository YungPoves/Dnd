namespace DndDice.Die
{
  public abstract class BaseDice
  {
    protected BaseDice() : this(NumberOfSides, DiceName)
    {
    }

    protected BaseDice(int numberOfSides, string? diceName)
    {
      NumberOfSides = numberOfSides;
      DiceName = diceName;
      Random = new Random();
    }

    public static int Roll(int numberOfSides)
    {
      BaseDice.Result = BaseDice.Random.Next(Minimum, numberOfSides);

      return BaseDice.Result;
    }

    public int RollWithModifiers(int numberOfSides, int modifier)
    {
      int rollResult = Roll(numberOfSides);
      if (rollResult == 1)
      {
        Console.WriteLine($"{rollResult}! Critical fail.");
        return rollResult;
      }
      else rollResult += + modifier;
      Console.WriteLine($"Roll({BaseDice.Result}) + Modifier({modifier}) = {BaseDice.Result + modifier}");

      return rollResult;
    }

    public virtual int GetNumberOfSides()
    {
      return NumberOfSides;
    }

    private const int Minimum = 1;

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

    private static int numberOfSides;
    private static string? diceName;

    private static Random? random;
    private static int result;
  }
}
