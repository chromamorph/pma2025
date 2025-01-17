using System;
namespace pma2025
{
    public class Doubles
    {
        public static void Main(string[] args)
        {
            /*
             * If we don't use the decimal point, then C# interprets the number as
             * an int.
             */
            Console.WriteLine(3 / 2);
            /*
             * If we use a decimal point in any of the numbers in our expression,
             * then C# interprets all the numbers in the expression as double.
             */
            Console.WriteLine(3 / 2.0);
            Console.WriteLine(3.0 / 2.0);
            // * and / have higher precedence than + and -
            Console.WriteLine(3.0 * 1.5 - 2.5);
            Console.WriteLine(-2.5 + 3.0 * 1.5);
            Console.WriteLine(3.0 * (1.5 - 2.5));
            // Operators with the same precedence are evaluated in order of
            // occurrence. Use parentheses to control order of evaluation.
            Console.WriteLine(3.0 / 2.0 * 3.0);
            Console.WriteLine((3.0 / 2.0) * 3.0);
            Console.WriteLine(3.0 / (2.0 * 3.0));
        }
    }
}
