namespace DndDice.Die
{
  public class D8 :
    BaseDice, IDice
  {
    public D8()
    {
      this.NumberOfSides = NUMBER_OF_SIDES;
      this.DiceName = DICENAME;
    }

    public void Roll()
    {
      int result = Roll(NumberOfSides);
      Console.WriteLine($"Rolling {DiceName}: {result}");
    }

    private const int NUMBER_OF_SIDES = 9;
    private const string DICENAME = nameof(D8);
  }
}
