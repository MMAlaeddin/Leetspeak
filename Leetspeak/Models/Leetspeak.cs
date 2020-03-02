using System;
using System.Collections.Generic;

namespace Leetspeak.Models
{
  public class LeetspeakTranslate
  {
    public string IsLeet(string word)
    {
      char[] array = word.ToCharArray();
      for(int i = 0; i < array.Length; i ++)
      {
      if (array[i] == 'e' || array[i] == 'E')
        {
          array[i] = '3';
        }
        else if (array[i] == 'o' || array[i] == 'O')
        {
          array[i] = '0';
        }
        else if (array[i] == 'i')
        {
          array[i] = '1';
        }
        else if (array[i] == 't' || array[i] == 'T')
        {
          array[i] = '7';
        }
        }
        for(int j = 1; j < array.Length; j ++)
        {
        int previousLetter = j - 1;
        if (array[previousLetter] != ' ' && array[j] == 's')
        {
          array[j] = 'z';
        }
      }
      string result = new String(array);
      return result;
    }
  }
}