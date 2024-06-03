namespace MagicDestroyers.Equipment.Weapons.Blunt
{
  public class Hammer : Weapon
  {
    private const int DefaultDamage = 10;

    public Hammer() : base(DefaultDamage)
    {
      base.Damage = DefaultDamage;
    }

    public void Stun()
    {
      throw new NotImplementedException();
    }
  }
}
