using dnddice.die;
using DndDice.Die;

namespace DndDice
{
  public class DiceRoller
  {
    public DiceRoller()
    {
    }

    public D4 D4s => Helper<D4>();

    public D6 D6s => Helper<D6>();

    public D8 D8s => Helper<D8>();

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

public static int RollAttack(int modifier)
    {
      int roll = Random.Next(Minimum, 21);

      if (roll == 1)
      {
        Result = roll;
        return Result;
      }
      if (roll == 20)
      {
        Result = roll;
        return Result;
      }
      return Result;
    }

    public static int RollDamage(int diceSize, int modifier)
    {
      throw new NotImplementedException();
    }

    private const int Minimum = 1;

    //public BaseDice? Dice => dice;
    public static int Result
    {
      get => result;
      set => result = value;
    }
    public static Random Random
    {
      get
      {
        random ??= new Random();
        return random;
      }
      set => random = value;
    }

    private readonly BaseDice? dice;
    private static Random? random;
    private static int result;

    private readonly Dictionary<Type, object> dieByType = new Dictionary<Type, object>();
  }
}
