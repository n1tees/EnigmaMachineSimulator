using System;
using System.Collections.Generic;
using System.Text;

namespace enigma
{
  class Rotor
  {

    private List<int> S = new List<int>();
    private int Count;

    public Rotor(List<int> s, int FirstSign)
    {
      S.AddRange(s);
      Count = FirstSign;
      RotorTurn(FirstSign);
    }

    public void RotorTurn()
    {
      
      int element = S[0];
      S.RemoveAt(0);
      S.Add(element);
      for (int i = 0; i < S.Count; i++)
      {
        S[i]--;
        if (S[i] < 0)
          S[i] = 25;
      }


    }
    public void RotorTurn(int n)
    {

      for (int i = 0; i < n; i++)
      {
        int element = S[0];
        S.RemoveAt(0);
        S.Add(element);
        for (int j = 0; j < S.Count; j++)
        {
          S[j]--;
          if (S[j] < 0)
            S[j] = 25;
        }

      }
    }


    private void CountUpp()
    {
      Count++;
    }
    private void CountReset()
    {
      Count = 0;
    }
    private bool CountCheck()
    {
      return (Count > 25);
    }

    public static void RotorsTurn(Rotor r1, Rotor r2, Rotor r3)
    {
      r1.RotorTurn();
      r1.CountUpp();
      if (r1.CountCheck())
      {
        r1.CountReset();
        r2.RotorTurn();
        r2.CountUpp();
        if (r2.CountCheck())
        {
          r2.CountReset();
          r3.RotorTurn();
          r3.CountUpp();
          if (r3.CountCheck())
          {
            r3.CountReset();
          }
        }
      }

    }
    public int GetCount()
    {
      return Count;
    }



    public static int Shifr(Rotor r1, Rotor r2, Rotor r3, int x)
    {
      return r3.S[r2.S[r1.S[x]]];
    }
    public static int R_Shifr(Rotor r1, Rotor r2, Rotor r3, int x)
    {
      int value = -1; ;
      for (int i = 0; i < r3.S.Count; i++)
      {
        if (r3.S[i] == x)
          value = i;
      }
      x = value;
      for (int i = 0; i < r2.S.Count; i++)
      {
        if (r2.S[i] == x)
          value = i;
      }
      x = value;
      for (int i = 0; i < r1.S.Count; i++)
      {
        if (r1.S[i] == x)
          value = i;
      }
      return value;

    }

    
  }

}

