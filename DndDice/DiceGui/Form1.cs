using System;
using System.Windows.Forms;
using Die;

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

    private void ButtonD4_Click(object sender, EventArgs e)
    {
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
  }
}
