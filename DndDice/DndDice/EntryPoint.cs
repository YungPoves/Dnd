using DndDice;
using DndDice.Die;
using DndDice.Helpers;

internal class Program :
  BaseClass
{
  private static void Main()
  {
    int numberOfDice = 6;
    int modifier = 5;

    for (int i = 0; i < numberOfDice; i++) 
    {
      DiceRoller.D8s.Roll();
      DiceRoller.D20s.Roll();
    }

    //Console.WriteLine($"Rolling {x} D6's: {D6.Roll(x)}");

    //Console.WriteLine($"Rolling {numberOfDice} D4's:");
    //Console.WriteLine($"{D4.Roll(numberOfDice, modifier)}");

    //Console.WriteLine($"Rolling {numberOfDice} D8's:");
    //Console.WriteLine($"{D8.Roll(numberOfDice, modifier)}");

    //Console.WriteLine($"Rolling {numberOfDice} D12's:");
    //Console.WriteLine($"{D12.Roll(numberOfDice, modifier)}");

    //Console.WriteLine($"Rolling {numberOfDice} D20's:");
    //Console.WriteLine($"{D20.Roll(numberOfDice, modifier)}");    
  }
}