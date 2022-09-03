using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace lab1._1
{/// <summary>
/// gets the card and value/ face for driver class 
/// as well as assigning the face/ number to the card
/// </summary>
    internal class Card
    {
        Face Face;
        Suit Suit;
        private Suit i;
        private Face j;

        public Card()
        {
            Face = Face.Three;
            Suit = Suit.Hearts;
        }

        public Card( Card existingCard) 
        {
            Face = existingCard.Face;
            Suit = existingCard.Suit;
        }

        public Card(int n)
        {
         Face = (Face)Enum.GetValues(typeof(Face)).GetValue(n % 13);
         Suit = (Suit)Enum.GetValues(typeof(Suit)).GetValue(n % 4);
        }

        public Card(Suit i, Face j)
        {
            this.i = i;
            this.j = j;
        }

        public override string ToString()
        {

            string cardString = $"the {Face} of {Suit}";
            return cardString; 
        }
        
    }
}
