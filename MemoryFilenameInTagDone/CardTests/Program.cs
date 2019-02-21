using CardClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CardTests
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCardConstructors();

            Card aS = new Card(1, 4);
            Card qH = new Card(12, 3);

            TestProperties();
            Console.WriteLine();

            TestHasMatchingValue();
            Console.WriteLine();

            TestCardIsMethods(aS);
            Console.WriteLine();

            TestCardIsMethods(qH);
            Console.WriteLine();

            Console.WriteLine();
            Console.ReadLine();

        }

        // Test Card Constructors
        static void TestCardConstructors()
        {
            Card card1 = new Card();
            Card card2 = new Card(12, 3);

            Console.WriteLine("Testing Constructors");
            Console.WriteLine("Default constructor. Expecting default values. " + card1.ToString() + ".");
            Console.WriteLine("Overloaded constructor. Expecting queen of hearts. " + card2.ToString() + ".");
            Console.WriteLine();
        }

        // Test Properties
        static void TestProperties()
        {
            Console.WriteLine("Testing Properties");
            Card jS = new Card(11, 4);
            string file1 = jS.FileName;
            Console.WriteLine("Testing FileName: expecting cardjs.jpg");
            Console.WriteLine(file1);
            Console.WriteLine();
        }

        static void TestHasMatchingValue()
        {
            Console.WriteLine("Testing HasMatchingValue");
            Card aS = new Card(1, 4);
            Card qH = new Card(12, 3);
            Card qC = new Card(12, 1);

            Console.WriteLine("Expecting The values do not match.");
            if (aS.HasMatchingValue(qH))
                Console.WriteLine("The values match.");
            else
                Console.WriteLine("The values do not match.");

            Console.WriteLine("Expecting The values match.");
            if (qC.HasMatchingValue(qH))
                Console.WriteLine("The values match.");
            else
                Console.WriteLine("The values do not match.");

        }

        // Test Card ToString Method
        static void TestCardToString(Card card)
        {
            Console.WriteLine("Testing toString Method");
            Console.WriteLine("The card is " + card.ToString() + ".");
            Console.WriteLine();
        }

        // Test Card IsMethods
        static void TestCardIsMethods(Card card)
        {
            Console.WriteLine("Testing Is Methods");
            Console.WriteLine("The card is " + card.ToString() + ".");
            Console.WriteLine();

            if (card.IsHeart())
                Console.WriteLine("The card is a heart.");
            else
                Console.WriteLine("The card is not a heart.");
            Console.WriteLine();

            if (card.IsFaceCard())
                Console.WriteLine("The card is a face card");
            else
                Console.WriteLine("The card is not a face card.");
            Console.WriteLine("");

            if (card.IsQueen())
                Console.WriteLine("The card is a queen.");
            else
                Console.WriteLine("The card is not a queen.");
            Console.WriteLine();

            if (card.IsBlack())
                Console.WriteLine("The card is black.");
            else
                Console.WriteLine("The card is not black.");
        }
        
    }
}
