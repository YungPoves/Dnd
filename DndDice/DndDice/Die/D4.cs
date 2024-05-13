namespace DndDice.Die
{
  public class D4 :
    BaseDice, IDice
  {
    public D4()
    {
      this.NumberOfSides = NUMBER_OF_SIDES;
      this.DiceName = DICENAME;
    }

    public void Roll()
    {
      int result = Roll(NumberOfSides);
      Console.WriteLine($"Rolling {DiceName}: {result}");
    }

    private const int NUMBER_OF_SIDES = 5;
    private const string DICENAME = nameof(D4);
  }
}
