//using MagicDestroyers.Characters.Spellcasters;
//using MagicDestroyers.Equipment.Armors.Medium;
//using MagicDestroyers.Equipment.Weapons.Sharp;

//namespace Characters
//{
//  public class Necromancer : SpellcasterCharacter
//  {
//    #region Defaults
//    private const string DefaultName = "Default Necromancer";
//    private const string CharacterClass = "NECROMANCER";

//    private const int MinHealth = 1;
//    private const int MaxHealth = 300;

//    private const int DefaultHealthPoints = 200;
//    private const int DafaultLevel = 1;
//    private const int DefaultSpellPoints = 200;
//    #endregion

//    #region ctor
//    public Necromancer() : this(DefaultName, DafaultLevel)
//    {
//    }
//    public Necromancer(string name, int level) : this(name, level, DefaultHealthPoints)
//    {
//    }
//    public Necromancer(string name, int level, int healthPoints) : base(name, level, healthPoints)
//    {
//      base.SpellPoints = DefaultSpellPoints;

//      base.BodyArmor = new LightLeatherVest();
//      base.Weapon = new Sword();
//    }
//    #endregion

//    #region Abilities
//    public void ShadowRage()
//    {
//      throw new NotImplementedException();
//    }
//    public void VampireTouch()
//    {
//      throw new NotImplementedException();
//    }
//    public void BoneShield()
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

//    public override void Defend()
//    {
//      throw new NotImplementedException();
//    }
//    #endregion

//    public override string ToString()
//    {
//      return $"{base.ToString()}CLASS: {CharacterClass}\nFACTION: {Faction}";
//    }

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
//          Console.WriteLine($"Healthoints for character {this.Name} must be between {MinHealth} and {MaxHealth}");
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
