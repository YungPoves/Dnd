//using MagicDestroyers.Characters.Melee;
//using MagicDestroyers.Equipment.Armors.Heavy;
//using MagicDestroyers.Equipment.Weapons.Blunt;

//namespace Characters
//{
//  public class Knight : MeleeCharacter
//  {
//    #region Defaults

//    private const int MinHealth = 1;
//    private const int MaxHealth = 500;

//    private readonly Chainlink DefaultBodyArmor = new Chainlink();
//    private readonly Hammer DefaultWeapon = new Hammer();
//    #endregion

//    #region ctor
//    public Knight() : this(DefaultName, DefaultLevel)
//    {
//    }
//    public Knight(string name, int level) : this(name, level, DefaultHealthPoints)
//    {
//    }
//    public Knight(string name, int level, int healthPoints) : base(name, level, healthPoints)
//    {
//      this.HealthPoints = healthPoints;
//      this.AbilityPoints = DefaultAbilityPoints;

//      this.BodyArmor = DefaultBodyArmor;
//      this.Weapon = DefaultWeapon;
//    }
//    #endregion

//    #region Abilities
//    public void HolyBlow()
//    {
//      throw new NotImplementedException();
//    }
//    public void PurifySoul()
//    {
//      throw new NotImplementedException();
//    }
//    public void RighteousWings()
//    {
//      throw new NotSupportedException();
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

//    public override string ToString()
//    {
//      return $"{base.ToString()}CLASS: {CharacterClass}\nFACTION: {Faction}\n";
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
//          Console.WriteLine($"Healthpoints for {this.Name} must be between {MinHealth} and {MaxHealth}.\n");
//          healthPoints = DefaultHealthPoints;
//        }
//      }
//    }
//    public override int AbilityPoints
//    {
//      get => abilityPoints;
//      set => abilityPoints = value;
//    }

//    public Chainlink BodyArmor
//    {
//      get => bodyArmor;
//      set => bodyArmor = value;
//    }
//    public Hammer Weapon
//    {
//      get => weapon;
//      set => weapon = value;
//    }
//    #endregion

//    #region Fields
//    private int healthPoints;
//    private int abilityPoints;

//    private Chainlink bodyArmor;
//    private Hammer weapon;
//    #endregion
//  }
//}
