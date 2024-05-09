namespace DndDice.Die
{
  public class D20 :
      BaseDice, IDice
  {
    public void Roll()
    {
      int result = base.Roll(Maximum);
      Console.WriteLine($"Rolling {DiceName}: {result}");
    }

    public override int Maximum => MAXIMUM;

    public override string DiceName => DICENAME;

    private const int MAXIMUM = 21;
    private const string DICENAME = nameof(D20);

  }
}
