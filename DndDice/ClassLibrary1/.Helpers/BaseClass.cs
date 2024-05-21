namespace DiceProject.Helpers
{
  public class BaseClass
  {
    public BaseClass() { }

    private static DiceRoller diceRoller;

    public static DiceRoller DiceRoller => diceRoller = new DiceRoller();
  }
}
