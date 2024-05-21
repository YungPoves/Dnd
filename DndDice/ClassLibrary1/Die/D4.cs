namespace DiceProject.Die
{
  public class D4 :
    BaseDice, IDice
  {
    public D4() : base(NUMBER_OF_SIDES, DICENAME)
    {
    }

    public int Roll()
    {
      int result = Roll(NumberOfSides);
      //Console.WriteLine($"Rolling {DiceName}: {result}");

      return result;
    }

    private const int NUMBER_OF_SIDES = 5;
    private const string DICENAME = nameof(D4);
  }
}
