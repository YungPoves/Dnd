using System.Security.Cryptography.X509Certificates;

namespace DndDice
{
  public class DiceHelperBase
  {
    public DiceHelperBase() { }

    public DiceHelpers DiceHelpers => diceHelpers ??= new DiceHelpers();

    private DiceHelpers diceHelpers;      
  }
}
