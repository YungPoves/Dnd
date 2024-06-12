using MagicDestroyers.Enumerations;
using MagicDestroyers.Equipment.Armors;
using MagicDestroyers.Equipment.Weapons;
using MagicDestroyers.Interfaces;

namespace Characters
{
  public abstract class Character : IAttacking, IDefending
  {
    private const int MinHealth = 1;
    private const int MaxHealth = 400;
    private const int MinLevel = 1;
    private const int MaxLevel = 100;

    private const int DefaultLevel = 1;

    private const string DefaultName = "Default Name";

    protected Character(string name, int level, int healthPoints)
    {
      this.Name = name;
      this.Level = level;
      this.HealthPoints = healthPoints;

      this.Faction = faction;
    }

    public abstract int Attack();

    public abstract int SpecialAttack();

    public abstract void Defend();

    public void TakeDamage(int damage)
    {
      this.HealthPoints -= damage;
    }

    #region Properties
    public virtual int HealthPoints
    {
      get => healthPoints;
      set
      {
        if (value < MinHealth || value > MaxHealth)
        {
          //Console.WriteLine($"Healthpoints for {this.Name} must be between {MinHealth} and {MaxHealth}.\n");
        }
        else healthPoints = value;
      }
    }
    public virtual int Level
    {
      get => level;
      set
      {
        if (value < MinLevel || value > MaxLevel)
        {
          //Console.WriteLine($"The level for character {this.Name} must be between {MinLevel} and {MaxLevel}.\n");
          this.Level = DefaultLevel;
        }
        else level = value;
      }
    }

    public int Strength 
    {
      get => strength;
      set => strength = value;
    }
    public int Dexterity
    {
      get => dexterity;
      set => dexterity = value;
    }
    public int Constitution 
    {
      get => constitution;
      set => constitution = value;
    }
    public int Wisdom 
    {
      get => wisdom;
      set => wisdom = value;
    }
    public int Intelligence 
    {
      get => intelligence;
      set => intelligence = value;
    }
    public int Charisma 
    {
      get => charisma;
      set => charisma = value;
    }

    public int StrengthModifier 
    {
      get => strengthModifier;
      set => strengthModifier = (Strength - 10) / 2;
    }

    public virtual string Name
    {
      get => name;
      set
      {
        if (!string.IsNullOrEmpty(value))
        {
          name = value;
        }
        else
        {
          name = DefaultName;
          //Console.WriteLine("Character name cannot be empty.");
        }
      }
    }

    public virtual Factions Faction
    {
      get => faction;
      set => faction = value;
    }
    public Armor BodyArmor 
    {
      get => bodyArmor;
      set => bodyArmor = value;
    }
    public Weapon Weapon 
    {
      get => weapon;
      set => weapon = value;
    }

    public virtual int AttackDamage
    {
      get => this.weapon.Damage;
      set => this.weapon.Damage = value;
    }
    #endregion

    #region Fields
    private int healthPoints;
    private int level;

    private int strength;
    private int dexterity;
    private int constitution;
    private int wisdom;
    private int intelligence;
    private int charisma;

    private int strengthModifier;

    private string name;

    private Armor bodyArmor;
    private Weapon weapon;
    private Factions faction;
    #endregion
  }
}
