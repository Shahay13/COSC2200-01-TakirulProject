/* Program: Hearts
 * Author: Takirul
 * Date: February 20, 2024
 * Description: In this program, I have created a C# Windows application that includes 
 * game-play logic, computer players, a graphical user interface, object-oriented 
 * programming concepts, internal documentation, and a user guide and tutorial. 
 * It also includes the number of cards and the number of players.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hearts
{
    /// <summary>
    /// The 'Deck' class represents a deck of playing cards.
    /// </summary>
    public class Deck
    {
        /// <summary>
        /// A list of 'Card' objects representing the deck of cards.
        /// </summary>
        private List<Card> cards;

        /// <summary>
        /// Initializes a new instance of the 'Deck' class.
        /// </summary>
        public Deck()
        {
            // Initialize the list of cards.
            cards = new List<Card>();

            // Define the suits and ranks.
            string[] suits = { "Hearts", "Diamonds", "Clubs", "Spades" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };

            // Create a new card for each suit and rank and add it to the deck.
            foreach (string suit in suits)
            {
                foreach (string rank in ranks)
                {
                    cards.Add(new Card(suit, rank));
                }
            }
        }

        /// <summary>
        /// Shuffles the deck of cards.
        /// </summary>
        public void Shuffle()
        {
            // Create a new random number generator.
            Random rng = new Random();

            // Implement the Fisher-Yates shuffle algorithm.
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

        /// <summary>
        /// Deals a specified number of cards from the deck.
        /// </summary>
        /// <param name="count">The number of cards to deal.</param>
        /// <returns>A list of 'Card' objects representing the dealt cards.</returns>
        public IEnumerable<Card> Deal(int count)
        {
            // Take the specified number of cards from the top of the deck.
            var dealtCards = cards.Take(count);

            // Remove the dealt cards from the deck.
            cards = cards.Skip(count).ToList();

            // Return the dealt cards.
            return dealtCards;
        }
    }
}
