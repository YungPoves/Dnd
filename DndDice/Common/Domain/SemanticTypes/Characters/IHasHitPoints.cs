using Common.SemanticTypes;

namespace Common.Domain.SemanticTypes.Characters
{
  public interface IHasHitPoints
  {
    CharacterHitpoints HitPoints { get; set; }
  }
}
