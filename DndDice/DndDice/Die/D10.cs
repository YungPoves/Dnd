namespace DndDice.Die
{
  public class D10 :
    BaseDice, IDice
  {
    public D10()
    {
      this.NumberOfSides = NUMBER_OF_SIDES;
      this.DiceName = DICENAME;
    }
    public void Roll()
    {
      int result = Roll(NumberOfSides);
      Console.WriteLine($"Rolling {DiceName}: {result}");
    }

    private const int NUMBER_OF_SIDES = 11;
    private const string DICENAME = nameof(D10);
  }
}
