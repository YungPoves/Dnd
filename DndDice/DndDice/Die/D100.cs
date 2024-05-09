namespace DndDice.Die
{
  public class D100 :
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

    private const int MAXIMUM = 101;
    private const string DICENAME = nameof(D100);
  }
}
