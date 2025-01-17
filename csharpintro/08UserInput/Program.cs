using System;
namespace pma2025
{
    class UserInput
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please input an integer (and press ENTER) ");
            string? iStr = Console.ReadLine();
            if (iStr != null)
            {
                iStr = iStr.Trim();
                try
                {
                    int i = Int32.Parse(iStr);
                    Console.WriteLine($"{2 * i} is twice what you entered!");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse '{iStr}'");
                }
            }
        }
    }
}