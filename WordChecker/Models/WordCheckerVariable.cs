using System.Collections.Generic;

namespace WordChecker.Models
{
  public class WordCheckerVariable
  {
    private string _keyWord;
    private string _sentence;

    public WordCheckerVariable(string keyWord, string sentence)
    {
      _keyWord = keyWord;
      _sentence = sentence;
    }

    public string GetKeyWord()
    {
      return _keyWord;
    }

    public string GetSentence()
    {
      return _sentence;
    }

    public int GetCountInt()
    {
       char[] charsToTrim = { '.', ',' ,'!', ' '};  //trim off all these chars from begin or end of the string.
       string trimmedSentence = _sentence.Trim(charsToTrim);

       if (trimmedSentence.Length == 0 || _keyWord.Length == 0)
           return 0;

       int count = 0;
       // Split string on spaces.
       // ... This will separate all the words.
       string[] words = trimmedSentence.Split(' ');
       foreach (string word in words)
       {
          if(word.Equals(_keyWord))
          {
            count += 1;
          }
       }
       return count;
    }

  }
}
