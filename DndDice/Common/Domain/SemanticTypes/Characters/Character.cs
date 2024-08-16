namespace Common.SemanticTypes
{
  public class Character
  {
    public Character(string characterName)
    {
      this.Name = new CharacterName(characterName);
    }

    private CharacterName characterName;
    private string characterRace;
    private string characterclass;

    public CharacterName Name
    {
      get => characterName;
      set => characterName = value; 
    }

    public string Race { get => characterRace; set => characterRace = value; }
    public string Characterclass { get => characterclass; set => characterclass = value; }
  }
}
