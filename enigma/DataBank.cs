using System;
using System.Collections.Generic;
using System.Text;

namespace enigma
{


  static class Information
  {

    public static string r1 = "Rotor_I";
    public static string r2 = "Rotor_II";
    public static string r3 = "Rotor_III";

    public static string reflector = "Reflector_B";
    public static string pb = "PB_A";





    public static List<int> SearchList(string s)
    {

      List<int> Rotor_I = new List<int>() { 4, 10, 12, 5, 11, 6, 3, 16, 21, 25, 13, 19, 14, 22, 24, 7, 23, 20, 18, 15, 0, 8, 1, 17, 2, 9 };
      List<int> Rotor_II = new List<int>() { 0, 9, 3, 10, 18, 8, 17, 20, 23, 1, 11, 7, 22, 19, 12, 2, 16, 6, 25, 13, 15, 24, 5, 21, 14, 4 };
      List<int> Rotor_III = new List<int>() { 1, 3, 5, 7, 9, 11, 2, 15, 17, 19, 23, 21, 25, 13, 24, 4, 8, 22, 6, 0, 10, 12, 20, 18, 16, 14 };
      List<int> Rotor_IV = new List<int>() { 4, 18, 14, 21, 15, 25, 9, 0, 24, 16, 20, 8, 17, 7, 23, 11, 13, 5, 19, 6, 10, 3, 2, 12, 22, 1 };
      List<int> Rotor_V = new List<int>() { 21, 25, 1, 17, 6, 8, 19, 24, 20, 15, 18, 3, 13, 7, 11, 23, 0, 22, 12, 9, 16, 14, 5, 4, 2, 10 };
      List<int> Rotor_VI = new List<int>() { 9, 15, 6, 21, 14, 20, 12, 5, 24, 16, 1, 4, 13, 7, 25, 17, 3, 10, 0, 18, 23, 11, 8, 2, 19, 22 };
      List<int> Rotor_VII = new List<int>() { 13, 25, 9, 7, 6, 17, 2, 23, 12, 24, 18, 22, 1, 14, 20, 5, 0, 8, 21, 11, 15, 4, 10, 16, 3, 19 };
      List<int> Rotor_VIII = new List<int>() { 5, 10, 16, 7, 19, 11, 23, 14, 2, 1, 9, 18, 15, 3, 25, 17, 0, 12, 4, 22, 13, 8, 20, 24, 6, 21 };
      List<int> Beta_Rotor = new List<int>() { 11, 4, 24, 9, 21, 2, 13, 8, 23, 22, 15, 1, 16, 12, 3, 17, 19, 0, 10, 25, 6, 5, 20, 7, 14, 18 };
      List<int> Gamma_Rotor = new List<int>() { 5, 18, 14, 10, 0, 13, 20, 4, 17, 7, 12, 1, 19, 8, 24, 2, 22, 11, 16, 15, 25, 23, 21, 6, 9, 3 };

      List<int> Res = Rotor_I;


      if (s == "Rotor_II") Res = Rotor_II;
      if (s == "Rotor_III") Res = Rotor_III;
      if (s == "Rotor_IV") Res = Rotor_IV;
      if (s == "Rotor_V") Res = Rotor_IV;
      if (s == "Rotor_VI") Res = Rotor_VI;
      if (s == "Rotor_VII") Res = Rotor_VII;
      if (s == "Rotor_VIII") Res = Rotor_VIII;
      if (s == "Beta_Rotor") Res = Beta_Rotor;
      if (s == "Gamma_Rotor") Res = Gamma_Rotor;

      return Res;
    }

    public static Dictionary<int, int> SearchDictForRef(string s)
    {
      Dictionary<int, int> Reflector_B = new Dictionary<int, int>()
      {
        { 0, 24 },
        { 1, 17 },
        { 2, 20 },
        { 3, 7 },
        { 4, 16 },
        { 5, 18 },
        { 6, 11 },
        { 8, 15 },
        { 9, 23 },
        { 10, 13 },
        { 12, 14 },
        { 19, 25 },
        { 21, 22 }

      };
      Dictionary<int, int> Reflector_C = new Dictionary<int, int>()
      {
        { 0, 5 },
        { 1, 21 },
        { 2, 15 },
        { 3, 9 },
        { 4, 8 },
        { 6, 14 },
        { 7, 24 },
        { 10, 17 },
        { 11, 25 },
        { 13, 22 },
        { 19, 16 },
        { 18, 20 }
      };
      Dictionary<int, int> Reflector_B_Dünn = new Dictionary<int, int>()
      {
        { 0, 4 },
        { 1, 13 },
        { 2, 10 },
        { 3, 16 },
        { 5, 20 },
        { 6, 24 },
        { 7, 22 },
        { 8, 9 },
        { 11, 14 },
        { 12, 15 },
        { 17, 23 },
        { 18, 25 },
        { 19, 21 }
      };
      Dictionary<int, int> Reflector_C_Dünn = new Dictionary<int, int>()
      {
        { 0, 17 },
        { 1, 3 },
        { 2, 14 },
        { 4, 9 },
        { 5, 13 },
        { 6, 19 },
        { 7, 10 },
        { 8, 21 },
        { 11, 12 },
        { 15, 22 },
        { 16, 25 },
        { 18, 23 },
        { 20, 24 }

      };

      Dictionary<int, int> Res = Reflector_B;

      if (s == "Reflector_C") Res = Reflector_C;
      if (s == "Reflector_B_Dünn") Res = Reflector_B_Dünn;
      if (s == "Reflector_C_Dünn") Res = Reflector_C_Dünn;
      return Res;
    }

    public static Dictionary<int, int> SearchDictForPB(string s)
    {
      Dictionary<int, int> A = new Dictionary<int, int>()
      {
        {0, 24 },
        {1, 17 },
        {2, 20 },
        {3, 7 },
        {4, 16 },
        {5, 18 },
        {6, 11 },
        {8, 15 },
        {9, 23 },
        {10, 13 },
        {12, 14 },
        {19, 25 },
        {21, 22 }


    };
      Dictionary<int, int> B = new Dictionary<int, int>()
      {
        {0, 20 },
        {1, 17 },
        {2, 19 },
        {3, 23 },
        {4, 25 },
        {5, 13 },
        {6, 15 },
        {7, 24 },
        {8, 22 },
        {9, 14 },
        {10, 16 },
        {11, 21 },
        {12, 18 }


    };
      Dictionary<int, int> C = new Dictionary<int, int>()
      {
        {0,2},
        {1,18 },
        {13,25 },
        {19,3 },
        {4,15 },
        {22,7 },
        {5,20 },
        {6,14},
        {8,21 },
        {9,16 },
        {10,23 },
        {11,24 },
        {17,12 }


    };

      Dictionary<int, int> Res = A;
      if (s == "PB_B") Res = B;
      if (s == "PB_C") Res = C;

      return Res;

    }

  }

}

