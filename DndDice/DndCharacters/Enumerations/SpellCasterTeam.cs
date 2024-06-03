using MagicDestroyers.Characters.Spellcasters;

namespace MagicDestroyers.Enumerations
{
  public class SpellCasterTeam
  {
    public SpellCasterTeam()
    {
      this.Characters = new List<SpellcasterCharacter>();
    }

    public void Add(SpellcasterCharacter character)
    {
      characters.Add(character);
    }

    public override string ToString()
    {
      string message = string.Empty;

      foreach (SpellcasterCharacter character in characters)
      {
        message += $"{character}\n";
      }
      return message;
    }

    public List<SpellcasterCharacter> Characters 
    {
      get => characters;
      set => characters = value;
    }

    private List<SpellcasterCharacter> characters;
  }
}
