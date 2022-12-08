using System;
using Scrabble.Models;

namespace Scrabble.Program
{
  public class Program
  {
    static void Main()
    {
      Console.WriteLine("Enter your Scrabble word:");
      string word = Console.ReadLine().ToLower().Trim();
      Console.WriteLine($"\nYour word is '{word}'");

      Item newItem = new Item(word); //create new Item with word, lowercase it and trim it
      Console.WriteLine(newItem.Word);

      char[] wordArray = word.ToCharArray(); //coverts our string to a char array

      //check if letters in word array match newItem.Point1


      // for(int i = 0; i < wordArray.Length; i++)
      // {
      //   Console.WriteLine(wordArray[i]);
      // }
    }
  }
}