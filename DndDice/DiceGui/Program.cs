using DiceGui.ViewModels;
using Die;
using DndCharacters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiceGui
{
  internal static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);

      ViewModel viewModel = new ViewModel();
      DiceViewModel diceViewModel = new DiceViewModel();
      CharacterViewModel characterViewModel = new CharacterViewModel();
      //Form1 form = new Form1(viewModel, characterViewModel);
      Form1 form = new Form1(diceViewModel, characterViewModel);

      Application.Run(form);
    }
  }
}
