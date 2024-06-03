namespace Spells
{
  public class Firebolt : Spell
  {
    private const int DefaultDamage = 2;
    private const int DefaultManaCost = 15;
    private const string SpellName = "Firebolt";

    public Firebolt() : this(DefaultManaCost, DefaultDamage, SpellName)
    {
    }

    public Firebolt(int manaCost, int damage, string name) : base(manaCost, damage, name)
    {
      base.Damage = DefaultDamage;
      base.ManaCost = DefaultManaCost;
      base.Name = SpellName;
    }
  }
}
