using MagicDestroyers.Characters.Melee;
using MagicDestroyers.Constants;
using MagicDestroyers.Equipment.Armors.Heavy;
using MagicDestroyers.Equipment.Weapons.Blunt;
using System;

namespace Characters
{
  public class Knight : MeleeCharacter
  {
    #region ctor
    public Knight() : this(Constants.Knight.DefaultName, Constants.Knight.DefaultLevel)
    {
    }
    public Knight(string name, int level) : this(name, level, Constants.Knight.DefaultHealth)
    {
    }
    public Knight(string name, int level, int healthPoints) : base(name, level, healthPoints)
    {
      base.AbilityPoints = Constants.Knight.DefaultAbilityPoints;

      base.BodyArmor = new Chainlink();
      base.Weapon = new Hammer();
    }
    #endregion

    public override string ToString()
    {
      return $"{base.ToString()}CLASS: {Constants.Knight.CharacterClass}\nFACTION: {Faction}\n";
    }

    #region Abilities
    private int HolyBlow()
    {
      throw new NotImplementedException();
    }
    private int PurifySoul()
    {
      throw new NotImplementedException();
    }
    private int RighteousWings()
    {
      throw new NotSupportedException();
    }

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
    #endregion

  }
}
