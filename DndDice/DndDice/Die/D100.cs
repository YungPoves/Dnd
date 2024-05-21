namespace DndDice.Die
{
  public class D100 :
    BaseDice, IDice
  {
    public D100() : base(NUMBER_OF_SIDES, DICENAME)
    {
    }

    public int Roll()
    {
      int result = Roll(NumberOfSides);
      //Console.WriteLine($"Rolling {DiceName}: {result}");

      return result;
    }

    private const int NUMBER_OF_SIDES = 101;
    private const string DICENAME = nameof(D100);
  }
}
