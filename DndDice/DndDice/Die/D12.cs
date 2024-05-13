namespace DndDice.Die
{
  public class D12 :
    BaseDice, IDice
  {
    public D12()
    {
      this.NumberOfSides = NUMBER_OF_SIDES;
      this.DiceName = DICENAME;
    }

    public void Roll()
    {
      int result = Roll(NumberOfSides);
      Console.WriteLine($"Rolling {DiceName}: {result}");
    }

    private const int NUMBER_OF_SIDES = 13;
    private const string DICENAME = nameof(D12);
  }
}
