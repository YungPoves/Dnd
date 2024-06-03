using System;

namespace MagicDestroyers.Equipment.Weapons.Blunt
{
  public class Staff : Weapon
  {
    private const int DefaultDamage = 4;

    public Staff() : base(DefaultDamage)
    {
      base.Damage = DefaultDamage;
    }

    public void Empower()
    {
      throw new NotImplementedException();
    }
  }
}
