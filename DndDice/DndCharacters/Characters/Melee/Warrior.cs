using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Constants;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Sharp;

namespace Characters
{
  public class Warrior : MeleeCharacter
  {
    #region ctor
    public Warrior() : this(Constants.Warrior.DefaultName, Constants.Warrior.DefaultLevel)
    {
    }
    public Warrior(string name, int level) : this(name, level, Constants.Warrior.DefaultHealth)
    {
    }
    public Warrior(string name, int level, int healthPoints) : base(name, level, healthPoints)
    {
      base.AbilityPoints = Constants.Warrior.DefaultAbilityPoints;

      base.BodyArmor = new Chainlink();
      base.Weapon = new Axe();
    }
    #endregion

    public override string ToString()
    {
      return $"{base.ToString()}CLASS: {Constants.Warrior.CharacterClass}\nFACTION: {this.Faction}\n";
    }

    #region Abilities
    private int Strike()
    {
      const int AbilityCost = 10;

      if (AbilityCost > this.AbilityPoints)
      {
        //Console.WriteLine($"{this.Name} does not have enough ability points to points so use {nameof(Strike)}.");
        
        return 0;
      }
      else
      {
        //Console.WriteLine($"{this.Name} uses {nameof(Strike)}!");
        this.AbilityPoints -= AbilityCost;

        return base.Weapon.Damage * 2;
      }
    }

    private int Execute()
    {
      const int AbilityCost = 30;

      if (this.AbilityPoints >= AbilityCost)
      {
        this.AbilityPoints -= AbilityCost;
        //Console.WriteLine($"{this.Name} uses {nameof(Execute)}!");
        return base.Weapon.Damage * 2;
      }
      else
      {
        //Console.WriteLine($"{this.Name} does not have enough ability points to points to use {nameof(Execute)}.");
        return 0;
      }
    }

    private void SkinHarden()
    {
      const int apCost = 10;

      this.BodyArmor.ArmorPoints *= 2;
      this.AbilityPoints -= apCost;

      //Console.WriteLine($"{this.Name} uses Skin Harden.");
    }

    public override int Attack()
    {
      return this.Strike();
    }

    public override int SpecialAttack()
    {
      return this.Execute();
    }

    public override void Defend()
    {
      const int apCost = 10;

      this.BodyArmor.ArmorPoints *= 2;
      this.AbilityPoints -= apCost;

      //Console.WriteLine($"{this.Name} uses {nameof(SkinHarden)}.");
    }
    #endregion
  }
}
