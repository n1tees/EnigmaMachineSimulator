using System;
using System.Collections.Generic;
using System.Text;

namespace enigma
{
  /// <summary>Рефлектор или коммутационная панель: подстановка пар символов.</summary>
  class Commutation
  {
    private Dictionary<int, int> Pair = new Dictionary<int, int>();

    public Commutation(Dictionary<int, int> pair)
    {
      Pair = pair;
    }

    public int Get(int k)
    {
      foreach (var item in Pair)
      {
        if (item.Key == k) return item.Value;
        if (item.Value == k) return item.Key;
      }
      return k; // не в паре — без замены
    }
  }
}
