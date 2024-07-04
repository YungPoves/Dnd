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
      this.textBox1.Clear();
      character = viewModel.CreateWarrior();
      this.textBox1.AppendText(character.ToString());
      this.richTextBox1.AppendText(character.ToString());
      this.textBoxName.Text = character.Name;
    }
    private void ButtonNewMage_Click(object sender, EventArgs e)
    {
      this.textBox1.Clear();
      character = viewModel.CreateMage();
      this.textBox1.AppendText(character.ToString());
      this.textBoxName.Text = character.Name;
    }
    private void ComboBoxClasses_SelectedIndexChanged(object sender, EventArgs e)
    {
      //type = this.comboBoxClasses.SelectedItem;
    }
    private void ButtonLoadCharacter_Click(object sender, EventArgs e)
    {
      character = viewModel.LoadCharacter("Harald Stenhard");
    }

    private Character character;
    private readonly ViewModel viewModel;
  }
}
