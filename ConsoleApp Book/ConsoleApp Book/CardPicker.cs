using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp_Book
{
    internal class CardPicker
    {
        static Random random = new Random();
        public static string[] PickSomeCards(int numberOfCards)
        {
            string[] pickedCards = new string[numberOfCards];
            for (int i = 0; i < numberOfCards; i++)
            {
                pickedCards[i] = RandomValue() + " of " + RandomSuit();
            }
            return pickedCards;
        }

        private static string RandomSuit()
        {
            // получить случайное число от 1 до 4
            int value = random.Next(1, 5);
            // если это 1, вернуть строку Spades
            if (value == 1) return "Spades";
            // если это 2, вернуть строку Hearts
            if (value == 2) return "Hearts";
            // если это 3, вернуть строку Clubs
            if (value == 3) return "Clubs";
            // если выполнение продолжается, вернуть строку Diamonds
            return "Diamonds";
        }

        private static string RandomValue()
        {
            int value = random.Next(1, 14);
            if (value == 1) return "Ace";
            if (value == 11) return "Jack";
            if (value == 12) return "Queen";
            if (value == 13) return "King";
            return value.ToString();
        }
    }
}
