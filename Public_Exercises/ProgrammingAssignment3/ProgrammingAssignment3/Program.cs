using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using ConsoleCards;

// IMPORTANT: Only add code in the section
// indicated below. The code I've provided
// makes your solution work with the 
// automated grader on Coursera

/// <summary>
/// Programming Assignment 3
/// </summary>
class Program
{
    /// <summary>
    /// Programming Assignment 3
    /// </summary>
    /// <param name="args">command-line args</param>
    static void Main(string[] args)
    {
        // loop while there's more input
        string input = Console.ReadLine();
        while (input[0] != 'q')
        {

            // Add your code between this comment
            // and the comment below. You can of
            // course add more space between the
            // comments as needed

            // declare a deck variables and create a deck object
            // DON'T SHUFFLE THE DECK

            Deck deckObj = new Deck();

            // deal 2 cards each to 4 players (deal properly, dealing
            // the first card to each player before dealing the
            // second card to each player)

            Card firstCardP1 = deckObj.TakeTopCard();
            Card firstCardP2 = deckObj.TakeTopCard();
            Card firstCardP3 = deckObj.TakeTopCard();
            Card firstCardP4 = deckObj.TakeTopCard();
            Card secondCardP1 = deckObj.TakeTopCard();
            Card secondCardP2 = deckObj.TakeTopCard();
            Card secondCardP3 = deckObj.TakeTopCard();
            Card secondCardP4 = deckObj.TakeTopCard();

            // deal 1 more card to players 2 and 3

            Card thirdCardP2 = deckObj.TakeTopCard();
            Card thirdCardP3 = deckObj.TakeTopCard();

            // flip all the cards over

            firstCardP1.FlipOver();
            firstCardP2.FlipOver();
            firstCardP3.FlipOver();
            firstCardP4.FlipOver();
            secondCardP1.FlipOver();
            secondCardP2.FlipOver();
            secondCardP3.FlipOver();
            secondCardP4.FlipOver();
            thirdCardP2.FlipOver();
            thirdCardP3.FlipOver();

            // print the cards for player 1

            Console.WriteLine(firstCardP1.Rank + "," + firstCardP1.Suit);
            Console.WriteLine(secondCardP1.Rank + "," + secondCardP1.Suit);

            // print the cards for player 2

            Console.WriteLine(firstCardP2.Rank + "," + firstCardP2.Suit);
            Console.WriteLine(secondCardP2.Rank + "," + secondCardP2.Suit);
            Console.WriteLine(thirdCardP2.Rank + "," + thirdCardP2.Suit);

            // print the cards for player 3

            Console.WriteLine(firstCardP3.Rank + "," + firstCardP3.Suit);
            Console.WriteLine(secondCardP3.Rank + "," + secondCardP3.Suit);
            Console.WriteLine(thirdCardP3.Rank + "," + thirdCardP3.Suit);

            // print the cards for player 4

            Console.WriteLine(firstCardP4.Rank + "," + firstCardP4.Suit);
            Console.WriteLine(secondCardP4.Rank + "," + secondCardP4.Suit);

            // Don't add or modify any code below
            // this comment
            input = Console.ReadLine();
        }
    }
}