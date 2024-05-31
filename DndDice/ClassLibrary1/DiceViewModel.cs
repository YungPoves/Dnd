using DiceProject.Helpers;

namespace Die
{
  public class DiceViewModel : BaseClass
  {
    public string D4()
    {
      return DiceRoller.D4s.Roll().ToString();
    }
    public string D6()
    {
      return DiceRoller.D6s.Roll().ToString();
    }
    public string D8()
    {
      return DiceRoller.D8s.Roll().ToString();
    }
    public string D10()
    {
      return DiceRoller.D10s.Roll().ToString();
    }
    public string D12()
    {
      return DiceRoller.D12s.Roll().ToString();
    }
    public string D20()
    {
      return DiceRoller.D20s.Roll().ToString();
    }
    public string D100()
    {
      return DiceRoller.D100s.Roll().ToString();
    }
  }
}
