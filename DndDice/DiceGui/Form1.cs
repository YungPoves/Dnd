using System;
using System.Windows.Forms;
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
      this.viewModel = viewModel;
    }

    public Form1(DiceViewModel diceViewModel, CharacterViewModel characterViewModel)
    {
      InitializeComponent();
      this.viewModel = diceViewModel;
      this.characterViewModel = characterViewModel;
    }

    private void ButtonD4_Click(object sender, EventArgs e)
    {
      txtMessageLog.AppendText($"{characterViewModel.Test()}");
      txtMessageLog.AppendText($"{viewModel.D4()}{Environment.NewLine}");
    }
    private void ButtonD6_Click(object sender, EventArgs e)
    {
      txtMessageLog.AppendText($"{viewModel.D6()}{Environment.NewLine}");
    }
    private void ButtonD8_Click(object sender, EventArgs e)
    {
      txtMessageLog.AppendText($"{viewModel.D8()}{Environment.NewLine}");
    }
    private void ButtonD10_Click(object sender, EventArgs e)
    {
      txtMessageLog.AppendText($"{viewModel.D10()}{Environment.NewLine}");
    }
    private void ButtonD12_Click(object sender, EventArgs e)
    {
      txtMessageLog.AppendText($"{viewModel.D12()}{Environment.NewLine}");
    }
    private void ButtonD20_Click(object sender, EventArgs e)
    {
      txtMessageLog.AppendText($"{viewModel.D20()}{Environment.NewLine}");
    }
    private void ButtonD100_Click(object sender, EventArgs e)
    {
      txtMessageLog.AppendText($"{viewModel.D100()}{Environment.NewLine}");
    }

    private void ButtonClearTextLog_Click(object sender, EventArgs e)
    {
      txtMessageLog.Clear();
    }

    private void FileMenuItemExit_Click(object sender, EventArgs e)
    {
      Close();
    }

    private readonly DiceViewModel viewModel;
    private readonly CharacterViewModel characterViewModel;
  }
}
