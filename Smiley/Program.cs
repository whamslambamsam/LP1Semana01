using System;
using System.IO;
using System.Text;
using System.Globalization;

namespace Smiley
{
    public class Program
    {
        private static void Main(string[] args)
        {
            string input = Console.WriteLine("Insere código\t: ");
            string code = System.Int32.parse(input, System.Globalization, NumberStyles.None);
            Console.outputEncoding = Encoding.UTF8;
            Console.WriteLine(input + code);
        }
    }
}
