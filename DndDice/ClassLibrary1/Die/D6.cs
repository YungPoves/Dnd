namespace DiceProject.Die
{
  public class D6 :
    BaseDice, IDice
  {
    public D6() : base(NUMBER_OF_SIDES, DICENAME)
    {
    }

    public int Roll()
    {
      int result = Roll(NumberOfSides);
      //Console.WriteLine($"Rolling {DiceName}: {result}");

      return result;
    }

    private const int NUMBER_OF_SIDES = 7;
    private const string DICENAME = nameof(D6);
  }
}
