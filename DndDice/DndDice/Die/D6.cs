using DndDice.Die;

namespace dnddice.die
{
  public class D6 :
    BaseDice, IDice
  {
    public int Roll()
    {
      int result = base.Roll(Maximum);
      Console.WriteLine($"Rolling {DiceName}: {result}");
      return result;
    }

    public override int Maximum => MAXIMUM;

    public override string DiceName => DICENAME;

    private const int MAXIMUM = 7;
    private const string DICENAME = nameof(D6);
  }
}
