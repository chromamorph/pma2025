namespace pma2025
{
    public class BoolTest
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("3 == 3 is " + (3 == 3));
            Console.WriteLine("3 != 3 is " + (3 != 3));
            Console.WriteLine("3 == 2 is " + (3 == 2));
            Console.WriteLine("3 != 2 is " + (3 != 2));
            Console.WriteLine("3 > 2 is " + (3 > 2));
            Console.WriteLine("3 < 2 is " + (3 < 2));
            Console.WriteLine("3 < 3 is " + (3 < 3));
            Console.WriteLine("3 >= 2 is " + (3 >= 2));
            Console.WriteLine("3 >= 3 is " + (3 >= 3));
            Console.WriteLine("3 <= 3 is " + (3 <= 3));
            Console.WriteLine("3 <= 2 is " + (3 <= 2));
            Console.WriteLine("3 == 3 is " + (3 == 3));

            bool b = ((3 / -2) > -1.5);
            Console.WriteLine("b is " + b);
        }
    }
}
