using DndDice.Die;

namespace dnddice.die
{
  public class D6 :
    BaseDice, IDice
  {
    public void Roll()
    {
      int result = Roll(Maximum);
      Console.WriteLine($"Rolling {DiceName}: {result}");
    }

    public override int Maximum => MAXIMUM;

    public override string DiceName => DICENAME;

    private const int MAXIMUM = 7;
    private const string DICENAME = nameof(D6);
  }
}
