using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Usage of the Trade Mark (™) unicode
            string words = "I like the bagels\u2122";
            words += " but I much prefer the donuts\u2122.";

            // Usage of \n and the prime (') unicode
            string blabbering = "Do I look like I know what a \u0027.jpeg\u0027 is?";
            blabbering += "\u000AI just want a photo of a god-dang hot dog!";

            // Usage of \n and the omicron with dasia (ὁ) unicode 
            string bees = "OH GOD- \u000AHERE THEY COME. \u000A";
            bees += "\u000A\u1F41 \u1F41 \u1F41 \u1F41 \u1F41 \u1F41 \u1F41 \u1F41 \u000A";
            bees += "\u1F41 \u1F41 THE BEES \u1F41 \u1F41 \u000A";
            bees += "\u1F41 \u1F41 \u1F41 \u1F41 \u1F41 \u1F41 \u1F41 \u1F41 \u000A";

            // Usage of concatenation 
            string plus = "I am going to add the number one to this sentence.";
            plus += "\u000A Watch and learn! " + 1;
            plus += "\u000A How's that for a magic trick?";

            string timeskip = "I will now go back in time!";
            timeskip += "\u000A" + timeskip + "- Huh? Didn't I already say?";

            // Usage of interpolation
            int x = 100;
            int y = 200;
            string dollars = $"{x} plus {y} equals {x+y}!";

            int nine = 9;
            int ten = 10;
            int answer = 21;
            string stupid = $"And {nine} plus {ten} equals {answer}!";
            stupid += "\u000AHate the game, not the player - I just do what i'm told to.";

            Console.WriteLine("There's so much Strings!");
            
            Console.WriteLine(" ");

            // Prints the strings
            Console.WriteLine(words);

            Console.WriteLine("\n-\n");

            Console.WriteLine(blabbering);

            Console.WriteLine("\n-\n");

            Console.WriteLine(bees);

            Console.WriteLine("\n-\n");
            
            Console.WriteLine(plus);

            Console.WriteLine(" ");
            
            Console.WriteLine(timeskip);

            Console.WriteLine("\n-\n");
            
            Console.WriteLine(dollars);

            Console.WriteLine(" ");
            
            Console.WriteLine(stupid);
        }
    }
}
