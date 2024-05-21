namespace DiceProject.Die
{
  public class D10 :
    BaseDice, IDice
  {
    public D10() : base(NUMBER_OF_SIDES, DICENAME)
    {
    }

    public int Roll()
    {
      int result = Roll(NumberOfSides);
      //Console.WriteLine($"Rolling {DiceName}: {result}");

      return result;
    }

    private const int NUMBER_OF_SIDES = 11;
    private const string DICENAME = nameof(D10);
  }
}
