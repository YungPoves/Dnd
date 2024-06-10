using Die;
using System.Drawing;

namespace DiceGui
{
  partial class Form1
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
      this.buttonD6 = new System.Windows.Forms.Button();
      this.buttonD4 = new System.Windows.Forms.Button();
      this.buttonD8 = new System.Windows.Forms.Button();
      this.buttonD10 = new System.Windows.Forms.Button();
      this.buttonD12 = new System.Windows.Forms.Button();
      this.buttonD20 = new System.Windows.Forms.Button();
      this.buttonD100 = new System.Windows.Forms.Button();
      this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
      this.menuItemFileGroup = new System.Windows.Forms.MenuItem();
      this.fileMenuItemExit = new System.Windows.Forms.MenuItem();
      this.txtMessageLog = new System.Windows.Forms.TextBox();
      this.lblTextLog = new System.Windows.Forms.Label();
      this.buttonClearTextLog = new System.Windows.Forms.Button();
      this.buttonCharacterSheet = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // buttonD6
      // 
      this.buttonD6.Location = new System.Drawing.Point(12, 71);
      this.buttonD6.Name = "buttonD6";
      this.buttonD6.Size = new System.Drawing.Size(123, 38);
      this.buttonD6.TabIndex = 1;
      this.buttonD6.Text = "D6";
      this.buttonD6.UseVisualStyleBackColor = true;
      this.buttonD6.Click += new System.EventHandler(this.ButtonD6_Click);
      // 
      // buttonD4
      // 
      this.buttonD4.Location = new System.Drawing.Point(12, 27);
      this.buttonD4.Name = "buttonD4";
      this.buttonD4.Size = new System.Drawing.Size(123, 38);
      this.buttonD4.TabIndex = 0;
      this.buttonD4.Text = "D4";
      this.buttonD4.UseVisualStyleBackColor = true;
      this.buttonD4.Click += new System.EventHandler(this.ButtonD4_Click);
      // 
      // buttonD8
      // 
      this.buttonD8.Location = new System.Drawing.Point(12, 116);
      this.buttonD8.Name = "buttonD8";
      this.buttonD8.Size = new System.Drawing.Size(123, 38);
      this.buttonD8.TabIndex = 2;
      this.buttonD8.Text = "D8";
      this.buttonD8.UseVisualStyleBackColor = true;
      this.buttonD8.Click += new System.EventHandler(this.ButtonD8_Click);
      // 
      // buttonD10
      // 
      this.buttonD10.Location = new System.Drawing.Point(12, 160);
      this.buttonD10.Name = "buttonD10";
      this.buttonD10.Size = new System.Drawing.Size(123, 38);
      this.buttonD10.TabIndex = 9;
      this.buttonD10.Text = "D10";
      this.buttonD10.UseVisualStyleBackColor = true;
      this.buttonD10.Click += new System.EventHandler(this.ButtonD10_Click);
      // 
      // buttonD12
      // 
      this.buttonD12.Location = new System.Drawing.Point(12, 204);
      this.buttonD12.Name = "buttonD12";
      this.buttonD12.Size = new System.Drawing.Size(123, 38);
      this.buttonD12.TabIndex = 11;
      this.buttonD12.Text = "D12";
      this.buttonD12.UseVisualStyleBackColor = true;
      this.buttonD12.Click += new System.EventHandler(this.ButtonD12_Click);
      // 
      // buttonD20
      // 
      this.buttonD20.Location = new System.Drawing.Point(12, 248);
      this.buttonD20.Name = "buttonD20";
      this.buttonD20.Size = new System.Drawing.Size(123, 38);
      this.buttonD20.TabIndex = 12;
      this.buttonD20.Text = "D20";
      this.buttonD20.UseVisualStyleBackColor = true;
      this.buttonD20.Click += new System.EventHandler(this.ButtonD20_Click);
      // 
      // buttonD100
      // 
      this.buttonD100.Location = new System.Drawing.Point(12, 292);
      this.buttonD100.Name = "buttonD100";
      this.buttonD100.Size = new System.Drawing.Size(123, 38);
      this.buttonD100.TabIndex = 10;
      this.buttonD100.Text = "D100";
      this.buttonD100.UseVisualStyleBackColor = true;
      this.buttonD100.Click += new System.EventHandler(this.ButtonD100_Click);
      // 
      // mainMenu
      // 
      this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItemFileGroup});
      // 
      // menuItemFileGroup
      // 
      this.menuItemFileGroup.Index = 0;
      this.menuItemFileGroup.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItemExit});
      this.menuItemFileGroup.Text = "File";
      // 
      // fileMenuItemExit
      // 
      this.fileMenuItemExit.Index = 0;
      this.fileMenuItemExit.Text = "Exit";
      this.fileMenuItemExit.Click += new System.EventHandler(this.FileMenuItemExit_Click);
      // 
      // txtMessageLog
      // 
      this.txtMessageLog.Enabled = false;
      this.txtMessageLog.Location = new System.Drawing.Point(170, 27);
      this.txtMessageLog.Multiline = true;
      this.txtMessageLog.Name = "txtMessageLog";
      this.txtMessageLog.Size = new System.Drawing.Size(258, 372);
      this.txtMessageLog.TabIndex = 7;
      // 
      // lblTextLog
      // 
      this.lblTextLog.AutoSize = true;
      this.lblTextLog.BackColor = System.Drawing.Color.Transparent;
      this.lblTextLog.Location = new System.Drawing.Point(167, 8);
      this.lblTextLog.Name = "lblTextLog";
      this.lblTextLog.Size = new System.Drawing.Size(62, 16);
      this.lblTextLog.TabIndex = 8;
      this.lblTextLog.Text = "Text Log:";
      // 
      // buttonClearTextLog
      // 
      this.buttonClearTextLog.Location = new System.Drawing.Point(434, 363);
      this.buttonClearTextLog.Name = "buttonClearTextLog";
      this.buttonClearTextLog.Size = new System.Drawing.Size(95, 36);
      this.buttonClearTextLog.TabIndex = 13;
      this.buttonClearTextLog.Text = "Clear";
      this.buttonClearTextLog.UseVisualStyleBackColor = true;
      this.buttonClearTextLog.Click += new System.EventHandler(this.ButtonClearTextLog_Click);
      // 
      // buttonCharacterSheet
      // 
      this.buttonCharacterSheet.Location = new System.Drawing.Point(434, 27);
      this.buttonCharacterSheet.Name = "buttonCharacterSheet";
      this.buttonCharacterSheet.Size = new System.Drawing.Size(132, 38);
      this.buttonCharacterSheet.TabIndex = 14;
      this.buttonCharacterSheet.Text = "Character Sheet";
      this.buttonCharacterSheet.UseVisualStyleBackColor = true;
      this.buttonCharacterSheet.Click += new System.EventHandler(this.ButtonCharacterSheet_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.Gray;
      this.ClientSize = new System.Drawing.Size(780, 422);
      this.Controls.Add(this.buttonCharacterSheet);
      this.Controls.Add(this.buttonClearTextLog);
      this.Controls.Add(this.buttonD20);
      this.Controls.Add(this.buttonD12);
      this.Controls.Add(this.buttonD100);
      this.Controls.Add(this.buttonD10);
      this.Controls.Add(this.lblTextLog);
      this.Controls.Add(this.txtMessageLog);
      this.Controls.Add(this.buttonD4);
      this.Controls.Add(this.buttonD6);
      this.Controls.Add(this.buttonD8);
      this.MaximizeBox = false;
      this.Menu = this.mainMenu;
      this.Name = "Form1";
      this.Text = "Dice Roller";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonD4;
    private System.Windows.Forms.Button buttonD6;
    private System.Windows.Forms.Button buttonD8;
    private System.Windows.Forms.Button buttonD10;
    private System.Windows.Forms.Button buttonD12;
    private System.Windows.Forms.Button buttonD20;
    private System.Windows.Forms.Button buttonD100;

    private System.Windows.Forms.MainMenu mainMenu;
    private System.Windows.Forms.MenuItem[] fileMenuItems;
    private System.Windows.Forms.MenuItem menuItemFileGroup;
    private System.Windows.Forms.MenuItem fileMenuItemExit;
    private System.Windows.Forms.TextBox txtMessageLog;
    private System.Windows.Forms.Label lblTextLog;
    private System.Windows.Forms.Button buttonClearTextLog;
    private System.Windows.Forms.Button buttonCharacterSheet;
  }
}

