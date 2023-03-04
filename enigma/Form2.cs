using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace enigma
{
  public partial class Form2 : Form
  {
    public Form2()
    {
      InitializeComponent();

      comboBoxFirstRotor.Text  = Information.r1;
      comboBoxSecondRotor.Text = Information.r2;
      comboBoxThirdRotor.Text  = Information.r3;
      comboBoxReflector.Text = Information.reflector;
      comboBoxPlugBoard.Text = Information.pb;
    }

   

    private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void Form2_Load(object sender, EventArgs e)
    {
      
    }

    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {


      Information.r1 = comboBoxFirstRotor.Text  ;
      Information.r2 = comboBoxSecondRotor.Text ;
      Information.r3 = comboBoxThirdRotor.Text  ;

      Information.reflector = comboBoxReflector.Text ;
      Information.pb = comboBoxPlugBoard.Text;

      this.Close();

    }

    private void comboBoxSecondRotor_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void comboBoxPlugBoard_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
  }
}
