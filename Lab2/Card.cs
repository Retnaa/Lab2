using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Card
    {
        public Face Face { get; set; } //Face Property
        public Suit Suit { get; set; } //Suit Property

        public Card() //Default constructor
        {
            Face = Face.Ace;
            Suit = Suit.Clubs;
        }

        public Card(Card existingCard) //Copy Constructor
        {
            Face = existingCard.Face;
            Suit = existingCard.Suit;

        }

        public Card(int n)   // Parameterized constructor
        {
            Face = (Face)Enum.GetValues(typeof(Face)).GetValue(n % 13);
            Suit = (Suit)Enum.GetValues(typeof(Suit)).GetValue(n % 4);

        }

        public override string ToString() //To String Method to 
        {
            string info = "";

            info += $"the {Face} of {Suit}";

            return info;
        }

    }
}
