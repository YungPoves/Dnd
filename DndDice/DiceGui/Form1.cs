using System;
using System.Windows.Forms;
using DiceGui.ViewModels;
using Die;
using DndCharacters;

namespace DiceGui
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    public Form1(DiceViewModel viewModel)
    {
      InitializeComponent();
      this.diceViewModel = viewModel;
    }

    public Form1(DiceViewModel diceViewModel, CharacterViewModel characterViewModel)
    {
      InitializeComponent();
      this.diceViewModel = diceViewModel;
      this.characterViewModel = characterViewModel;
      this.viewModel = new ViewModel();
    }

    public Form1(ViewModel viewModel, CharacterViewModel characterViewModel)
    {
      InitializeComponent();
      this.viewModel = viewModel;
      this.characterViewModel = characterViewModel;
    }

    private void ButtonD4_Click(object sender, EventArgs e)
    {
      //txtMessageLog.AppendText($"{characterViewModel.Test()}");
      txtMessageLog.AppendText($"{diceViewModel.D4()}{Environment.NewLine}");
    }
    private void ButtonD6_Click(object sender, EventArgs e)
    {
      txtMessageLog.AppendText($"{diceViewModel.D6()}{Environment.NewLine}");
    }
    private void ButtonD8_Click(object sender, EventArgs e)
    {
      txtMessageLog.AppendText($"{diceViewModel.D8()}{Environment.NewLine}");
    }
    private void ButtonD10_Click(object sender, EventArgs e)
    {
      txtMessageLog.AppendText($"{diceViewModel.D10()}{Environment.NewLine}");
    }
    private void ButtonD12_Click(object sender, EventArgs e)
    {
      txtMessageLog.AppendText($"{diceViewModel.D12()}{Environment.NewLine}");
    }
    private void ButtonD20_Click(object sender, EventArgs e)
    {
      txtMessageLog.AppendText($"{diceViewModel.D20()}{Environment.NewLine}");
    }
    private void ButtonD100_Click(object sender, EventArgs e)
    {
      txtMessageLog.AppendText($"{diceViewModel.D100()}{Environment.NewLine}");
    }

    private void ButtonClearTextLog_Click(object sender, EventArgs e)
    {
      txtMessageLog.Clear();
    }

    private void FileMenuItemExit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private void ButtonCharacterSheet_Click(object sender, EventArgs e)
    {
      //Form2 form2 = new Form2();
      //form2.Show();

      CharacterSheet characterSheet = new CharacterSheet(viewModel);
      characterSheet.Show();
    }

    private readonly ViewModel viewModel;
    private readonly DiceViewModel diceViewModel;
    private readonly CharacterViewModel characterViewModel;
  }
}
