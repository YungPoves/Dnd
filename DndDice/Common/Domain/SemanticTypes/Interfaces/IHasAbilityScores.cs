using Common.SemanticTypes;

namespace Common.Domain.SemanticTypes.Interfaces
{
  public interface IHasAbilityScores
  {
    AbilityScore Strength { get; set; }
    AbilityScore Dexterity { get; set; }
    AbilityScore Constitution { get; set; }
    AbilityScore Intelligence { get; set; }
    AbilityScore Wisdom { get; set; }
    AbilityScore Charisma { get; set; }
  }
}
