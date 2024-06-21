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
      this.buttonNewWarrior = new System.Windows.Forms.Button();
      this.textBox1 = new System.Windows.Forms.TextBox();
      this.comboBoxClasses = new System.Windows.Forms.ComboBox();
      this.buttonNewMage = new System.Windows.Forms.Button();
      this.textBoxCharisma = new System.Windows.Forms.TextBox();
      this.textBoxWisdom = new System.Windows.Forms.TextBox();
      this.textBoxIntelligence = new System.Windows.Forms.TextBox();
      this.textBoxConstitution = new System.Windows.Forms.TextBox();
      this.textBoxStrength = new System.Windows.Forms.TextBox();
      this.textBoxDexterity = new System.Windows.Forms.TextBox();
      this.textBoxName = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // buttonNewWarrior
      // 
      this.buttonNewWarrior.Location = new System.Drawing.Point(12, 43);
      this.buttonNewWarrior.Name = "buttonNewWarrior";
      this.buttonNewWarrior.Size = new System.Drawing.Size(114, 48);
      this.buttonNewWarrior.TabIndex = 0;
      this.buttonNewWarrior.Text = "New Warrior";
      this.buttonNewWarrior.UseVisualStyleBackColor = true;
      this.buttonNewWarrior.Click += new System.EventHandler(this.ButtonNewWarrior_Click);
      // 
      // textBox1
      // 
      this.textBox1.Location = new System.Drawing.Point(500, 255);
      this.textBox1.Multiline = true;
      this.textBox1.Name = "textBox1";
      this.textBox1.Size = new System.Drawing.Size(288, 183);
      this.textBox1.TabIndex = 1;
      // 
      // comboBoxClasses
      // 
      this.comboBoxClasses.FormattingEnabled = true;
      this.comboBoxClasses.Items.AddRange(new object[] {
            typeof(Characters.Warrior),
            typeof(Characters.Mage),
            typeof(Characters.Assassin)});
      this.comboBoxClasses.Location = new System.Drawing.Point(667, 214);
      this.comboBoxClasses.Name = "comboBoxClasses";
      this.comboBoxClasses.Size = new System.Drawing.Size(121, 24);
      this.comboBoxClasses.TabIndex = 2;
      this.comboBoxClasses.SelectedIndexChanged += new System.EventHandler(this.ComboBoxClasses_SelectedIndexChanged);
      // 
      // buttonNewMage
      // 
      this.buttonNewMage.Location = new System.Drawing.Point(12, 97);
      this.buttonNewMage.Name = "buttonNewMage";
      this.buttonNewMage.Size = new System.Drawing.Size(114, 48);
      this.buttonNewMage.TabIndex = 3;
      this.buttonNewMage.Text = "New Mage";
      this.buttonNewMage.UseVisualStyleBackColor = true;
      this.buttonNewMage.Click += new System.EventHandler(this.ButtonNewMage_Click);
      // 
      // textBoxCharisma
      // 
      this.textBoxCharisma.Enabled = false;
      this.textBoxCharisma.Location = new System.Drawing.Point(106, 395);
      this.textBoxCharisma.Name = "textBoxCharisma";
      this.textBoxCharisma.Size = new System.Drawing.Size(29, 22);
      this.textBoxCharisma.TabIndex = 4;
      // 
      // textBoxWisdom
      // 
      this.textBoxWisdom.Enabled = false;
      this.textBoxWisdom.Location = new System.Drawing.Point(106, 367);
      this.textBoxWisdom.Name = "textBoxWisdom";
      this.textBoxWisdom.Size = new System.Drawing.Size(29, 22);
      this.textBoxWisdom.TabIndex = 5;
      // 
      // textBoxIntelligence
      // 
      this.textBoxIntelligence.Enabled = false;
      this.textBoxIntelligence.Location = new System.Drawing.Point(106, 339);
      this.textBoxIntelligence.Name = "textBoxIntelligence";
      this.textBoxIntelligence.Size = new System.Drawing.Size(29, 22);
      this.textBoxIntelligence.TabIndex = 6;
      // 
      // textBoxConstitution
      // 
      this.textBoxConstitution.Enabled = false;
      this.textBoxConstitution.Location = new System.Drawing.Point(106, 311);
      this.textBoxConstitution.Name = "textBoxConstitution";
      this.textBoxConstitution.Size = new System.Drawing.Size(29, 22);
      this.textBoxConstitution.TabIndex = 7;
      // 
      // textBoxStrength
      // 
      this.textBoxStrength.Enabled = false;
      this.textBoxStrength.Location = new System.Drawing.Point(106, 255);
      this.textBoxStrength.Name = "textBoxStrength";
      this.textBoxStrength.Size = new System.Drawing.Size(29, 22);
      this.textBoxStrength.TabIndex = 8;
      // 
      // textBoxDexterity
      // 
      this.textBoxDexterity.Enabled = false;
      this.textBoxDexterity.Location = new System.Drawing.Point(106, 283);
      this.textBoxDexterity.Name = "textBoxDexterity";
      this.textBoxDexterity.Size = new System.Drawing.Size(29, 22);
      this.textBoxDexterity.TabIndex = 9;
      // 
      // textBoxName
      // 
      this.textBoxName.Location = new System.Drawing.Point(0, 255);
      this.textBoxName.Name = "textBoxName";
      this.textBoxName.Size = new System.Drawing.Size(100, 22);
      this.textBoxName.TabIndex = 10;
      // 
      // CharacterSheet
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.textBoxName);
      this.Controls.Add(this.textBoxDexterity);
      this.Controls.Add(this.textBoxStrength);
      this.Controls.Add(this.textBoxConstitution);
      this.Controls.Add(this.textBoxIntelligence);
      this.Controls.Add(this.textBoxWisdom);
      this.Controls.Add(this.textBoxCharisma);
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
    private System.Windows.Forms.TextBox textBoxCharisma;
    private System.Windows.Forms.TextBox textBoxWisdom;
    private System.Windows.Forms.TextBox textBoxIntelligence;
    private System.Windows.Forms.TextBox textBoxConstitution;
    private System.Windows.Forms.TextBox textBoxStrength;
    private System.Windows.Forms.TextBox textBoxDexterity;
    private System.Windows.Forms.TextBox textBoxName;
  }
}