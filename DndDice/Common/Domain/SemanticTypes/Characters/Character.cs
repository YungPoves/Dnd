namespace Common.SemanticTypes
{
  public class Character
  {
    public Character(string characterName)
    {
      this.Name = new CharacterName(characterName);
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
      this.Hitpoints = hitpoints;
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

    private string characterRace;
    private string characterclass;

    public CharacterName Name
    {
      get => characterName;
      set => characterName = value; 
    }

    public AbilityScore Strength { get => strength; set => strength = value; }
    public AbilityScore Dexterity { get => dexterity; set => dexterity = value; }
    public AbilityScore Constitution { get => constitution; set => constitution = value; }
    public AbilityScore Intelligence { get => intelligence; set => intelligence = value; }
    public AbilityScore Wisdom { get => wisdom; set => wisdom = value; }
    public AbilityScore Charisma { get => charisma; set => charisma = value; }
    
    public CharacterHitpoints Hitpoints { get => hitpoints; set => hitpoints = value; }

    public ArmorClass ArmorClass { get => armorClass; set => armorClass = value; }

    public CharacterProficiency Proficiency { get => proficiency; set => proficiency = value; }

    public string Race { get => characterRace; set => characterRace = value; }
    public string Characterclass { get => characterclass; set => characterclass = value; }
  }
}
