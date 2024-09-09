using Common.SemanticTypes;

namespace Common.Domain.SemanticTypes.Interfaces
{
    public interface IHasHitPoints
    {
        CharacterHitpoints HitPoints { get; set; }
    }
}
