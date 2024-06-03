namespace MagicDestroyers.Equipment.Armors
{
  public abstract class Armor
  {
    public Armor()
    {
    }

    public int ArmorPoints
    {
      get => armorPoints;
      set
      {
        armorPoints = value;
      }
    }

    private int armorPoints;
  }
}
