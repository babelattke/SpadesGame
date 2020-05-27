using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpadesGame.Models
{
    public class Card
    {
        public string Suit { get; set; }
        public string IdCard { get; set; }
        public int valueCard { get; set; }
        public int Priority { get; set; }

        public Card() { }
    }
}
