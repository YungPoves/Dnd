using Common.Domain.SemanticTypes.Interfaces;
using Common.SemanticTypes;

namespace Common.Domain.SemanticTypes.Characters
{
  public class TestCharacterClass : IHasHitPoints, IHasAbilityScores
  {
    public TestCharacterClass() 
    {
    }

    public TestCharacterClass(int strength, int dexterity)
    {
      this.Strength = new AbilityScore(strength);
      this.Dexterity = new AbilityScore(dexterity);
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
