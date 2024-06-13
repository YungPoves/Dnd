using Characters;
using DiceGui.ViewModels;
using DndCharacters.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
      warrior = viewModel.GetWarrior();
      this.textBox1.Text = "";
      this.textBox1.AppendText(warrior.ToString());
    }

    private Character character;
    private Warrior warrior;
    private readonly ViewModel viewModel;
  }
}
