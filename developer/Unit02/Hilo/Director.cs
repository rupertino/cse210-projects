using System;
using System.Collections.Generic;

namespace Unit02.Hilo
{
    /// <summary>
    /// A person who directs the game. 
    ///
    /// The responsibility of a Director is to control the sequence of play.
    /// </summary>
    public class Director
    {
        List<Card> cards = new List<Card>();
        bool isPlaying = true;
        int totalScore = 300;
        string userGuess;
        int currentCard;
        int nextCard;
        
        /// <summary>
        /// Constructs a new instance of Director.
        /// </summary>
        public Director()
        {
            for(int i = 0; i < 1; i++)
            {
                Card card = new Card();
                cards.Add(card);
            }
        }

        /// <summary>
        /// Starts the game by running the main game loop.
        /// </summary>
        public void StartGame()
        {
            foreach (Card card in cards)
            {
                card.NewCard();
                currentCard = card.Value;
            }
            while (isPlaying)
            {
                DoInputs();
                DoUpdates();
                DoOutputs();
            }
        }

        /// <summary>
        /// Show the current card and ask the user guess.
        /// </summary>
        public void DoInputs()
        {
            Console.WriteLine($"The card is {currentCard}");
            if (!isPlaying)
            {
                return;
            }
            
            foreach (Card card in cards)
            {
                card.NewCard();
                nextCard = card.Value;
            }
            Console.Write("Higher or Lower: [h/l] ");
            string cardGuess = Console.ReadLine();
            userGuess = cardGuess;
        }
        /// <summary>
        /// Draw the user guess with the next card.
        /// </summary>
        public void DoUpdates()
        {
            if (userGuess.Equals("h") && currentCard < nextCard)
            {
                totalScore += 100;
            }
            else if (userGuess.Equals("l") && currentCard > nextCard)
            {
                totalScore += 100;
            }
            else if(userGuess.Equals("h") && currentCard > nextCard)
            {
                totalScore -= 75;
                if (totalScore < 0)
                {
                    totalScore = 0;
                }
            }
            else if(userGuess.Equals("l") && currentCard < nextCard)
            {
                totalScore -= 75;
                if (totalScore < 0)
                {
                    totalScore = 0;
                }
            }

        }
        
        /// <summary>
        /// Show the next card, the score and ask if want to play again.
        /// </summary>
        public void DoOutputs()
        {
            Console.WriteLine($"The next card was: {nextCard}");
            Console.WriteLine($"Your score is: {totalScore}");
            if (totalScore == 0)
            {
                isPlaying = false;
            }
            if (!isPlaying)
            {
                return;
            }

            currentCard = nextCard;
            Console.Write("Play again? [y/n] ");
            string playAgain = Console.ReadLine();
            isPlaying = (playAgain == "y");
        }
    }
}