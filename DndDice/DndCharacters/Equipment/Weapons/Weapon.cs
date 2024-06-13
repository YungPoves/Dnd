using Characters;
using System;

namespace MagicDestroyers.Equipment.Weapons
{
  public abstract class Weapon
  {
    private const int MinimumDamage = 1;

    public Weapon(int damage)
    {
      this.Damage = damage;
      this.DamageTotal = damage + this.DamageModifier;
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

    public int DamageModifier 
    {
      get => damageModifier;
      set => damageModifier = value;
    }
    public int DamageTotal
    {
      get => damageTotal;
      set => damageTotal = value;
    }

    private int damage;
    private int damageModifier;
    private int damageTotal;
  }
}
