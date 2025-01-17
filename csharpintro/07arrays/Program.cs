namespace pma2025
{
	/// <summary>
	/// Arrays in C"
	/// </summary>
	public class Arrays
	{
		public static void Main(string[] args)
		{

			//First we create an array with 5 ints in it.
			int[] intArray = { 1, 2, 3, 4, 5 };

			//Note that array indices are zero-based!!!
			//That is, the first element is at index 0, not index 1.
			Console.WriteLine(intArray[0]); //Prints out 1
			Console.WriteLine(intArray[1]); //Prints out 2

			Console.WriteLine("Print out the values in an array");
			for (int i = 0; i < intArray.Length; i++)
				//No need for {...} because there's only one line in the loop
				//Comments don't count!
				Console.WriteLine(intArray[i]);

			Console.WriteLine("\nNow print out the array in reverse");
			for (int i = intArray.Length - 1; i >= 0; i--)
				//No need for {...} because there's only one line in the loop
				//Comments don't count!
				Console.WriteLine(intArray[i]);

			//Now we make an array to hold 10 strings.
			string[] stringArray = new string[10];
			//Now let's put some strings into stringArray.
			stringArray[0] = "Zero";
			stringArray[1] = "One";
			stringArray[2] = "Two";
			stringArray[3] = "Three";
			stringArray[4] = "Four";
			stringArray[5] = "Five";
			stringArray[6] = "Six";
			stringArray[7] = "Seven";
			stringArray[8] = "Eight";
			stringArray[9] = "Nine";
			Console.WriteLine("\nNow let's count using words instead of numbers");
			for (int i = 0; i < stringArray.Length; i++)
				Console.WriteLine(stringArray[i]);

			Console.WriteLine("\nCounting using the foreach statement");
			foreach (string s in stringArray)
			{
				Console.WriteLine(s);
			}
		}
	}
}
