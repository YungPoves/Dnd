using DiceProject.Die;
using System;
using System.Collections.Generic;

namespace DiceProject
{
  public class DiceRoller
  {
    public DiceRoller()
    {
    }

    public D4 D4s => Helper<D4>();

    public D6 D6s => Helper<D6>();

    public D8 D8s => Helper<D8>();

    public D10 D10s => Helper<D10>();

    public D12 D12s => Helper<D12>();

    public D20 D20s => Helper<D20>();

    public D100 D100s => Helper<D100>();

    private TDiceType Helper<TDiceType>() where TDiceType : BaseDice
    {
      Type helperType = typeof(TDiceType);

      if (dieByType.ContainsKey(helperType) == false)
        dieByType[helperType] = Activator.CreateInstance(helperType);

      return (TDiceType)dieByType[helperType];
    }

    private readonly Dictionary<Type, object> dieByType = new Dictionary<Type, object>();
  }
}
