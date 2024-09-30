using Common.Domain.SemanticTypes.Interfaces;
using Common.SemanticTypes;

namespace Common.Domain.SemanticTypes.Characters
{
  public class TestCharacterClass : IHasHitPoints, IHasAbilityScores
  {
    public TestCharacterClass() 
    {
    }

    public TestCharacterClass(int hitpoints, int strength, int dexterity, int constitution, int intelligence, int wisdom, int charisma)
    {
      this.HitPoints = new CharacterHitpoints(hitpoints);
      this.Strength = new AbilityScore(strength);
      this.Dexterity = new AbilityScore(dexterity);
      this.Constitution = new AbilityScore(constitution);
      this.Intelligence = new AbilityScore(intelligence);
      this.Wisdom = new AbilityScore(wisdom);
      this.Charisma = new AbilityScore(charisma);
    }

    public CharacterHitpoints HitPoints
    {
      get => hitPoints;
      set => hitPoints = value;
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
    public AbilityScore Intelligence
    {
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

    private CharacterHitpoints hitPoints;
    private AbilityScore strength;
    private AbilityScore dexterity;
    private AbilityScore constitution;
    private AbilityScore intelligence;
    private AbilityScore wisdom;
    private AbilityScore charisma;
  }
}
