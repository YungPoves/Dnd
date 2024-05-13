using DndDice.Die;

namespace dnddice.die
{
  public class D6 :
    BaseDice, IDice
  {
    public D6()
    {
      this.NumberOfSides = NUMBER_OF_SIDES;
      this.DiceName = DICENAME;
    }

    public void Roll()
    {
      int result = Roll(NumberOfSides);
      Console.WriteLine($"Rolling {DiceName}: {result}");
    }

    private const int NUMBER_OF_SIDES = 7;
    private const string DICENAME = nameof(D6);
  }
}
