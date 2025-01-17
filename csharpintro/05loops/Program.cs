namespace pma2025
{
    /// <summary>
    /// This class provides a Main method in which
    /// a number of different ways to perform looping
    /// are demonstrated.
    /// </summary>
    class Loops {
        static void Main(string[] args){

            Console.WriteLine("First we count using while:");
            int i = 0;
            while (i < 10)
            {
                Console.Write($"{i} ");
                i++;
            }

            Console.WriteLine("\nNow we count using for");
            for (int j = 0; j < 10; j++)
                Console.Write($"{j} ");

            Console.WriteLine("\nNow we count using do-while");
            int k = 0;
            //Do-while loop always executes at least once!
            do
            {
                Console.Write($"{k} ");
                k++;
            } while (k < 10);

            Console.WriteLine("\nNow we count in twos");
            for (int j = 0; j < 20; j += 2) // "j += 2" means the same as "j = j + 2"
                Console.Write($"{j} ");

            Console.WriteLine("\nNow we count down in twos");
            for (int j = 20; j >= 0; j -= 2) // "j -= 2" means the same as "j = j - 2"
                Console.Write($"{j} ");

            Console.WriteLine("\nNow we have two variables changing value");
            for (int j = 0, x = 10; j < 10; j++, x--)
                Console.WriteLine("j = " + j + ", x = " + x);
        }
    }
}
