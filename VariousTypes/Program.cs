using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Integers
            int numsix = 6;
            int numfive = 5;
            int numthree = 3;

            // Characters
            char charbengali = '\u09D7';
            char charomega = '\u03A9';
            char charalpha = '\u03B1';

            // Real numbers
            double realpi = 3.1415;
            double realnum_thirty = 35.66;
            double realnum_nine = 9.730;

            // Booleans
            bool factcheck = true;
            bool nineplustenequalstwentyone = false;

            // The WriteLine commands start here
            Console.WriteLine("Hello various Types!");
            
            Console.WriteLine(" ");

            // Integers
            Console.WriteLine(numsix);
            Console.WriteLine(numfive);
            Console.WriteLine(numthree);

            Console.WriteLine(" ");

            // Characters
            Console.WriteLine(charbengali);
            Console.WriteLine(charomega);
            Console.WriteLine(charalpha);

            Console.WriteLine(" ");

            // Real numbers
            Console.WriteLine(realpi);
            Console.WriteLine(realnum_thirty);
            Console.WriteLine(realnum_nine);

            Console.WriteLine(" ");

            // Booleans
            Console.WriteLine(factcheck);
            Console.WriteLine(nineplustenequalstwentyone);
            
        }
    }
}
