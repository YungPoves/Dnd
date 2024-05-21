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
      this.buttonD6 = new System.Windows.Forms.Button();
      this.textBoxD4 = new System.Windows.Forms.TextBox();
      this.buttonD4 = new System.Windows.Forms.Button();
      this.textBoxD6 = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // buttonD6
      // 
      this.buttonD6.Location = new System.Drawing.Point(254, 12);
      this.buttonD6.Name = "buttonD6";
      this.buttonD6.Size = new System.Drawing.Size(213, 78);
      this.buttonD6.TabIndex = 0;
      this.buttonD6.Text = "D6";
      this.buttonD6.UseVisualStyleBackColor = true;
      this.buttonD6.Click += new System.EventHandler(this.ButtonD6_Click);
      // 
      // textBoxD4
      // 
      this.textBoxD4.Enabled = false;
      this.textBoxD4.Location = new System.Drawing.Point(12, 98);
      this.textBoxD4.Name = "textBoxD4";
      this.textBoxD4.Size = new System.Drawing.Size(213, 22);
      this.textBoxD4.TabIndex = 2;
      // 
      // buttonD4
      // 
      this.buttonD4.Location = new System.Drawing.Point(12, 12);
      this.buttonD4.Name = "buttonD4";
      this.buttonD4.Size = new System.Drawing.Size(213, 78);
      this.buttonD4.TabIndex = 3;
      this.buttonD4.Text = "D4";
      this.buttonD4.UseVisualStyleBackColor = true;
      this.buttonD4.Click += new System.EventHandler(this.ButtonD4_Click);
      // 
      // textBoxD6
      // 
      this.textBoxD6.Location = new System.Drawing.Point(254, 98);
      this.textBoxD6.Name = "textBoxD6";
      this.textBoxD6.Size = new System.Drawing.Size(213, 22);
      this.textBoxD6.TabIndex = 4;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkViolet;
      this.ClientSize = new System.Drawing.Size(779, 422);
      this.Controls.Add(this.textBoxD6);
      this.Controls.Add(this.buttonD4);
      this.Controls.Add(this.textBoxD4);
      this.Controls.Add(this.buttonD6);
      this.Name = "Form1";
      this.Text = " ";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button buttonD6;
    private System.Windows.Forms.TextBox textBoxD4;
    private System.Windows.Forms.Button buttonD4;
    private System.Windows.Forms.TextBox textBoxD6;
  }
}

