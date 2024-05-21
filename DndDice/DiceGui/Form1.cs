using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiceProject.Die;
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
      textBoxD4.Text = viewModel.D4();
    }

    private void ButtonD6_Click(object sender, EventArgs e)
    {
      textBoxD6.Text = viewModel.D6();
    }

    private readonly DiceViewModel viewModel;
  }
}
