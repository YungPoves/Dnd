namespace DndDice.Die
{
  public class D6 :
    BaseDice
  {
    public D6()
    {
      this.Random = new Random();
    }

    public override int Roll()
    {
      this.Result = this.Random.Next(Minimum, Maximum);
      return this.Result;
    }

    private const int Minimum = 1;
    private const int Maximum = 7;
  }
}
