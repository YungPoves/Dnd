//using MagicDestroyers.Characters.Spellcasters;
//using MagicDestroyers.Equipment.Armors.Medium;
//using MagicDestroyers.Equipment.Weapons.Blunt;

//namespace Characters
//{
//  public class Druid : SpellcasterCharacter
//  {
//    #region Defaults
//    private const string DefaultName = "Default Druid";
//    private const string CharacterClass = "DRUID";

//    private const int MinHealth = 1;
//    private const int MaxHealth = 300;

//    private const int DefaultHealthPoints = 200;
//    private const int DefaultLevel = 1;
//    private const int DefaultSpellPoints = 150;
//    #endregion

//    #region ctor
//    public Druid() :
//      this(DefaultName, DefaultLevel)
//    {
//    }
//    public Druid(string name, int level) : this(name, level, DefaultHealthPoints)
//    {
//    }
//    public Druid(string name, int level, int healthPoints) : base(name, level, healthPoints)
//    {
//      this.SpellPoints = DefaultSpellPoints;

//      base.BodyArmor = new LightLeatherVest();
//      base.Weapon = new Staff();
//    }
//    #endregion

//    public override string ToString()
//    {
//      return $"{base.ToString()}CLASS: {CharacterClass}\nFACTION: {Faction}\n";
//    }

//    #region Abilities
//    public void Moonfire()
//    {
//      throw new NotImplementedException();
//    }
//    public void Starburst()
//    {
//      throw new NotImplementedException();
//    }
//    public void OneWithNature()
//    {
//      throw new NotImplementedException();
//    }

//    public override void Defend()
//    {
//      throw new NotImplementedException();
//    }

//    public override void Attack(Character target)
//    {
//      throw new NotImplementedException();
//    }

//    public override void SprecialAttack(Character target)
//    {
//      throw new NotImplementedException();
//    }
//    #endregion

//    #region Properties
//    public override int HealthPoints
//    {
//      get => healthPoints;
//      set
//      {
//        if (value > MinHealth && value <= MaxHealth)
//        {
//          healthPoints = value;
//        }
//        else
//        {
//          Console.WriteLine($"Healthpoints for {this.Name} must be between {MinHealth} and {MaxHealth}.\n");
//          healthPoints = DefaultHealthPoints;
//        }
//      }
//    }
//    public override int SpellPoints 
//    {
//      get => spellPoints;
//      set => spellPoints = value;
//    }
//    #endregion

//    #region Fields
//    private int healthPoints;
//    private int spellPoints;
//    #endregion
//  }
//}
