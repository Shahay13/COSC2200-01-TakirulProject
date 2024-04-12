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
    // Define the 'Player' class.
    public class Player
    { 
        // Properties.
        public List<Card> Hand { get; private set; }
        public string Name { get; private set; }
        public int Score { get; set; }
        public bool IsAI { get; private set; }

        /// <summary>
        /// Constructor for the Player class.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="isAI"></param>
        public Player(string name, bool isAI)
        {
            // Set the properties based on the constructor parameter.
            Hand = new List<Card>();
            Name = name;
            IsAI = isAI;
        }

        /// <summary>
        /// Receives a collection of cards and adds them to the player's hand.
        /// The hand is then sorted first by suit, then by card value.
        /// </summary>
        /// <param name="dealtCards"></param>
        public void ReceiveCards(IEnumerable<Card> dealtCards)
        {
            Hand.AddRange(dealtCards);
            Hand = Hand.OrderBy(card => card.Suit).ThenBy(card => card.GetCardValue()).ToList();
        }

        /// <summary>
        /// Player chooses a card to play.
        /// </summary>
        /// <param name="leadCard"></param>
        /// <returns></returns>
        public Card ChooseCardToPlay(Card leadCard)
        {
            Card chosenCard = null;

            if (leadCard != null)
            {
                // If the player has a card of the same suit, they must play it.
                chosenCard = Hand.FirstOrDefault(card => card.Suit == leadCard.Suit);
            }

            // If no card of the same suit or no lead card, play any card.
            if (chosenCard == null)
            {
                chosenCard = Hand.FirstOrDefault();
            }

            if (chosenCard != null)
            {
                Hand.Remove(chosenCard);
            }

            return chosenCard;
        }

        /// <summary>
        /// Method to add points to the player's score.
        /// </summary>
        /// <param name="points"></param>
        public void AddPoints(int points)
        {
            Score += points;
        }
    }

}
