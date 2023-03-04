
namespace enigma
{
  partial class Form2
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
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.comboBoxThirdRotor = new System.Windows.Forms.ComboBox();
      this.label3 = new System.Windows.Forms.Label();
      this.comboBoxReflector = new System.Windows.Forms.ComboBox();
      this.comboBoxSecondRotor = new System.Windows.Forms.ComboBox();
      this.label4 = new System.Windows.Forms.Label();
      this.comboBoxFirstRotor = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.button2 = new System.Windows.Forms.Button();
      this.comboBoxPlugBoard = new System.Windows.Forms.ComboBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(16, 87);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(205, 25);
      this.label1.TabIndex = 0;
      this.label1.Text = "Version the Thitd Rotor";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(16, 190);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(220, 25);
      this.label2.TabIndex = 1;
      this.label2.Text = "Commutation PlugBoard";
      // 
      // comboBoxThirdRotor
      // 
      this.comboBoxThirdRotor.FormattingEnabled = true;
      this.comboBoxThirdRotor.Items.AddRange(new object[] {
            "Rotor_I",
            "Rotor_II",
            "Rotor_III",
            "Rotor_IV",
            "Rotor_V",
            "Rotor_VI",
            "Rotor_VII",
            "Rotor_VIII",
            "Beta_Rotor",
            "Gamma_Rotor"});
      this.comboBoxThirdRotor.Location = new System.Drawing.Point(318, 87);
      this.comboBoxThirdRotor.Name = "comboBoxThirdRotor";
      this.comboBoxThirdRotor.Size = new System.Drawing.Size(121, 23);
      this.comboBoxThirdRotor.TabIndex = 4;
      this.comboBoxThirdRotor.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label3.Location = new System.Drawing.Point(16, 162);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(154, 25);
      this.label3.TabIndex = 5;
      this.label3.Text = "Version Reflector";
      // 
      // comboBoxReflector
      // 
      this.comboBoxReflector.FormattingEnabled = true;
      this.comboBoxReflector.Items.AddRange(new object[] {
            "Reflector_B",
            "Reflector_C",
            "Reflector_B_Dünn",
            "Reflector_C_Dünn"});
      this.comboBoxReflector.Location = new System.Drawing.Point(318, 162);
      this.comboBoxReflector.Name = "comboBoxReflector";
      this.comboBoxReflector.Size = new System.Drawing.Size(121, 23);
      this.comboBoxReflector.TabIndex = 6;
      // 
      // comboBoxSecondRotor
      // 
      this.comboBoxSecondRotor.FormattingEnabled = true;
      this.comboBoxSecondRotor.Items.AddRange(new object[] {
            "Rotor_I",
            "Rotor_II",
            "Rotor_III",
            "Rotor_IV",
            "Rotor_V",
            "Rotor_VI",
            "Rotor_VII",
            "Rotor_VIII",
            "Beta_Rotor",
            "Gamma_Rotor"});
      this.comboBoxSecondRotor.Location = new System.Drawing.Point(318, 58);
      this.comboBoxSecondRotor.Name = "comboBoxSecondRotor";
      this.comboBoxSecondRotor.Size = new System.Drawing.Size(121, 23);
      this.comboBoxSecondRotor.TabIndex = 8;
      this.comboBoxSecondRotor.SelectedIndexChanged += new System.EventHandler(this.comboBoxSecondRotor_SelectedIndexChanged);
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label4.Location = new System.Drawing.Point(16, 58);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(224, 25);
      this.label4.TabIndex = 7;
      this.label4.Text = "Version the Second Rotor";
      this.label4.Click += new System.EventHandler(this.label4_Click);
      // 
      // comboBoxFirstRotor
      // 
      this.comboBoxFirstRotor.FormattingEnabled = true;
      this.comboBoxFirstRotor.Items.AddRange(new object[] {
            "Rotor_I",
            "Rotor_II",
            "Rotor_III",
            "Rotor_IV",
            "Rotor_V",
            "Rotor_VI",
            "Rotor_VII",
            "Rotor_VIII",
            "Beta_Rotor",
            "Gamma_Rotor"});
      this.comboBoxFirstRotor.Location = new System.Drawing.Point(318, 29);
      this.comboBoxFirstRotor.Name = "comboBoxFirstRotor";
      this.comboBoxFirstRotor.Size = new System.Drawing.Size(121, 23);
      this.comboBoxFirstRotor.TabIndex = 10;
      this.comboBoxFirstRotor.SelectedIndexChanged += new System.EventHandler(this.comboBox5_SelectedIndexChanged);
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label5.Location = new System.Drawing.Point(16, 29);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(197, 25);
      this.label5.TabIndex = 9;
      this.label5.Text = "Version the First Rotor";
      this.label5.Click += new System.EventHandler(this.label5_Click);
      // 
      // button2
      // 
      this.button2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.button2.Location = new System.Drawing.Point(16, 278);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(427, 33);
      this.button2.TabIndex = 12;
      this.button2.Text = "Save ";
      this.button2.UseVisualStyleBackColor = true;
      this.button2.Click += new System.EventHandler(this.button2_Click);
      // 
      // comboBoxPlugBoard
      // 
      this.comboBoxPlugBoard.FormattingEnabled = true;
      this.comboBoxPlugBoard.Items.AddRange(new object[] {
            "PB_A",
            "PB_B",
            "PB_C"});
      this.comboBoxPlugBoard.Location = new System.Drawing.Point(318, 192);
      this.comboBoxPlugBoard.Name = "comboBoxPlugBoard";
      this.comboBoxPlugBoard.Size = new System.Drawing.Size(121, 23);
      this.comboBoxPlugBoard.TabIndex = 13;
      this.comboBoxPlugBoard.SelectedIndexChanged += new System.EventHandler(this.comboBoxPlugBoard_SelectedIndexChanged);
      // 
      // Form2
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonShadow;
      this.ClientSize = new System.Drawing.Size(452, 325);
      this.Controls.Add(this.comboBoxPlugBoard);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.comboBoxFirstRotor);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.comboBoxSecondRotor);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.comboBoxReflector);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.comboBoxThirdRotor);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "Form2";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Settings";
      this.Load += new System.EventHandler(this.Form2_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.ComboBox comboBoxThirdRotor;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.ComboBox comboBoxReflector;
    private System.Windows.Forms.ComboBox comboBoxSecondRotor;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox comboBoxFirstRotor;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.ComboBox comboBoxPlugBoard;
  }
}