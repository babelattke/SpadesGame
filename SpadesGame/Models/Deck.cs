using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpadesGame.Models
{
    public class Deck
    {
        //Set the cards
        List<Card> Cards = new List<Card>()
        {
			//Spades
			new Card(){Suit="Spades", IdCard="SA", valueCard=14, Priority=3},
            new Card(){Suit="Spades", IdCard="SK", valueCard=13, Priority=2},
            new Card(){Suit="Spades", IdCard="SQ", valueCard=12, Priority=2},
            new Card(){Suit="Spades", IdCard="SJ", valueCard=11, Priority=2},
            new Card(){Suit="Spades", IdCard="S10", valueCard=10, Priority=2},
            new Card(){Suit="Spades", IdCard="S9", valueCard=9, Priority=2},
            new Card(){Suit="Spades", IdCard="S8", valueCard=8, Priority=2},
            new Card(){Suit="Spades", IdCard="S7", valueCard=7, Priority=2},
            new Card(){Suit="Spades", IdCard="S6", valueCard=6, Priority=2},
            new Card(){Suit="Spades", IdCard="S5", valueCard=5, Priority=2},
            new Card(){Suit="Spades", IdCard="S4", valueCard=4, Priority=2},
            new Card(){Suit="Spades", IdCard="S3", valueCard=3, Priority=2},
            new Card(){Suit="Spades", IdCard="S2", valueCard=2, Priority=2},
			//Hearths
			new Card(){Suit="Hearths", IdCard="HA", valueCard=14, Priority=1},
            new Card(){Suit="Hearths", IdCard="HK", valueCard=13, Priority=0},
            new Card(){Suit="Hearths", IdCard="HQ", valueCard=12, Priority=0},
            new Card(){Suit="Hearths", IdCard="HJ", valueCard=11, Priority=0},
            new Card(){Suit="Hearths", IdCard="H10", valueCard=10, Priority=0},
            new Card(){Suit="Hearths", IdCard="H9", valueCard=9, Priority=0},
            new Card(){Suit="Hearths", IdCard="H8", valueCard=8, Priority=0},
            new Card(){Suit="Hearths", IdCard="H7", valueCard=7, Priority=0},
            new Card(){Suit="Hearths", IdCard="H6", valueCard=6, Priority=0},
            new Card(){Suit="Hearths", IdCard="H5", valueCard=5, Priority=0},
            new Card(){Suit="Hearths", IdCard="H4", valueCard=4, Priority=0},
            new Card(){Suit="Hearths", IdCard="H3", valueCard=3, Priority=0},
            new Card(){Suit="Hearths", IdCard="H2", valueCard=2, Priority=0},
			//Diamonds
			new Card(){Suit="Diamonds", IdCard="DA", valueCard=14, Priority=1},
            new Card(){Suit="Diamonds", IdCard="DK", valueCard=13, Priority=0},
            new Card(){Suit="Diamonds", IdCard="DQ", valueCard=12, Priority=0},
            new Card(){Suit="Diamonds", IdCard="DJ", valueCard=11, Priority=0},
            new Card(){Suit="Diamonds", IdCard="D10", valueCard=10, Priority=0},
            new Card(){Suit="Diamonds", IdCard="D9", valueCard=9, Priority=0},
            new Card(){Suit="Diamonds", IdCard="D8", valueCard=8, Priority=0},
            new Card(){Suit="Diamonds", IdCard="D7", valueCard=7, Priority=0},
            new Card(){Suit="Diamonds", IdCard="D6", valueCard=6, Priority=0},
            new Card(){Suit="Diamonds", IdCard="D5", valueCard=5, Priority=0},
            new Card(){Suit="Diamonds", IdCard="D4", valueCard=4, Priority=0},
            new Card(){Suit="Diamonds", IdCard="D3", valueCard=3, Priority=0},
            new Card(){Suit="Diamonds", IdCard="D2", valueCard=2, Priority=0},
			//Clubs
			new Card(){Suit="Clubs", IdCard="CA", valueCard=14, Priority=1},
            new Card(){Suit="Clubs", IdCard="CK", valueCard=13, Priority=0},
            new Card(){Suit="Clubs", IdCard="CQ", valueCard=12, Priority=0},
            new Card(){Suit="Clubs", IdCard="CJ", valueCard=11, Priority=0},
            new Card(){Suit="Clubs", IdCard="C10", valueCard=10, Priority=0},
            new Card(){Suit="Clubs", IdCard="C9", valueCard=9, Priority=0},
            new Card(){Suit="Clubs", IdCard="C8", valueCard=8, Priority=0},
            new Card(){Suit="Clubs", IdCard="C7", valueCard=7, Priority=0},
            new Card(){Suit="Clubs", IdCard="C6", valueCard=6, Priority=0},
            new Card(){Suit="Clubs", IdCard="C5", valueCard=5, Priority=0},
            new Card(){Suit="Clubs", IdCard="C4", valueCard=4, Priority=0},
            new Card(){Suit="Clubs", IdCard="C3", valueCard=3, Priority=0},
            new Card(){Suit="Clubs", IdCard="C2", valueCard=2, Priority=0}
        };

        public Deck() { }

        //Shuffle the cards
        public List<Card> Shuffle()
        {
            List<Card> auxCards = new List<Card>();
            Random r = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                //Draw Card's Number
                int DrawNum = r.Next(0, Cards.Count);
                int DrawNumPlayer = r.Next(0, 4);
                bool hascard = auxCards.Any(l => l.IdCard == Cards[DrawNum].IdCard);
                if (hascard == false)
                {
                    auxCards.Add(Cards[DrawNum]);
                }
                else
                {
                    i--;
                }
            }
            return auxCards;
        }
    }
}
