using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CardClasses
{
    public class Card
    {
        // Card class variables
        private int suit; // suit ranges from 1 to 4
        private int value; // value ranges from 1 to 13

        private string[] suits = { "????", "clubs", "diamonds", "hearts", "spades" };
        private string[] values = { "????", "ace", "2", "3", "4", "5", "6", "7", "8", "9", "ten", "jack", "queen", "king" };

        // Card class constructors
        // Default constructor
        public Card()
        {
            value = 1;
            suit = 1;
        }

        // Overloaded constructor
        public Card(int v, int s)
        {
            value = v;
            suit = s;
        }

        // Getters and Setters
        public int Value
        {
            get
            {
                return value;
            }
            set
            {
                this.value = value;
            }
        }

        public int Suit
        {
            get
            {
                return suit;
            }
            set
            {
                suit = value;
            }
        }

        // File Name Property
        public string FileName
        {
            get
            {
                return "card" + values[value].Substring(0, 1) + 
                    suits[suit].Substring(0, 1) + ".jpg";
            }
        }
        // Matching Value Method
        public bool HasMatchingValue(Card otherCard)
        {
            if (otherCard.Value == this.value)
                return true;
            else
                return false;
        }

        // Methods that set the image to the given PictureBox to the proper FileName
        // Card Face
        public void Show(PictureBox p)
        {
            p.Image = Image.FromFile(System.Environment.CurrentDirectory +
                "\\Cards\\" + FileName);
        }
        // Card Back
        public void ShowBack(PictureBox p)
        {
            p.Image = Image.FromFile(System.Environment.CurrentDirectory +
                "\\Cards\\black_back.jpg");
        }

        // ToString Method
        public override string ToString()
        {
            return values[value] + " of " + suits[suit];
        }

        // CardIsSuit Methods
        public bool IsHeart()
        {
            if (suit == 3)
                return true;
            else
                return false;
        }

        // CardIsFace Methods
        public bool IsFaceCard()
        {
            if (value >= 11 && value <= 13)
                return true;
            else
                return false;
        }

        public bool IsQueen()
        {
            if (value == 12)
                return true;
            else
                return false;
        }

        // CardIsColor Methods
        public bool IsBlack()
        {
            if (suit == 1 || suit == 4)
                return true;
            else
                return false;
        }
    }
}
