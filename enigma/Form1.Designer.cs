
namespace enigma
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.UpDown1 = new System.Windows.Forms.DomainUpDown();
      this.textBoxInPut = new System.Windows.Forms.TextBox();
      this.textBoxOutPut = new System.Windows.Forms.TextBox();
      this.buttonBegin = new System.Windows.Forms.Button();
      this.buttonClear = new System.Windows.Forms.Button();
      this.buttonReset = new System.Windows.Forms.Button();
      this.buttonSettings = new System.Windows.Forms.Button();
      this.UpDown2 = new System.Windows.Forms.DomainUpDown();
      this.UpDown3 = new System.Windows.Forms.DomainUpDown();
      this.label1 = new System.Windows.Forms.Label();
      this.pictureBox1 = new System.Windows.Forms.PictureBox();
      this.label2 = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
      this.SuspendLayout();
      // 
      // UpDown1
      // 
      this.UpDown1.AllowDrop = true;
      this.UpDown1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.UpDown1.Location = new System.Drawing.Point(94, 161);
      this.UpDown1.Name = "UpDown1";
      this.UpDown1.Size = new System.Drawing.Size(93, 33);
      this.UpDown1.TabIndex = 9;
      this.UpDown1.SelectedItemChanged += new System.EventHandler(this.domainUpDown1_SelectedItemChanged);
      // 
      // textBoxInPut
      // 
      this.textBoxInPut.Location = new System.Drawing.Point(14, 232);
      this.textBoxInPut.Multiline = true;
      this.textBoxInPut.Name = "textBoxInPut";
      this.textBoxInPut.Size = new System.Drawing.Size(173, 273);
      this.textBoxInPut.TabIndex = 0;
      this.textBoxInPut.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
      this.textBoxInPut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
      // 
      // textBoxOutPut
      // 
      this.textBoxOutPut.Location = new System.Drawing.Point(380, 232);
      this.textBoxOutPut.Multiline = true;
      this.textBoxOutPut.Name = "textBoxOutPut";
      this.textBoxOutPut.Size = new System.Drawing.Size(173, 273);
      this.textBoxOutPut.TabIndex = 1;
      this.textBoxOutPut.TextChanged += new System.EventHandler(this.textBoxOutPut_TextChanged);
      // 
      // buttonBegin
      // 
      this.buttonBegin.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.buttonBegin.Location = new System.Drawing.Point(236, 232);
      this.buttonBegin.Name = "buttonBegin";
      this.buttonBegin.Size = new System.Drawing.Size(93, 40);
      this.buttonBegin.TabIndex = 2;
      this.buttonBegin.Text = "Begin";
      this.buttonBegin.UseVisualStyleBackColor = true;
      this.buttonBegin.Click += new System.EventHandler(this.button1_Click);
      // 
      // buttonClear
      // 
      this.buttonClear.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.buttonClear.Location = new System.Drawing.Point(236, 306);
      this.buttonClear.Name = "buttonClear";
      this.buttonClear.Size = new System.Drawing.Size(93, 38);
      this.buttonClear.TabIndex = 3;
      this.buttonClear.Text = "Clear";
      this.buttonClear.UseVisualStyleBackColor = true;
      this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
      // 
      // buttonReset
      // 
      this.buttonReset.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.buttonReset.Location = new System.Drawing.Point(236, 386);
      this.buttonReset.Name = "buttonReset";
      this.buttonReset.Size = new System.Drawing.Size(93, 40);
      this.buttonReset.TabIndex = 4;
      this.buttonReset.Text = "Reset";
      this.buttonReset.UseVisualStyleBackColor = true;
      this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
      // 
      // buttonSettings
      // 
      this.buttonSettings.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.buttonSettings.Location = new System.Drawing.Point(236, 465);
      this.buttonSettings.Name = "buttonSettings";
      this.buttonSettings.Size = new System.Drawing.Size(93, 40);
      this.buttonSettings.TabIndex = 5;
      this.buttonSettings.Text = "Settings";
      this.buttonSettings.UseVisualStyleBackColor = true;
      this.buttonSettings.Click += new System.EventHandler(this.buttonSettings_Click);
      // 
      // UpDown2
      // 
      this.UpDown2.AllowDrop = true;
      this.UpDown2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.UpDown2.Location = new System.Drawing.Point(236, 161);
      this.UpDown2.Name = "UpDown2";
      this.UpDown2.Size = new System.Drawing.Size(93, 33);
      this.UpDown2.TabIndex = 10;
      this.UpDown2.SelectedItemChanged += new System.EventHandler(this.UpDown2_SelectedItemChanged);
      // 
      // UpDown3
      // 
      this.UpDown3.AllowDrop = true;
      this.UpDown3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.UpDown3.Location = new System.Drawing.Point(380, 161);
      this.UpDown3.Name = "UpDown3";
      this.UpDown3.Size = new System.Drawing.Size(93, 33);
      this.UpDown3.TabIndex = 11;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label1.Location = new System.Drawing.Point(-88, 426);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(0, 25);
      this.label1.TabIndex = 12;
      // 
      // pictureBox1
      // 
      this.pictureBox1.Image = global::enigma.Properties.Resources._5eb7b221042e74784c0fa1c0_Enigma_Logo_Black;
      this.pictureBox1.Location = new System.Drawing.Point(14, 12);
      this.pictureBox1.Name = "pictureBox1";
      this.pictureBox1.Size = new System.Drawing.Size(539, 117);
      this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
      this.pictureBox1.TabIndex = 14;
      this.pictureBox1.TabStop = false;
      this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
      this.label2.Location = new System.Drawing.Point(14, 127);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(0, 25);
      this.label2.TabIndex = 15;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.SystemColors.ButtonShadow;
      this.ClientSize = new System.Drawing.Size(565, 529);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.pictureBox1);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.UpDown3);
      this.Controls.Add(this.UpDown2);
      this.Controls.Add(this.UpDown1);
      this.Controls.Add(this.buttonSettings);
      this.Controls.Add(this.buttonReset);
      this.Controls.Add(this.buttonClear);
      this.Controls.Add(this.buttonBegin);
      this.Controls.Add(this.textBoxOutPut);
      this.Controls.Add(this.textBoxInPut);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.Name = "Form1";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Enigma Machine";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox textBoxInPut;
    private System.Windows.Forms.TextBox textBoxOutPut;
    private System.Windows.Forms.Button buttonBegin;
    private System.Windows.Forms.Button buttonClear;
    private System.Windows.Forms.Button buttonReset;
    private System.Windows.Forms.Button buttonSettings;
    private System.Windows.Forms.DomainUpDown UpDown1;
    private System.Windows.Forms.DomainUpDown UpDown2;
    private System.Windows.Forms.DomainUpDown UpDown3;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.PictureBox pictureBox1;
    private System.Windows.Forms.Label label2;
  }
}

