namespace DndDice.Die
{
  public class D8 :
    BaseDice, IDice
  {
    public int Roll()
    {
      int result = base.Roll(Maximum);
      Console.WriteLine($"Rolling {DiceName}: {result}");
      return result;
    }

    public override string DiceName => DICENAME;

    public override int Maximum => MAXIMUM;

    private const string DICENAME = nameof(D8);
    private const int MAXIMUM = 9;

  }
}
