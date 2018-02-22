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

    [TestMethod]
    public void GetCount_GetOneCount_Int()
    {
    //Arrange
      string keyWord = "sentence";
      string sentence = "This is a sentence.";
      WordCheckerVariable WordCheckerInst = new WordCheckerVariable(keyWord, sentence);
      //Act
      int result = WordCheckerInst.GetCountInt();
      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetCount_GetTwoCount_Int()
    {
    //Arrange
      string keyWord = "sentence";
      string sentence = "This is a sentence sentence.";
      WordCheckerVariable WordCheckerInst = new WordCheckerVariable(keyWord, sentence);
      //Act
      int result = WordCheckerInst.GetCountInt();
      //Assert
      Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void GetCount_GetZeroCount_Int()
    {
    //Arrange
      string keyWord = "sentence";
      string sentence = "This is a fail test.";
      WordCheckerVariable WordCheckerInst = new WordCheckerVariable(keyWord, sentence);
      //Act
      int result = WordCheckerInst.GetCountInt();
      //Assert
      Assert.AreEqual(0, result);
    }

  }
}
