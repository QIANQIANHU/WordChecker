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
      WordCheckerVariable WordCheckerInst = new WordCheckerVariable(word, "");

      //Act
      string keyWordResult = WordCheckerInst.GetKeyWord();

      //Assert
      Assert.AreEqual(word, keyWordResult);
    }
    [TestMethod]
    public void GetSentence_ReturnSentenced_String()
    {
      //Arrange
      string sentence = "This is a sentence.";
      WordCheckerVariable WordCheckerInst = new WordCheckerVariable("", sentence);

      //Act
      string sentenceResult = WordCheckerInst.GetSentence();

      //Assert
      Assert.AreEqual(sentence, sentenceResult);
    }

    // // [TestMethod]
    // // public void SplitTextToWords_TextToWordsList_WordsList()
    // // {
    // //    //Arrange
    //       string sentence = "This is a sentence."
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
