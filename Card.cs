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
    /// The 'Card' class represents a playing card.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Gets or sets the suit of the card.
        /// </summary>
        public string Suit { get; set; }

        /// <summary>
        /// Gets or sets the rank of the card.
        /// </summary>
        public string Rank { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Card"/> class.
        /// </summary>
        /// <param name="suit">The suit of the card.</param>
        /// <param name="rank">The rank of the card.</param>
        public Card(string suit, string rank)
        {
            Suit = suit;
            Rank = rank;
        }

        /// <summary>
        /// Determines whether the first specified card is greater than the 
        /// second specified card. If the second card is null, the first card is considered greater.
        /// </summary>
        /// <param name="card1">The first card to compare.</param>
        /// <param name="card2">The second card to compare.</param>
        /// <returns>True if the value of the first card is greater than the 
        /// value of the second card; otherwise, false.</returns>
        public static bool operator >(Card card1, Card card2)
        {
            if (card2 == null)
            {

                return true;
            }
            return card1.GetCardValue() > card2.GetCardValue();
        }

        /// <summary>
        /// Determines whether the first specified card is less than the 
        /// second specified card. If the second card is null, the first card is considered not less.
        /// </summary>
        /// <param name="card1">The first card to compare.</param>
        /// <param name="card2">The second card to compare.</param>
        /// <returns>True if the value of the first card is less than the value 
        /// of the second card; otherwise, false.</returns>
        public static bool operator <(Card card1, Card card2)
        {
            if (card2 == null)
            {

                return false;
            }
            return card1.GetCardValue() < card2.GetCardValue();
        }

        /// <summary>
        /// Converts the card rank to a value for comparison. Face cards are assigned the following values:
        /// Ace = 14, King = 13, Queen = 12, Jack = 11. Number cards are assigned their face value.
        /// </summary>
        /// <returns>The integer value of the card's rank.</returns>
        public int GetCardValue()
        {
            switch (Rank)
            {
                case "A":
                    return 14;
                case "K":
                    return 13;
                case "Q":
                    return 12;
                case "J":
                    return 11;
                default:
                    return int.Parse(Rank);
            }
        }
    }
}
