﻿using DndDice;
using DndDice.Helpers;

internal class Program :
  BaseClass
{
  private static void Main()
  {
    int numberOfDice = 5;

    for (int i = 0; i < numberOfDice; i++)
    {
      DiceRoller.D4s.Roll();
      DiceRoller.D6s.Roll();
      DiceRoller.D8s.Roll();
      DiceRoller.D10s.Roll();
      DiceRoller.D12s.Roll();
      DiceRoller.D20s.Roll();
      DiceRoller.D100s.Roll();
      Console.WriteLine();
    }

    //for (int i = 0; i < 10; i++) 
    //{
    //  DiceRoller.D20s.Roll();
    //}
  }
}