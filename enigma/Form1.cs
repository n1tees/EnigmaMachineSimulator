using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace enigma
{
 
  public partial class Form1 : Form
  {

    Form2 settings;
    public Form1()
    {
      
      InitializeComponent();


      textBoxInPut.ScrollBars = ScrollBars.Both;
      textBoxOutPut.ScrollBars = ScrollBars.Both;
      textBoxOutPut.ReadOnly = true;


      char[] Alphabet = new char[]
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H','I','J','K', 'L', 'M', 'N','O','P','Q','R','S','T','U', 'V', 'W', 'X', 'Y', 'Z'
        };

      UpDown1.Items.AddRange(Alphabet);
      UpDown1.ReadOnly = true;
      UpDown1.Wrap = true;
      UpDown1.Text = "A";

      UpDown2.Items.AddRange(Alphabet);
      UpDown2.ReadOnly = true;
      UpDown2.Wrap = true;
      UpDown2.Text = "A";

      UpDown3.Items.AddRange(Alphabet);
      UpDown3.ReadOnly = true;
      UpDown3.Wrap = true;
      UpDown3.Text = "A";
            
    }


  private bool IsCharCorrect(char s)
      {
        List<char> Alphabet = new List<char>
        {
            'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H','I','J','K', 'L', 'M', 'N','O','P','Q','R','S','T','U', 'V', 'W', 'X', 'Y', 'Z'
        };

        foreach (var i in Alphabet)
        {
          if (i == s)
            return true;
        }
        return false;
      }
    

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      InPut input = new InPut(textBoxInPut.Text);

      Rotor r1 = new Rotor(Information.SearchList(Information.r1), input.GetValueByKey(UpDown1.Text[0]));
      Rotor r2 = new Rotor(Information.SearchList(Information.r2), input.GetValueByKey(UpDown2.Text[0]));
      Rotor r3 = new Rotor(Information.SearchList(Information.r3), input.GetValueByKey(UpDown3.Text[0]));
     

      Commutation reflector = new Commutation(Information.SearchDictForRef(Information.reflector));
      Commutation pb = new Commutation(Information.SearchDictForPB(Information.pb));



      

      for (int i = 0; i < input.GetCount(); i++)
      {

        Rotor.RotorsTurn(r1, r2, r3);

        int value = input.GetElement(i);
        int value1 = pb.Get(value);
        int value2 = Rotor.Shifr(r1, r2, r3, value1);
        int value3 = reflector.Get(value2);
        int value4 = Rotor.R_Shifr(r1, r2, r3, value3);
        int value5 = pb.Get(value4);

        input.SetElement(i, value5);

      }


      OutPut output = new OutPut(input.GetSpisok());
      textBoxOutPut.Text = output.GetString();


      UpDown1.Text = output.GetValueByKey(r1.GetCount());
      UpDown2.Text = output.GetValueByKey(r2.GetCount());
      UpDown3.Text = output.GetValueByKey(r3.GetCount());

    }

    private void buttonSettings_Click(object sender, EventArgs e)
    {
      settings = new Form2();
      settings.ShowDialog();
      
    }

    private void buttonClear_Click(object sender, EventArgs e)
    {
      textBoxInPut.Clear();
      textBoxOutPut.Clear();
    }

    private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
    {
      
    }

    private void UpDown2_SelectedItemChanged(object sender, EventArgs e)
    {

    }

    private void buttonReset_Click(object sender, EventArgs e)
    {
      UpDown1.Text = "A";
      UpDown2.Text = "A";
      UpDown3.Text = "A";
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {
            
    }

    private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
    {
      char sign = e.KeyChar;
      if(!IsCharCorrect(sign))
      {
        e.Handled = true;
      }

    }

    private void pictureBox1_Click(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click_1(object sender, EventArgs e)
    {

    }

    private void UpDown3_SelectedItemChanged(object sender, EventArgs e)
    {

    }

    private void pictureBox1_Click_2(object sender, EventArgs e)
    {

    }

    private void textBoxOutPut_TextChanged(object sender, EventArgs e)
    {

    }
  }



}
