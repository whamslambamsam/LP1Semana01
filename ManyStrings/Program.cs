using System;

namespace ManyStrings
{
    public class Program
    {
        private static void Main(string[] args)
        {

            string words = "I like the bagels\u2122";
            words += " but I much prefer the donuts\u2122.";

            string blabbering = "Do I look like I know what a \u0027.jpeg\u0027 is?";
            blabbering += "\u000AI just want a photo of a god-dang hot dog!";

            string bees = "OH GOD- \u000AHERE THEY COME. \u000A";
            bees += "\u000A\u1F41 \u1F41 \u1F41 \u1F41 \u1F41 \u1F41 \u1F41 \u1F41 \u000A";
            bees += "\u1F41 \u1F41 THE BEES \u1F41 \u1F41 \u000A";
            bees += "\u1F41 \u1F41 \u1F41 \u1F41 \u1F41 \u1F41 \u1F41 \u1F41 \u000A";

            Console.WriteLine("There's so much Strings!");
            
            Console.WriteLine(" ");

            // Prints the strings
            Console.WriteLine(words);

            Console.WriteLine("-");

            Console.WriteLine(blabbering);

            Console.WriteLine("-");

            Console.WriteLine(bees);

        }
    }
}
