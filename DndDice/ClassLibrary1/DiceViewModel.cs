using DiceProject.Helpers;

namespace Die
{
  public class DiceViewModel : BaseClass
  {
    public string Foo() 
    {      
      return DiceRoller.D10s.Roll().ToString();
    }
    public string D4()
    {
      return DiceRoller.D4s.Roll().ToString();
    }
    public string D6()
    {
      return DiceRoller.D6s.Roll().ToString();
    }
  }
}
