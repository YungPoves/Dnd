namespace DndDice.Die
{
  public abstract class BaseDice
  {
    private Random? random;
    private int result;

    public int Result
    {
      get => result;
      set => result = value;
    }
    public Random Random
    {
      get
      {
        random ??= new Random();
        return random;
      }
      set => random = value;
    }
    public abstract int Roll();
  }
}
