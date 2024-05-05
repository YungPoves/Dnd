namespace DndDice.Die
{
  public class D6
  {
    public D6()
    {
      this.Random = new Random();
    }
    public int Roll()
    {
      this.Result = this.Random.Next(Minimum, Maximum);
      return this.Result;
    }

    private Random? random;
    private int result;

    private const int Minimum = 1;
    private const int Maximum = 7;

    public int Result
    {
      get => result;
      set => result = value;
    }
    public Random Random
    {
      get => random;
      set => random = value;
    }
  }
}
