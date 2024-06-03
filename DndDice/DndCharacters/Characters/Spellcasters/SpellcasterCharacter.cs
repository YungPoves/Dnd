using Characters;
using MagicDestroyers.Enumerations;
using MagicDestroyers.Interfaces;

namespace MagicDestroyers.Characters.Spellcasters
{
  public abstract class SpellcasterCharacter : Character
  {
    private const int MinSpellPoints = 0;
    private const int MaxSpellPoints = 500;
    private const int DefaultSpellPoints = 150;

    public SpellcasterCharacter(string name, int level, int healthPoints) : base(name, level, healthPoints)
    {
    }

    public override string ToString()
    {
      string message;

      message = $"NAME: {Name}\nLEVEL: {Level}\nHEALTH: {HealthPoints}\nSPELL POINTS: {SpellPoints}\n";
      return message;
    }

    #region Properties
    public virtual int SpellPoints
    {
      get => spellPoints;
      set
      {
        if (value < MinSpellPoints || value > MaxSpellPoints)
        {
          Console.WriteLine($"The spell points for character {Name} must be between {MinSpellPoints} and {MaxSpellPoints}.\n");
          spellPoints = DefaultSpellPoints;
        }
        else
        {
          spellPoints = value;
        }
      }
    }

    public override Factions Faction
    {
      get => faction;
      set => faction = Factions.Spellcaster;
    }
    #endregion

    #region Fields
    private int spellPoints;
    private Factions faction;
    #endregion
  }
}
