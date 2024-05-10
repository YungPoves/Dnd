namespace DndDice.Die
{
  public class D8 :
    BaseDice, IDice
  {
    public void Roll()
    {
      int result = Roll(Maximum);
      Console.WriteLine($"Rolling {DiceName}: {result}");
    }

    public override int Maximum => MAXIMUM;

    public override string DiceName => DICENAME;

    private const int MAXIMUM = 9;
    private const string DICENAME = nameof(D8);

  }
}
