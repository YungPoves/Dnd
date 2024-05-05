namespace DndDice.Die
{
  public class D4
  {
    public D4()
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
    private const int Maximum = 5;

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
