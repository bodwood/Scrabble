using System.Collections.Generic;

namespace Scrabble.Models
{
  public class Item //player
  {
    public string Word { get; set; }
    public int Score { get; set; }
    
    public Item(string word) //constructor
    {
      Word = word;
      Score = 0;
    }
  }
}