////////////////////////////////////////////////////////////////////////////////////////////////////////
//////////
//
// Project: Lab1_Cards
// File Name: Card.cs
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
    /// Creating a class to create the default card to display
    /// </summary>
    public class Card
    {
        private object defaultSuit;
        private object defaultFace;

        /// <summary>
        /// Placing value into private objects
        /// </summary>
        /// <param></param>
        /// <returns></returns
        public Card()
        {
             defaultFace = Face.Nine;
             defaultSuit = Suit.Hearts;
        }

        /// <summary>
        /// Initializing default face & card to be a new object that has been copied
        /// by the already existing object.
        /// </summary>
        /// <param>
        /// Card existingCard
        /// </param>
        /// <returns></returns
        public Card(Card existingCard)
        {
            defaultFace = (string)existingCard.defaultFace;
            defaultSuit = (string)existingCard.defaultSuit;
        }

        /// <summary>
        /// Using given formula to get value of user input later for driver
        /// </summary>
        /// <param> 
        /// int n = stands for number that user inputs
        /// </param>
        /// <returns></returns
        public Card(int n)
        {
            defaultFace = (Face)Enum.GetValues(typeof(Face)).GetValue(n % 13);
            defaultSuit = (Suit)Enum.GetValues(typeof(Suit)).GetValue(n % 4);
        }

        /// <summary>
        /// Creating a ToString to give default card value as a string
        /// </summary>
        /// <param></param>
        /// <returns>
        /// defaultCard = full value of defaultCard
        /// </returns
        public override string ToString()
        {
           // string defaultCard = (string)defaultFace + (string)defaultSuit;
            string defaultCard = ($"The {defaultFace} of {defaultSuit}.");
            return defaultCard;
        }
    }
}




