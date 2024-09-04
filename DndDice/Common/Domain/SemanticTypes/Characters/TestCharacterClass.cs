using Common.SemanticTypes;

namespace Common.Domain.SemanticTypes.Characters
{
  public class TestCharacterClass : IHasHitPoints
  {
    public TestCharacterClass() { }

    public CharacterHitpoints HitPoints 
    {
      get => hitPoints;
      set => hitPoints = value; 
    }

    public CharacterHitpoints hitPoints;
  }
}
