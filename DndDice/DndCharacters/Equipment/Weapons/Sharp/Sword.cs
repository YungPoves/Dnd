using System;

namespace MagicDestroyers.Equipment.Weapons.Sharp
{
  public class Sword : Weapon
  {
    private const int DefaultDamage = 9;

    public Sword() : base(DefaultDamage)
    {
      base.Damage = DefaultDamage;
    }

    public void Bloodthirst()
    {
      throw new NotImplementedException();
    }
  }
}
