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
      this.Wisdon = wisdon;
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
    private AbilityScore wisdon;
    private AbilityScore charisma;

    private CharacterHitpoints hitpoints;
    
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
    public AbilityScore Wisdon { get => wisdon; set => wisdon = value; }
    public AbilityScore Charisma { get => charisma; set => charisma = value; }
    
    public CharacterHitpoints Hitpoints { get => hitpoints; set => hitpoints = value; }

    public string Race { get => characterRace; set => characterRace = value; }
    public string Characterclass { get => characterclass; set => characterclass = value; }
  }
}
