using Characters;
using DiceGui.ViewModels;
using DndCharacters.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGui
{
  public partial class CharacterSheet : Form
  {
    public CharacterSheet()
    {
      InitializeComponent();
    }

    public CharacterSheet(ViewModel viewModel)
    {
      InitializeComponent();
      this.viewModel = viewModel;
    }

    private void ButtonNewWarrior_Click(object sender, EventArgs e)
    {
      character = viewModel.CreateWarrior();
      this.textBox1.AppendText(character.ToString());
    }
    private void ButtonNewMage_Click(object sender, EventArgs e)
    {
      character = viewModel.CreateMage();
      this.textBox1.AppendText(character.ToString());
    }
    private void ComboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
    {
      type = this.comboBoxClasses.SelectedItem;
    }

    private Type classType;
    private object type;

    private Character character;
    private Warrior warrior;
    private readonly ViewModel viewModel;
  }
}
