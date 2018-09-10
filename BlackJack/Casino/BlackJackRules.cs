using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casino.BlackJack
{
    class BlackJackRules
    {
        // Converts Card Face Values to value integers
        private static Dictionary<Face, int> _cardValues = new Dictionary<Face, int>()
        {
            [Face.Two] = 2,
            [Face.Three] = 3,
            [Face.Four] = 4,
            [Face.Five] = 5,
            [Face.Six] = 6,
            [Face.Seven] = 7,
            [Face.Eight] = 8,
            [Face.Nine] = 9,
            [Face.Ten] = 10,
            [Face.Jack] = 10,
            [Face.Queen] = 10,
            [Face.King] = 10,
            [Face.Ace] = 1
        };

        // Generates an integer array of possible hand values based on number of Aces
        private static int[] GetAllPossibleHandValues(List<Card> Hand)
        {
            int aceCount = Hand.Count(x => x.Face == Face.Ace);     // get num of aces in hand
            int[] result = new int[aceCount + 1];                   // int array of size of value options based on hand
            int value = Hand.Sum(x => _cardValues[x.Face]);         // get value of hand if all aces = 1
            result[0] = value;                                      // insert all aces = 1 (or no aces) into int array
            if(result.Length == 1) { return result; }               // return if no aces
            for(int i = 1; i < result.Length; i++)                   // Ace Loop
            {
                value = value + (i * 10);                           // make i aces have value 11
                result[i] = value;                                  // i = number of aces valued at 11
            }
            return result; 
        }

        // Checks to see if Hand contains a Blackjack
        public static bool CheckForBlackJack(List<Card> Hand)
        {
            int[] possibleVaues = GetAllPossibleHandValues(Hand);
            int value = possibleVaues.Max();
            if(value == 21) { return true; }
            else { return false; }

        }

        public static bool IsBusted(List<Card> Hand)
        {
            int value = GetAllPossibleHandValues(Hand).Min();
            if(value > 21) { return true; }
            return false;
        }

        public static bool ShouldDealerStay(List<Card> Hand)
        {
            int[] possibleHandValues = GetAllPossibleHandValues(Hand);
            foreach (int value in possibleHandValues)
            {
                if (value > 16 && value < 22) { return true; }

            }
            return false;
        }

        public static bool? CompareHands(List<Card> PlayerHand, List<Card> DealerHand)
        {
            int[] playerResults = GetAllPossibleHandValues(PlayerHand);
            int[] dealerResults = GetAllPossibleHandValues(DealerHand);

            int playerScore = playerResults.Where(x => x < 22).Max(); 
            int dealerScore = dealerResults.Where(x => x < 22).Max();

            if (playerScore > dealerScore) return true;
            else if (playerScore < dealerScore) return false;
            else return null;
        }

    }
}
