using System;
using System.Collections.Generic;
using System.Text;

namespace enigma
{
  class InPut
  {

    private int Count = 0;
    private Dictionary<char, int> Alphabet = new Dictionary<char, int>()
          {
              {'A',0},
              {'B',1},
              {'C',2},
              {'D',3},
              {'E',4},
              {'F',5},
              {'G',6},
              {'H',7},
              {'I',8},
              {'J',9},
              {'K',10},
              {'L',11},
              {'M',12},
              {'N',13},
              {'O',14},
              {'P',15},
              {'Q',16},
              {'R',17},
              {'S',18},
              {'T',19},
              {'U',20},
              {'V',21},
              {'W',22},
              {'X',23},
              {'Y',24},
              {'Z',25}
          };
    private List<int> Spisok = new List<int>();


    public InPut(string s)
    {
      for (int i = 0; i < s.Length; i++)
      {
        Count++;
        Spisok.Add(GetValueByKey(s[i]));
      }


    }


    public int GetValueByKey(char i)
    {
      return Alphabet[i];
    }
    public List<int> GetSpisok()
    {
      return Spisok;
    }
    public int GetElement(int i)
    {
      return Spisok[i];
    }
    public void SetElement(int i, int value)
    {
      Spisok[i] = value;
    }
    public int GetCount()
    {
      return Count;
    }

  }



  class OutPut
  {
    private Dictionary<int, char> Alphabet = new Dictionary<int, char>()
        {
            {0,'A'},
            {1,'B'},
            {2,'C'},
            {3,'D'},
            {4,'E'},
            {5,'F'},
            {6,'G'},
            {7,'H'},
            {8,'I'},
            {9,'J'},
            {10,'K'},
            {11,'L'},
            {12,'M'},
            {13,'N'},
            {14,'O'},
            {15,'P'},
            {16,'Q'},
            {17,'R'},
            {18,'S'},
            {19,'T'},
            {20,'U'},
            {21,'V'},
            {22,'W'},
            {23,'X'},
            {24,'Y'},
            {25,'Z'}
        };
    private string S;


    public OutPut(List<int> Spisok)
    {

      for (int i = 0; i < Spisok.Count; i++)
      {
        S += GetValueByKey(Spisok[i]);
      }

    }


    public string GetValueByKey(int i)
    {
      return Alphabet[i].ToString();
    }
    public string GetString()
    {
      return S;
    }



  }

}
