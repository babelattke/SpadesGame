using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpadesGame.Models
{
    public class Game
    {
        public List<Card> Shuffled = new List<Card>();
        public List<Player> Players = new List<Player>();

        //Constructor already start with shuffle cards
        public Game()
        {
            Shuffled = new Deck().Shuffle();
        }

        public Game StartGame(string namePlayerHuman)
        {
            Game newGame = new Game();
            newGame.Players = SetPlayers(namePlayerHuman);
            newGame.DealCardsToPlayers(newGame.Shuffled);
            return newGame;
        }

        //Create player to the game
        public List<Player> SetPlayers(string namePlayerHuman)
        {
            List<Player> resultPlayers = new List<Player>();
            string[] namesDefault = { "Fabio", "Roman", "Mauricio", namePlayerHuman };
            for (int i = 0; i < 4; i++)
            {
                resultPlayers.Add(
                    new Player() { IdPlayer = i, NamePlayer = namesDefault[i] }
                );
            }
            return resultPlayers;
        }

        public void DealCardsToPlayers(List<Card> shuffled)
        {
            int auxIdPlayer = 0;
            for (int i = 0; i < shuffled.Count(); i++)
            {
                Card card = shuffled[i];
                bool hasPlyerAlready = Players.Any(l => l.IdPlayer == auxIdPlayer && l.Hand.Count() < 13);
                if (hasPlyerAlready)
                {
                    Player p = Players.FindAll(a => a.IdPlayer == auxIdPlayer).FirstOrDefault();
                    p.Hand.Add(shuffled[i]);
                }
                else
                {
                    i--;
                    auxIdPlayer++;
                }
            }
        }

        //Check who has the Spade A
        public int BigCardToStart(List<Player> players)
        {
            foreach (var player in players)
            {
                foreach (var card in player.Hand)
                {
                    if (card.IdCard == "SA")
                    {
                        return player.IdPlayer;
                    }
                }
            }
            return -1;
        }

        public Card WhichCardWonTheTurn(List<Card> turn)
        {
            Card auxCard = new Card();
            Card greaterCard = turn.FirstOrDefault();
            bool flagHasSpades = turn.Any(a => a.Suit == "Spades");
            //If has any spades, greaterCard assumes the first Card
            if (flagHasSpades)
            {
                greaterCard = turn.Where(a => a.Suit == "Spades").FirstOrDefault();
            }

            for (int i = 1; i < turn.Count; i++)
            {
                auxCard = turn[i];
                if (greaterCard.Suit == auxCard.Suit && greaterCard.valueCard < auxCard.valueCard)
                {
                    greaterCard = auxCard;
                }
            }
            return greaterCard;
        }
    }
}
