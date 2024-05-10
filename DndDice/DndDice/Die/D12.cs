namespace DndDice.Die
{
  public class D12 :
    BaseDice, IDice
  {
    public void Roll()
    {
      int result = Roll(NumberOfSides);
      Console.WriteLine($"Rolling {DiceName}: {result}");
    }

    public override int NumberOfSides => NUMBER_OF_SIDES;

    public override string DiceName => DICENAME;

    private const int NUMBER_OF_SIDES = 13;
    private const string DICENAME = nameof(D12);
  }
}
