using DndCharacters.Enumerations;

namespace DiceGui
{
  partial class CharacterSheet
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CharacterSheet));
      this.buttonNewWarrior = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.comboBoxClasses = new System.Windows.Forms.ComboBox();
      this.buttonNewMage = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // buttonNewWarrior
      // 
      this.buttonNewWarrior.Location = new System.Drawing.Point(12, 12);
      this.buttonNewWarrior.Name = "buttonNewWarrior";
      this.buttonNewWarrior.Size = new System.Drawing.Size(114, 48);
      this.buttonNewWarrior.TabIndex = 0;
      this.buttonNewWarrior.Text = "New Warrior";
      this.buttonNewWarrior.UseVisualStyleBackColor = true;
      this.buttonNewWarrior.Click += new System.EventHandler(this.ButtonNewWarrior_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(193, 110);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(288, 183);
      this.textBox1.TabIndex = 1;
      // 
      // comboBoxClasses
      // 
      //this.comboBoxClasses.DataSource = ((object)(resources.GetObject("comboBoxClasses.DataSource")));
      this.comboBoxClasses.FormattingEnabled = true;
      this.comboBoxClasses.Items.AddRange(new object[] {
            typeof(Characters.Warrior),
            typeof(Characters.Mage),
            typeof(Characters.Assassin)});
      this.comboBoxClasses.Location = new System.Drawing.Point(487, 110);
      this.comboBoxClasses.Name = "comboBoxClasses";
      this.comboBoxClasses.Size = new System.Drawing.Size(121, 24);
      this.comboBoxClasses.TabIndex = 2;
      this.comboBoxClasses.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClasses_SelectedIndexChanged);
      // 
      // buttonNewMage
      // 
      this.buttonNewMage.Location = new System.Drawing.Point(12, 66);
      this.buttonNewMage.Name = "buttonNewMage";
      this.buttonNewMage.Size = new System.Drawing.Size(114, 48);
      this.buttonNewMage.TabIndex = 3;
      this.buttonNewMage.Text = "New Mage";
      this.buttonNewMage.UseVisualStyleBackColor = true;
      this.buttonNewMage.Click += new System.EventHandler(this.ButtonNewMage_Click);
      // 
      // CharacterSheet
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.buttonNewMage);
      this.Controls.Add(this.comboBoxClasses);
      this.Controls.Add(this.textBox1);
      this.Controls.Add(this.buttonNewWarrior);
      this.Name = "CharacterSheet";
      this.Text = "CharacterSheet";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonNewWarrior;
    private System.Windows.Forms.TextBox textBox1;
    private System.Windows.Forms.ComboBox comboBoxClasses;
    private System.Windows.Forms.Button buttonNewMage;
  }
}