using Characters;
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
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      Warrior Harald = new Warrior("Harald", 10);
      this.label1.Text = Harald.Name;
    }
  }
}
