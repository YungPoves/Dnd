namespace DndDice.Die
{
  public class D20 :
      BaseDice, IDice
  {
    public void Roll()
    {
      int result = Roll(NumberOfSides);

      switch (result)
      {
        case 1:
          Console.WriteLine($"{result}: Critical fail.");
          break;
        case 20:
          Console.WriteLine($"{result}: Critical success.");
          break;
        default:
          Console.WriteLine($"Rolling {DiceName}: {result}");
          break;
      }
    }

    public override int NumberOfSides => NUMBER_OF_SIDES;

    public override string DiceName => DICENAME;

    private const int NUMBER_OF_SIDES = 21;
    private const string DICENAME = nameof(D20);

  }
}
