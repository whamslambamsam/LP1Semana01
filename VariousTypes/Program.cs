using System;

namespace VariousTypes
{
    public class Program
    {
        private static void Main(string[] args)
        {
            int firstNumber = 3;
            int secondNumber = 5;
            char greek = '\u03C1';
            char star = '\u2605';
            float floatNum = 45.0f;
            double doubleNum = 23.9d;
            bool condition = true;
            bool falseCondition = false;

            Console.WriteLine(firstNumber);
            Console.WriteLine(secondNumber);

            Console.WriteLine(greek);
            Console.WriteLine(star);

            Console.WriteLine(floatNum);
            Console.WriteLine(doubleNum);

            Console.WriteLine(condition);
            Console.WriteLine(falseCondition);
        }
    }
}
