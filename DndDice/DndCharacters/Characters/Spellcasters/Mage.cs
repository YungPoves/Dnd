using Interfaces;
using MagicDestroyers.Characters.Spellcasters;
using MagicDestroyers.Constants;
using MagicDestroyers.Equipment.Armors.Light;
using MagicDestroyers.Equipment.Weapons.Blunt;
using Spells;

namespace Characters
{
  public class Mage : SpellcasterCharacter, ISpellcaster
  {
    #region ctor
    public Mage() : this(Constants.Mage.DefaultName, Constants.Mage.DefaultLevel)
    {
    }
    public Mage(string name, int level) : this(name, level, Constants.Mage.DefaultHealth)
    {
    }
    public Mage(string name, int level, int healthPoints) : base(name, level, healthPoints)
    {
      base.SpellPoints = Constants.Mage.DefaultSpellPoints;

      base.BodyArmor = new ClothRobe();
      base.Weapon = new Staff();
      this.Firebolt = new Firebolt();
    }
    #endregion

    public override string ToString()
    {
      return $"{base.ToString()}CLASS: {Constants.Mage.CharacterClass}\nFACTION: {this.Faction}\n{this.Firebolt}\n";
    }

    #region Abilities
    public int ArcaneWrath()
    {
      const int ManaCost = 25;

      if (ManaCost > this.SpellPoints)
      {
        Console.WriteLine($"{this.Name} does not have enough spell points to use {nameof(ArcaneWrath)}");
        
        return 0;
      }
      else
      {
        Console.WriteLine($"{this.Name} casts {nameof(ArcaneWrath)}!");
        this.SpellPoints -= ManaCost;

        return this.Weapon.Damage + 15;
      }
    }

    public int Firewall()
    {
      const int ManaCost = 65;

      if (ManaCost > this.SpellPoints)
      {
        Console.WriteLine($"{this.Name} does not have enough spell points to use {nameof(Firewall)}");

        return 0;
      }
      else
      {
        Console.WriteLine($"{this.Name} casts {nameof(Firewall)}!");
        this.SpellPoints -= ManaCost;

        return this.Weapon.Damage + 50;
      }
    }

    public void Meditation()
    {
      throw new NotImplementedException();
    }

    public override int Attack()
    {
      return this.ArcaneWrath();
    }

    public override int SpecialAttack()
    {
      return this.Firewall();
    }

    public override void Defend()
    {
      this.Meditation();
    }

    public void CastFireBolt(Character target)
    {
      CastSpell(firebolt, target);
    }

    public void CastSpell(Spell spell, Character target)
    {
      this.SpellPoints -= spell.ManaCost;
      Console.WriteLine($"{this.Name} casts {spell.Name} on {target.Name}, dealing {spell.Damage} points of damage!\n");
      target.HealthPoints -= spell.Damage;
    }
    #endregion

    #region Properties
    public Firebolt Firebolt
    {
      get => firebolt;
      set => firebolt = value;
    }
    public Spell Spell
    {
      get => throw new NotImplementedException();
      set => throw new NotImplementedException();
    }
    #endregion

    #region Fields
    private Firebolt firebolt;
    #endregion
  }
}