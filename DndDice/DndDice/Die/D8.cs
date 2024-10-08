﻿namespace DndDice.Die
{
  public class D8 :
    BaseDice, IDice
  {
    public D8() : base(NUMBER_OF_SIDES, DICENAME)
    {
    }

    public int Roll()
    {
      int result = Roll(NumberOfSides);
      //Console.WriteLine($"Rolling {DiceName}: {result}");

      return result;
    }

    private const int NUMBER_OF_SIDES = 9;
    private const string DICENAME = nameof(D8);
  }
}
