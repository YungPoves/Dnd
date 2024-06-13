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
      this.SuspendLayout();
      // 
      // buttonNewWarrior
      // 
      this.buttonNewWarrior.Location = new System.Drawing.Point(264, 38);
      this.buttonNewWarrior.Name = "buttonNewWarrior";
      this.buttonNewWarrior.Size = new System.Drawing.Size(145, 66);
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
      // CharacterSheet
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
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
  }
}