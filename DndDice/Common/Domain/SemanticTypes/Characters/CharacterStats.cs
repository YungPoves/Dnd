﻿namespace Common.SemanticTypes
{
  public class CharacterStats
  {
    private AbilityScore strength;
    
    private int dexterity;
    private int constitution;
    private int intelligence;
    private int wisdom;
    private int charisma;

    public AbilityScore Strength 
    {
      get => strength; 
      set => strength = value;
    }

    public int Dexterity { get => dexterity; set => dexterity = value; }
    public int Constitution { get => constitution; set => constitution = value; }
    public int Intelligence { get => intelligence; set => intelligence = value; }
    public int Wisdom { get => wisdom; set => wisdom = value; }
    public int Charisma { get => charisma; set => charisma = value; }
  }
}
