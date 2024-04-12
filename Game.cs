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
    /// Define the 'Game' class.
    /// </summary>
    public class Game
    {
        private Deck deck;
        private List<Player> players;
        private List<Card> currentTrick;
        private Player currentPlayer;
        private bool heartsBroken;

        /// <summary>
        /// Initializes a new instance of the 'Game' class.
        /// </summary>
        public Game()
        {
            deck = new Deck();
            players = new List<Player>
            {
                new Player("Player 1", false),
                new Player("AI 1", true),
                new Player("AI 2", true),
                new Player("AI 3", true)
            };
            currentTrick = new List<Card>();
            heartsBroken = false;
        }

        /// <summary>
        /// Sets up the game by shuffling the deck, dealing cards to players, 
        /// and determining the starting player.
        /// </summary>
        public void Setup()
        {
            deck.Shuffle();
            foreach (var player in players)
            {
                player.ReceiveCards(deck.Deal(13));
            }
            // The player to the left of the dealer starts.
            currentPlayer = players[0]; 
        }

        /// <summary>
        /// Start a round of the game.
        /// </summary>
        public void StartRound()
        {
            // Each player plays 13 times.
            for (int i = 0; i < 13; i++) 
            {
                PlayTrick();
            }
        }

        /// <summary>
        /// Play a single trick.
        /// </summary>
        private void PlayTrick()
        {
            currentTrick.Clear();
            Card leadCard = null;

            foreach (var player in players)
            {
                Card playedCard = player.ChooseCardToPlay(leadCard);
                if (leadCard == null)
                {
                    leadCard = playedCard;
                }
                currentTrick.Add(playedCard);

                // Check if playedCard is not null before accessing its properties
                if (playedCard != null)
                {
                    // Logic to determine if hearts have been broken.
                    if (playedCard.Suit == "Hearts")
                    {
                        heartsBroken = true;
                    }
                }

                if (player.IsAI)
                {
                    // Use the AI logic to determine the card to play
                    playedCard = DetermineAICardToPlay(player);
                }
                else
                {
                    // Human player logic
                    playedCard = player.ChooseCardToPlay(leadCard);
                }
            }

            // Determine the winner of the trick.
            Card winningCard = currentTrick[0];
            foreach (var card in currentTrick)
            {
                if (card != null && card.Suit == leadCard.Suit && card > winningCard)
                {
                    winningCard = card;
                }
            }

            // The player who played the winning card leads the next trick.
            currentPlayer = players[currentTrick.IndexOf(winningCard)];
        }

        /// <summary>
        /// Method to score the round.
        /// </summary>
        private void ScoreRound()
        {
            foreach (var player in players)
            {
                int roundScore = player.Hand.Count(card => card.Suit == "Hearts");
                roundScore += player.Hand.Count(card => card.Rank == "Q" && card.Suit == "Spades") * 5;
                player.AddPoints(roundScore);
                // Clear the cards for the next round.
                player.Hand.Clear(); 
            }
        }

        /// <summary>
        /// Method to determine the winner.
        /// </summary>
        /// <returns></returns>
        private Player DetermineWinner()
        {
            // The player with the lowest score wins.
            return players.OrderBy(p => p.Score).First();
        }

        /// <summary>
        /// The 'PlayGame' method is the main driver of the game. It controls the flow of the game from setup to determining the winner.
        /// </summary>
        public void PlayGame()
        {
            // Setup the game by shuffling the deck and dealing the cards to the players.
            Setup();

            // Start a round of the game. Each player plays 13 times.
            StartRound();

            // Score the round based on the number of hearts each player has and if they have the Queen of Spades.
            ScoreRound();

            // Determine the winner of the game. The player with the lowest score wins.
            Player winner = DetermineWinner();

            // Output the winner and their score.
            Console.WriteLine($"The winner is {winner.Name} with a score of {winner.Score}.");
        }

        // Method to determine the AI's card to play
        private Card DetermineAICardToPlay(Player aiPlayer)
        {
            // Check if the AI is attacking or defending
            bool isAttacking = ShouldAIAttack(aiPlayer);

            // Determine which suit is currently leading (if any)
            string leadingSuit = currentTrick.FirstOrDefault()?.Suit;

            // Get the AI's hand
            List<Card> aiHand = aiPlayer.Hand;

            if (isAttacking)
            {
                // If hearts have been broken or it's safe to play hearts, play the highest heart
                if (heartsBroken || !aiHand.Any(card => card.Suit != "Hearts"))
                {
                    return aiHand.Where(card => card.Suit == "Hearts")
                                 .OrderByDescending(card => card.GetCardValue())
                                 .FirstOrDefault();
                }
                else
                {
                    // Play the highest card of the leading suit, or any suit if the AI is leading
                    return aiHand.Where(card => leadingSuit == null || card.Suit == leadingSuit)
                                 .OrderByDescending(card => card.GetCardValue())
                                 .FirstOrDefault();
                }
            }
            else // Defending
            {
                // Play the lowest card that follows suit, or the lowest card overall if unable to follow suit
                Card cardToPlay = aiHand.Where(card => card.Suit == leadingSuit)
                                        .OrderBy(card => card.GetCardValue())
                                        .FirstOrDefault();

                // If cardToPlay is null, play the lowest card overall
                if (cardToPlay == null)
                {
                    return aiHand.OrderBy(card => card.GetCardValue()).FirstOrDefault();
                }

                return cardToPlay;
            }
        }

        // Method to decide if the AI should attack or defend
        private bool ShouldAIAttack(Player aiPlayer)
        {
            // Simple logic: attack if the AI has a lot of high cards, defend otherwise
            int highCardThreshold = 10; // Value above which a card is considered 'high'
            int highCardsCount = aiPlayer.Hand.Count(card => card.GetCardValue() > highCardThreshold);

            // Attack if more than half of the AI's cards are high
            return highCardsCount > aiPlayer.Hand.Count / 2;
        }
    }
}
