using Common.SemanticTypes;

namespace Common.Domain.SemanticTypes.Interfaces
{
  public interface IHasArmorClass
  {
    ArmorClass CharacterArmorClass { get; set; }
  }
}
