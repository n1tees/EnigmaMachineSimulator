using System;
using System.Collections.Generic;
using System.Text;

namespace enigma
{
  class Commutation
  {
    private Dictionary<int, int> Pair = new Dictionary<int, int>();


    public Commutation(Dictionary<int, int> pair)
    {
      Pair = pair;
    }

    public int Get(int k)
    {
      int value = -1;
      foreach (var item in Pair)
      {
        if (item.Key == k)
          value = item.Value;

        if (item.Value == k)
          value = item.Key;

      }
      return value;

    }
        
  }

}
