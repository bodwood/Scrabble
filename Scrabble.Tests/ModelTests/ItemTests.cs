using Microsoft.VisualStudio.TestTools.UnitTesting;
using Scrabble.Models;

namespace Scrabble.Tests
{
  [TestClass]
  public class ItemTests
  {
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      //arrange
      Item newItem = new Item("scrabble");  //new instance of Item class
      Assert.AreEqual(typeof(Item), newItem.GetType()); //check to see if item type is the same as the instance type
    }
    [TestMethod]
    public void GetWord_ReturnWord_String()
    {
      string word = "dawg"; //
      Item newItem = new Item(word);  //create new item object, passing in the word

      string result = newItem.Word; //set string to result of grabbing the Word property of newItem

      Assert.AreEqual(word, result);  //make sure word retrieved from the Item object matches the description
    }
    
    [TestMethod]
    public void GetScore_ReturnScore_0()
    {
      Item newItem = new Item("scrabble");
      int score = newItem.Score;

      Assert.AreEqual(0 , score);
    }

    [TestMethod]
    public void SetScore_SetScore_Int()
    {
      Item newItem = new Item("scabble"); 
      newItem.Score = 5;  
      int score = newItem.Score;  

      Assert.AreEqual(5, score);  
    }
  }
}