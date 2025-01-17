
using System;
namespace pma2025
{
    /// <summary>
    /// The % operator and
    /// conditional statements: if, else and switch
    /// </summary>
    class Conditionals
    {
        public static void Main(string[] args)
        {

            /*
             * a % b returns the remainder when
             * a is divided by b. Specifically, if
             * a / b = c where a and b are integers,
             * then a % b = a - (c * b).
             * For example:
             * 5 / 3 = 1 (if they are ints)
             * so 5 % 3 = 5 - (1 * 3) = 2
             * -5 / 3 = -1 (if they are ints)
             * so -5 % 3 = -5 - (-1 * 3) = -2
             * -5 / -3 = 1 (when ints)
             * so -5 % -3 = -5 - (1 * -3) = -2
             * 5 / -3 = -1 (when ints)
             * so 5 % -3 = 5 - (-1 * -3) = 2
             */

            Console.WriteLine("5 % 3 = " + (5 % 3));
            Console.WriteLine("-5 % 3 = " + (-5 % 3));
            Console.WriteLine("-5 % -3 = " + (-5 % -3));
            Console.WriteLine("5 % -3 = " + (5 % -3));

            Console.WriteLine("\nExamples of i % 3:");
            for (int i = -5; i < 6; i++)
                Console.WriteLine(i + " % 3 = " + (i % 3));

            /*
             * Loop that tests that a % b = a - (c * b)
             * for a range of positive and negative values of a and b.
             * Should print nothing!
             */
            Console.WriteLine("The following cases disprove that a % b = a - (c * b):");
            for (int a = -5; a < 6; a++)
            {
                for (int b = -5; b < 6; b++)
                {
                    if (b != 0)
                    {//Cannot divide by zero.
                        int c = a / b;
                        if ((a % b) != (a - (c * b)))
                            Console.WriteLine(a + " % " + b + " = " +
                                    (a % b) + " but (" + a + " - (" + c + " * " + b + ")) = " + (a - (c * b)));
                    }
                }
            }

            Console.WriteLine("\nSay whether a number is odd or even");
            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i + " is even");
                }
                else
                    Console.WriteLine(i + " is odd");
            }

            Console.WriteLine("\nCycle through Red, Green and Blue");
            //Note absence of {..}: Only needed if block contains more than one statement.
            for (int i = 0; i < 10; i++)
                if (i % 3 == 0)
                    Console.Write("Red ");
                else if (i % 3 == 1)
                    Console.Write("Green ");
                else
                    Console.Write("Blue ");

            Console.WriteLine("\nUsing switch to print out number names");
            for (int i = 0; i < 12; i++)
            {
                switch (i % 6)
                {
                    case < 3: Console.WriteLine("Small"); break;
                    case > 3: Console.WriteLine("Big"); break;
                    default: Console.WriteLine("3"); break;
                }
            }
        }
    }

}
