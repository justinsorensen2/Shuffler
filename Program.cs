using System;
using System.Collections.Generic;
using System.Linq;

namespace Shuffler
{
  class Program
  {
    static void Main(string[] args)
    {
      //ask players 1 and 2 to enter their names
      //store player names in var player1 and player2
      Console.WriteLine("Player 1, please enter your name.");
      var player1 = Console.ReadLine();
      Console.WriteLine("Player 2, please enter your name.");
      var player2 = Console.ReadLine();
      //create a var suit as a list with 4 items - 1 for each suit of cards
      var suit = new List<string>() { "of Clubs", "of Diamonds", "of Hearts", "of Spades" };
      //create a var rank as a list with 13 items - 1 for each rank
      var rank = new List<string>() { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
      //create a new var deck as a list with no members
      var deck = new List<string>();
      //for loop to create deck by adding ranks to suits
      for (var i = 0; i < suit.Count; i++)
      {
        for (var n = 0; n < rank.Count; n++)
        {
          var cardName = rank[n] + " " + suit[i];
          deck.Add(cardName);
        }
      }
      //create a list to contain the cards as they are shuffled and drawn
      var shuffle = new List<string>();
      //create a while loop to draw cards randomly from the deck
      for (var j = 51; j > 0; j--)
      {
        //create a random number generator
        Random rand1 = new Random();
        var v = rand1.Next(1, 52);
        //add drawn card to shuffled deck
        shuffle.Add(deck[v]);
      }
      //create new lists playerHand1 and playerHand2
      var playerHand1 = new List<string>();
      var playerHand2 = new List<string>();
      //for loop to repeat, ask user if they would like to see next card
      //end loop when we either run out of cards or user says no

      for (var l = 51; l > 0; l--)
      {
        if (l % 2 != 0)
        {
          //deal top card to player1
          Console.WriteLine($"{player1} you have been dealt the {shuffle[0]}.");
          playerHand1.Add(shuffle[0]);

          Console.WriteLine($"{player2} would you like to be dealt the next card in the shuffled deck? Valid entries are yes or no.");
          //create variable from user's input
          var nextCard = Console.ReadLine().ToLower();
          //variable to hold truth val, while loop to continue showing cards
          //error correction on inputs
          if (nextCard != "yes" && nextCard != "no")
          {
            Console.WriteLine("That is not a valid entry. Please try again.");
            nextCard = Console.ReadLine().ToLower();
          }
          else if (nextCard == "yes")
          {
            l--;
            Console.WriteLine($"{shuffle[1]} is the next card in the shuffled deck.");
            playerHand2.Add(shuffle[1]);

          }
          else
          {
            l = 0;
            Console.WriteLine("Thank you. Have a nice day!");
          }
        }
        else
        {
          Console.WriteLine($"{player2} you have been dealt the {shuffle[0]}.");
          playerHand2.Add(shuffle[0]);

          Console.WriteLine($"{player1} would you like to be dealt the next card in the shuffled deck? Valid entries are yes or no.");
          //create variable from user's input
          var nextCard = Console.ReadLine().ToLower();
          //variable to hold truth val, while loop to continue showing cards
          //error correction on inputs
          if (nextCard != "yes" && nextCard != "no")
          {
            Console.WriteLine("That is not a valid entry. Please try again.");
            nextCard = Console.ReadLine().ToLower();
          }
          else if (nextCard == "yes")
          {
            l--;
            Console.WriteLine($"{shuffle[1]} is the next card in the shuffled deck.");
            playerHand1.Add(shuffle[1]);

          }
          else
          {
            l = 0;
            Console.WriteLine("Thank you. Have a nice day!");
          }



        }

      }
    }
  }
}
