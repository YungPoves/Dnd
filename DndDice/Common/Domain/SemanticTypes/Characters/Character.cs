using System.Collections.Generic;

namespace Common.SemanticTypes
{
  public class Character
  {
    public Character(string characterName)
    {
      this.Name = new CharacterName(characterName);
    }
    public Character(CharacterStats strength, CharacterStats dexterity)
    {
      this.AbilityScores = new List<CharacterStats>
      {
        strength,
        dexterity
      };
    }

    private CharacterName characterName;
    private List<CharacterStats> abilityScores;
    private string characterRace;
    private string characterclass;

    public CharacterName Name
    {
      get => characterName;
      set => characterName = value; 
    }
    public List<CharacterStats> AbilityScores { get => abilityScores; set => abilityScores = value; }

    public string Race { get => characterRace; set => characterRace = value; }
    public string Characterclass { get => characterclass; set => characterclass = value; }
  }
}
