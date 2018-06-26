using System;
namespace Leetspeak
{
  public class Letters
  {

    public string letterToNumber(string letter)
    {
      // letter = letter.ToLower();
      //   string test = "";

      char[]array = letter.ToCharArray();

      for (int i = 0; i < array.Length; i++)
      {
        if (array[i] == 'e')
        {
          array[i] = '3';
        }
        else if (array[i] == 'o')
        {
          array[i] = '0';
        }
        else if (array[i]== 'I')
        {
          array[i] = '1';
        }
        else if (array[i]== 't')
        {
          array[i] = '7';
        }
        else{
          array[i] = array[i];
        }
      }
      string result = string.Join("", array);
      return result;




  //   letter = letter.ToLower();
  //   string test = "";
   //
   //
  //   if (letter.Contains("e"))
  //   {
  //   test = letter.Replace("e","3");
  //     return test;
  //    }
  //    else
  //   {
  //     return letter;
  //   }
   //
  //   if (letter.Contains("o"))
  //   {
  //     test = letter.Replace("o","0");
  //       return test;
  //   }
  //   else
  //  {
  //    return letter;
  //  }
   //
   //
  //   if (letter.Contains("i"))
  //   {
  //     test = letter.Replace("i","1");
  //       return test;
  //   }
  //   else
  //  {
  //    return letter;
  //  }
   //
  //   if(letter.Contains("t"))
  //   {
  //     test = letter.Replace("t","7");
  //       return test;
  //   }
  //    else
  //   {
  //     return letter;
  //   }
  }



  }
  class Leet
  {
    static void Main()
    {
      Letters LetterTestEOT = new Letters();
      Console.WriteLine (" Please enter your sentence");
      string sentence = Console.ReadLine();
      Console.WriteLine(LetterTestEOT.letterToNumber(sentence));
    }
  }

}
