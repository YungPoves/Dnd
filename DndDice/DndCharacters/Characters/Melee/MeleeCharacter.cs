using Characters;
using MagicDestroyers.Enumerations;

namespace MagicDestroyers.Characters.Melee
{
  public abstract class MeleeCharacter : Character
  {
    private const int MinAbilityPoints = 0;
    private const int MaxAbilityPoints = 100;
    private const int DefaultAbilityPoints = 100;

    public MeleeCharacter(string name, int level, int healthPoints) : base(name, level, healthPoints)
    {
    }

    public override string ToString()
    {
      string message;

      message = $"NAME: {Name}\nLEVEL: {Level}\nHEALTH: {HealthPoints}\nABILITY POINTS: {AbilityPoints}\n";
      return message;
    }

    #region Properties
    public virtual int AbilityPoints
    {
      get => abilityPoints;
      set
      {
        if (value < MinAbilityPoints || value > MaxAbilityPoints)
        {
          abilityPoints = DefaultAbilityPoints;
        }
        abilityPoints = value;
      }
    }
    public override Factions Faction
    {
      get => this.faction;
      set => this.faction = Factions.Melee;
    }
    #endregion

    #region Fields
    private int abilityPoints;
    private Factions faction;
    #endregion
  }
}
