////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Lab1_Cards
// File Name: CardDriver.cs
// Description: Displaying default card and requesting for User to pick cards and then display entire deck.
// Course: CSCI 1260-001 – Introduction to Computer Science II
// Author: Kelsey Blevins - blevinskl2@etsu.edu
// Created: Wednesday, August 31, 2022
//
////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////

using System;
using Lab1_Card;

namespace Lab1_Card
{
    /// <summary>
    /// Creating a class to call in the default card and to ask user for input and displaying all the playing cards.
    /// </summary>
    public class CardDriver
    {
        /// <summary>
        /// Displaying default card and asking for user input to show cards they request that will continue until
        /// typing -1.
        /// </summary>
        static public void Main(String[] args)
        {
            Card defaultCards = new Card();

            Console.WriteLine($"The default card is {defaultCards.ToString()}");

            Console.WriteLine("Enter a number between 1 and 52. Enter -1 to exit.");
            int userInput = Int32.Parse(Console.ReadLine());

            while (userInput != -1)
            {

                if (userInput >= 1 && userInput <= 52)
                {
                    // print the card they pick
                    //new Card(userInput) is an anonymus variable 
                    Console.WriteLine($"The card you chose is {new Card(userInput).ToString()}");
                }
                else
                {
                    Console.WriteLine("INVALID IDIOT");
                }

                Console.WriteLine("Enter a number between 1 and 52. Enter -1 to exit.");
                userInput = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine("\n \n \n");
            ShowDeck();
        }
        /// <summary>
        /// After having user pick cards from above, will display all cards by number, face, and suit.
        /// </summary>
        static void ShowDeck()
        {
            Console.WriteLine("All 52 cards: \n");
            for (int n = 1; n <= 52; n++)
            {
                Console.WriteLine($"{new Card(n).ToString()}");
            }
        }
    }
}

