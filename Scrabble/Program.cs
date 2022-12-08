using System;
using Scrabble.Models;
using System.Runtime;

namespace Scrabble.Program
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter your Scrabble word:");
      string word = Console.ReadLine().ToLower().Trim();

      Item newItem = new Item(word); //create new Item with word, lowercase it and trim it

      char[] charArray = word.ToCharArray();

      for (int i = 0; i < Item.Point1.Length; i++)
      {
        foreach (char j in charArray)
        {
          if (j == Item.Point1[i])
          {
            newItem.Score++;
          }
        }
      }

      for (int i = 0; i < Item.Point2.Length; i++)
      {
        foreach (char j in charArray)
        {
          if (j == Item.Point2[i])
          {
            newItem.Score = newItem.Score + 2;
          }
        }
      }

      for (int i = 0; i < Item.Point3.Length; i++)
      {
        foreach (char j in charArray)
        {
          if (j == Item.Point3[i])
          {
            newItem.Score = newItem.Score + 3;
          }
        }
      }

      for (int i = 0; i < Item.Point4.Length; i++)
      {
        foreach (char j in charArray)
        {
          if (j == Item.Point4[i])
          {
            newItem.Score = newItem.Score + 4;
          }
        }
      }

      for (int i = 0; i < Item.Point5.Length; i++)
      {
        foreach (char j in charArray)
        {
          if (j == Item.Point1[5])
          {
            newItem.Score = newItem.Score + 5;
          }
        }
      }

      for (int i = 0; i < Item.Point8.Length; i++)
      {
        foreach (char j in charArray)
        {
          if (j == Item.Point8[i])
          {
            newItem.Score = newItem.Score + 8;
          }
        }
      }

      for (int i = 0; i < Item.Point10.Length; i++)
      {
        foreach (char j in charArray)
        {
          if (j == Item.Point10[i])
          {
            newItem.Score = newItem.Score + 10;
          }
        }
      }
      Console.WriteLine($"\nYou played the word: '{word}'");
      Console.WriteLine($"\nFor a Score of: {newItem.Score}");
    }
  }
}