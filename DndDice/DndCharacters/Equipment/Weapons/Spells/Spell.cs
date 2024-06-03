using Characters;
using Interfaces;

namespace Spells
{
  public abstract class Spell
  {
    private const int DefaultDamage = 5;

    public Spell()
    {
      this.Damage = DefaultDamage;
    }
    public Spell(int manaCost, int damage, string name)
    {
      this.Damage = damage;
      this.ManaCost = manaCost;
      this.Name = name;
    }

    public override string ToString()
    {
      return $"Spell Name: {this.Name}\nDamage: {this.Damage}\nMana Cost: {this.ManaCost}\n";
    }

    public virtual int Damage
    {
      get => damage;
      set => damage = value;
    }
    public virtual int ManaCost
    {
      get => manaCost;
      set => manaCost = value;
    }
    public virtual string Name
    {
      get => name;
      set => name = value;
    }

    private int damage;
    private int manaCost;
    private string name;
  }
}
