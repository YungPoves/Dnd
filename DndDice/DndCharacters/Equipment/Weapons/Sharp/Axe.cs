using Characters;
using System;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
  public class Axe : Weapon
  {
    //private const int DefaultDamage = 15;

    public Axe() : base(Equipment.Constants.Axe.DefaultDamage)
    {
    }
    public Axe(Character weaponUser) : base(Equipment.Constants.Axe.DefaultDamage)
    {
      this.DamageModifier = weaponUser.StrengthModifier;
      this.DamageTotal = this.Damage + this.DamageModifier;
    }

    public void HackNSlash()
    {
      throw new NotImplementedException();
    }
  }
}
