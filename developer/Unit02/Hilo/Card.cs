using System;

namespace Unit02.Hilo
{
    public class Card
    {
        public int Value;
        
        /// Create a class for a card

        public void NewCard()
        {
            Random randomGenerator = new Random();
            Value = randomGenerator.Next(1,14);
        }
    }
}