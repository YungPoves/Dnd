using Characters;
using Spells;

namespace Interfaces
{
  public interface ISpellcaster
  {
    Spell Spell { get; set; }

    void CastSpell(Spell spell, Character target);
  }
}
