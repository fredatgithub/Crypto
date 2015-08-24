using System;

namespace SearchAllCombinaisons
{
  class Program
  {
    static readonly char[] PossibleCharacters =  {'0','1','2','3','4','5','6','7','8','9',
      'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
      'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
      '~', '!', '@', '#', '$', '%', '^', '&', '*', '(', ')', '-', '_', '=', '+', '[', ']', '{', '}',
      ';', ':', ',', '.', '<', '>', '/', '?' };
    static string _findPassword;
    static int _combi;

    static void Main()
    {
      int count;
      Console.WriteLine("Enter your Password");
      _findPassword = Console.ReadLine();
      DateTime today = DateTime.Now;
      Console.WriteLine("START:\t{0}", today.ToString("yyyy-MM-dd_HH:mm:ss"));
      for (count = 0; count <= 15; count++)
      {
        Recurse(count, 0, "");
      }
    }

    static void Recurse(int length, int position, string baseString)
    {
      for (int count = 0; count < PossibleCharacters.Length; count++)
      {
        _combi++;
        if (position < length - 1)
        {
          Recurse(length, position + 1, baseString + PossibleCharacters[count]);
        }

        if (baseString + PossibleCharacters[count] == _findPassword)
        {
          DateTime today = DateTime.Now;
          Console.WriteLine("END:\t{0}\nCombi:\t{1}", today.ToString("yyyy-MM-dd_HH:mm:ss"), _combi);
          Console.WriteLine("Press a key to exit:");
          Console.ReadLine();
          Environment.Exit(0);
        }

        Console.WriteLine(_combi);
      }
    }
  }
}