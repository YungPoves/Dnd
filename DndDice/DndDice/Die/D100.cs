namespace DndDice.Die
{
  public class D100 :
    BaseDice, IDice
  {
    public void Roll()
    {
      int result = base.Roll(Maximum);
      Console.WriteLine($"Rolling {DiceName}: {result}");
    }

    public override int Maximum => MAXIMUM;

    public override string DiceName => DICENAME;

    private const int MAXIMUM = 101;
    private const string DICENAME = nameof(D100);
  }
}
