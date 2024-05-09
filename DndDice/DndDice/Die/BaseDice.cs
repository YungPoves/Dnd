namespace DndDice.Die
{
  public abstract class BaseDice
  {
    protected BaseDice()
    {
      random = new Random();
    }

    public int Roll(int max)
    {
      BaseDice.Result = BaseDice.Random.Next(Minimum, max);

      return BaseDice.Result;
    }

    public int RollWithModifiers(int max, int modifier)
    {
      int rollResult = Roll(max);
      if (rollResult == 1)
      {
        Console.WriteLine($"{rollResult}! Critical fail.");
        return rollResult;
      }
      else rollResult += + modifier;
      Console.WriteLine($"Roll({BaseDice.Result}) + Modifier({modifier}) = {BaseDice.Result + modifier}");

      return rollResult;
    }

    public virtual int GetMaximum()
    {
      return Maximum;
    }

    public abstract int Maximum { get; }
    public abstract string DiceName { get; }

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

    private const int Minimum = 1;

    private static Random? random;
    private static int result;
  }
}
