using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordChecker.Models;//namespace here is strict.
using System.Collections.Generic;
using System.Diagnostics;
using System;

namespace WordChecker.TestTools{
  [TestClass]
  public class WordCheckerTest
  {
    [TestMethod]
    public void GetKeyWord_ReturnKeyWord_String()
    {
      //Arrange
      string word = "word";
      WordCheckerVariable newWord = new WordCheckerVariable(word);

      //Act
      string result = newWord.GetKeyWord();

      //Assert
      Assert.AreEqual(word, result);
    }
    // // [TestMethod]
    // // public void SplitTextToWords_TextToWordsList_WordsList()
    // // {
    // //    //Arrange
    //       string description = "Walk the dog.";
    //       Item newItem = new Item(description);
    //
    //       //Act
    //       string result = newItem.GetDescription();
    //
    //       //Assert
    //       Assert.AreEqual(description, result);
    // // }

  }
}
