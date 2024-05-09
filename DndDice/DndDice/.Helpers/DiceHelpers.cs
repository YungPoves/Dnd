using DndDice.Die;

namespace DndDice
{
  public class DiceHelpers :
    IDisposable
  {
    public DiceHelpers()
    {
    }

    public void Dispose()
    {
      foreach(object value in diceByType.Values)
        (value as IDisposable)?.Dispose();

      diceByType.Clear();
    }

    //public D8 D8Helper => DiceHelper<D8>();

    private TDiceHelper DiceHelper<TDiceHelper>() where TDiceHelper : DiceHelperBase
    {
      Type helperType = typeof(TDiceHelper);

      if (diceByType.ContainsKey(helperType) == false)
        diceByType[helperType] = Activator.CreateInstance(helperType);

      return (TDiceHelper)diceByType[helperType];
    }

    private readonly Dictionary<Type, object> diceByType = new Dictionary<Type, object>();
  }
}
