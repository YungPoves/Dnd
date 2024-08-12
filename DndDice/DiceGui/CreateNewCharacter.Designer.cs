namespace DiceGui
{
  partial class CreateNewCharacter
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
      this.components = new System.ComponentModel.Container();
      this.textBoxEnterName = new System.Windows.Forms.TextBox();
      this.comboBoxChooseClass = new System.Windows.Forms.ComboBox();
      this.characterClassRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.characterClassRepositoryBindingSource)).BeginInit();
      this.SuspendLayout();
      // 
      // textBoxEnterName
      // 
      this.textBoxEnterName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.textBoxEnterName.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.textBoxEnterName.Location = new System.Drawing.Point(34, 29);
      this.textBoxEnterName.Name = "textBoxEnterName";
      this.textBoxEnterName.Size = new System.Drawing.Size(226, 22);
      this.textBoxEnterName.TabIndex = 1;
      this.textBoxEnterName.Text = "Enter Name...";
      // 
      // comboBoxChooseClass
      // 
      this.comboBoxChooseClass.DataSource = this.characterClassRepositoryBindingSource;
      this.comboBoxChooseClass.FormattingEnabled = true;
      this.comboBoxChooseClass.Location = new System.Drawing.Point(34, 72);
      this.comboBoxChooseClass.Name = "comboBoxChooseClass";
      this.comboBoxChooseClass.Size = new System.Drawing.Size(121, 24);
      this.comboBoxChooseClass.TabIndex = 2;
      this.comboBoxChooseClass.SelectedIndexChanged += new System.EventHandler(this.comboBoxChooseClass_SelectedIndexChanged);
      // 
      // characterClassRepositoryBindingSource
      // 
      this.characterClassRepositoryBindingSource.DataSource = typeof(DndCharacters.Enumerations.CharacterClassRepository);
      // 
      // CreateNewCharacter
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ActiveCaption;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.comboBoxChooseClass);
      this.Controls.Add(this.textBoxEnterName);
      this.Name = "CreateNewCharacter";
      this.Text = "Create New Character";
      ((System.ComponentModel.ISupportInitialize)(this.characterClassRepositoryBindingSource)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxEnterName;
    private System.Windows.Forms.ComboBox comboBoxChooseClass;
    private System.Windows.Forms.BindingSource characterClassRepositoryBindingSource;
  }
}