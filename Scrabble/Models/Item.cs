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
    public static char[] Point1 = { 'a', 'e', 'i', 'o', 'u', 'l', 'n', 'r', 's', 't' }; //Do we need to test this?
    public static char[] Point2 = { 'd', 'g', };
    public static char[] Point3 = { 'b', 'c', 'm', 'p' };
    public static char[] Point4 = { 'f', 'h', 'v', 'w', 'y' };
    public static char[] Point5 = { 'k' };
    public static char[] Point8 = { 'j', 'x'};
    public static char[] Point10 = {'q', 'z'};
  }
}