namespace DndDice.Die
{
  public class D20 :
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

    private const string DICENAME = nameof(D20);
    private const int MAXIMUM = 21;

  }
}
