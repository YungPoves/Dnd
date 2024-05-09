namespace DndDice.Die
{
  public class D4 :
    BaseDice, IDice
  {
    public void Roll()
    {
      int result = base.Roll(Maximum);
      Console.WriteLine($"Rolling {DiceName}: {result}");
    }

    public override int Maximum => MAXIMUM;

    public override string DiceName => DICENAME;

    private const int MAXIMUM = 5;
    private const string DICENAME = nameof(D4);
  }
}
