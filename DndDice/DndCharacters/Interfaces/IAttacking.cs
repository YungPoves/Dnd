namespace MagicDestroyers.Interfaces
{
  public interface IAttacking
  {
    int Attack();
    int SpecialAttack();

    int AttackDamage { get; set; }
  }
}
