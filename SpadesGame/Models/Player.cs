using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpadesGame.Models{
    
    public class Player
    {
        public int IdPlayer { get; set; }
        public string NamePlayer { get; set; }
        public List<Card> Hand = new List<Card>();
        public int points;

        public Player() { }
    }
}
