using Characters;
using MagicDestroyers.Characters.Melee;
using System.Collections;

namespace MagicDestroyers.Enumerations
{
  public class MeleeTeam
  {
    public MeleeTeam() 
    {
      this.Characters = new List<MeleeCharacter>();
    }

    public void Add(MeleeCharacter character)
    {
      characters.Add(character);
    }

    public override string ToString()
    {
      string message = string.Empty;

      foreach (MeleeCharacter character in characters)
      {
        message += $"{character}\n";
      }
      return message;
    }

    //public IEnumerator GetEnumerator()
    //{
    //  throw new NotImplementedException();
    //}

    public List<MeleeCharacter> Characters 
    {
      get => characters;
      set => characters = value;
    }

    private List<MeleeCharacter> characters;
  }
}
