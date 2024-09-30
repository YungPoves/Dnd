using Common.Domain.SemanticTypes.Interfaces;

namespace Common.SemanticTypes
{
  public class Character : IHasAbilityScores, IHasHitPoints
  {
    public Character(string characterName)
    {
      this.Name = new CharacterName(characterName);
    }
    public Character(int strength, int dexterity, int constitution, int intelligence, int wisdon, int charisma)
    {
      this.Strength = new AbilityScore(strength);
      this.Dexterity = new AbilityScore(dexterity);
      this.Constitution = new AbilityScore(constitution);
      this.Intelligence = new AbilityScore(intelligence);
      this.Wisdom = new AbilityScore(wisdon);
      this.Charisma = new AbilityScore(charisma);
    }
    public Character(AbilityScore strength, AbilityScore dexterity, AbilityScore constitution, AbilityScore intelligence, AbilityScore wisdon, AbilityScore charisma)
    {
      this.Strength = strength;
      this.Dexterity = dexterity;
      this.Constitution = constitution;
      this.Intelligence = intelligence;
      this.Wisdom = wisdon;
      this.Charisma = charisma;
    }
    public Character(CharacterHitpoints hitpoints)
    {
      this.HitPoints = hitpoints;
    }

    private CharacterName characterName;

    private AbilityScore strength;
    private AbilityScore dexterity;
    private AbilityScore constitution;
    private AbilityScore intelligence;
    private AbilityScore wisdom;
    private AbilityScore charisma;

    private CharacterHitpoints hitpoints;

    private ArmorClass armorClass;

    private CharacterProficiency proficiency;

    private CharacterLevel level;

    private string characterRace;
    private string characterclass;

    public CharacterName Name
    {
      get => characterName;
      set => characterName = value; 
    }

    public AbilityScore Strength 
    {
      get => strength;
      set => strength = value;
    }
    public AbilityScore Dexterity
    {
      get => dexterity;
      set => dexterity = value;
    }
    public AbilityScore Constitution
    {
      get => constitution;
      set => constitution = value;
    }
    public AbilityScore Intelligence {
      get => intelligence;
      set => intelligence = value;
    }
    public AbilityScore Wisdom
    {
      get => wisdom;
      set => wisdom = value;
    }
    public AbilityScore Charisma 
    {
      get => charisma;
      set => charisma = value;
    }
    
    public ArmorClass ArmorClass 
    {
      get => armorClass;
      set => armorClass = value;
    }

    public CharacterProficiency Proficiency
    {
      get => proficiency;
      set => proficiency = value; 
    }

    public CharacterLevel Level 
    {
      get => level;
      set => level = value;
    }

    public string CharacterRace
    {
      get => characterRace;
      set => characterRace = value;
    }
    public string Characterclass
    {
      get => characterclass;
      set => characterclass = value; 
    }
    public CharacterHitpoints HitPoints
    {
      get => hitpoints;
      set => hitpoints = value; 
    }
  }
}
