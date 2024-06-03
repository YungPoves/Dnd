using Characters;

namespace MagicDestroyers.Enumerations
{
  public class CharacterList
  {
    public CharacterList() 
    {
      this.Characters = new List<Character>();
    }

    public void Add(Character character)
    {
      characters.Add(character);
    }

    public override string ToString()
    {
      string message = string.Empty;

      foreach (Character character in characters)
      {
        message += $"{character}\n";
      }
      return message;
    }

    public List<Character> Characters 
    {
      get => characters;
      set => characters = value;
    }

    private List<Character> characters;
  }
}
