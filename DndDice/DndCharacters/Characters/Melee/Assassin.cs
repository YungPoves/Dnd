using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Constants;
using MagicDestroyers.Equipment.Armors.Medium;
using MagicDestroyers.Equipment.Weapons.Sharp;
using System;

namespace Characters
{
  public class Assassin : MeleeCharacter
  {
    //#region Defaults

    //private const int MinHealth = 1;
    //private const int MaxHealth = 200;

    private readonly LightLeatherVest DefaultBodyArmor = new LightLeatherVest();
    private readonly Sword DefaultWeapon = new Sword();
    //#endregion

    //#region ctor
    //public Assassin() :
    //  this(DefaultName, DefaultLevel)
    //{
    //}
    //public Assassin(string name, int level) :
    //  this(name, level, DefaultHealthPoints)
    //{
    //}
    public Assassin(string name, int level, int healthPoints) :
      base(name, level, healthPoints)
    {
      this.AbilityPoints = Constants.Assassin.DefaultAbilityPoints;
      this.HealthPoints = healthPoints;

      this.BodyArmor = DefaultBodyArmor;
      this.Weapon = DefaultWeapon;
    }
    //#endregion

    //public override string ToString()
    //{
    //  return $"{base.ToString()}CLASS: {CharacterClass}\nFACTION: {Faction}\n";
    //}

    //#region Abilities
    //public void Raze()
    //{
    //  throw new NotImplementedException();
    //}

    //public void BleedToDeath()
    //{
    //  throw new NotImplementedException();
    //}

    //public void Survival()
    //{
    //  throw new NotImplementedException();
    //}

    public override int Attack()
    {
      throw new NotImplementedException();
    }

    public override int SpecialAttack()
    {
      throw new NotImplementedException();
    }

    public override void Defend()
    {
      throw new NotImplementedException();
    }

    //public override int Attack()
    //{
    //  throw new System.NotImplementedException();
    //}

    //public override int SpecialAttack()
    //{
    //  throw new System.NotImplementedException();
    //}
    //#endregion

    //#region Properties
    //public override int HealthPoints
    //{
    //  get => healthPoints;
    //  set
    //  {
    //    if (value >= MinHealth && value <= MaxHealth)
    //    {
    //      healthPoints = value;
    //    }
    //    else
    //    {
    //      Console.WriteLine($"Healthpoints for {this.Name} must be between {MinHealth} and {MaxHealth}.\n");
    //      healthPoints = DefaultHealthPoints;
    //    }
    //  }
    //}
    //public override int AbilityPoints
    //{
    //  get => abilityPoints;
    //  set => abilityPoints = value;
    //}

    //public LightLeatherVest BodyArmor
    //{
    //  get => bodyArmor;
    //  set => bodyArmor = value;
    //}
    //public Sword Weapon
    //{
    //  get => weapon;
    //  set => weapon = value;
    //}
    //#endregion

    //#region Fields
    //private int healthPoints;
    //private int abilityPoints;

    //private LightLeatherVest bodyArmor;
    //private Sword weapon;
    //#endregion
  }
}
