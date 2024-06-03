using System;

namespace MagicDestroyers.Equipment.Weapons
{
  public abstract class Weapon
  {
    private const int MinimumDamage = 1;

    public Weapon(int damage)
    {
      this.Damage = damage;
    }

    public virtual int Damage
    {
      get => damage;
      set
      {
        try
        {
          if (value < MinimumDamage)
            throw new ArgumentOutOfRangeException(string.Empty, "The weapon damage is too low.");
          damage = value;
        }
        catch (ArgumentOutOfRangeException ex)
        {
          //Console.WriteLine(ex.Message);
        }
      }
    }

    private int damage;
  }
}
