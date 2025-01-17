namespace pma2025 {
    class Ints {
        public static void Main(string[] args) {
            		/*
		 * Must declare a variable before you can use it. Can initialize a
		 * variable when you declare it. A variable is assigned a value using
		 * the = operator.
		 */
		int a = 1;
		int b = 2;
		int c = -3;
		// Can leave a variable uninitialized when you declare it
		int d;
		int e, f;

		// Use parentheses to explicitly specify precedence.
		d = a + (b * c);
		e = a - (b / c);
		f = c - (b / a);
		int g = (2 * e) - (c / b);
		Console.WriteLine("d = " + d);
		Console.WriteLine("e = " + e);
		Console.WriteLine("f = " + f);
		Console.WriteLine("g = " + g);

		/*
		 * Use Console.WriteLine to print a line to the console and a new line.
		 * Use + operator to concatenate strings and objects.
		 * 
		 */
		Console.WriteLine(d + d);
		Console.WriteLine("a" + d + d);
		Console.WriteLine("a" + (d + d));
		Console.WriteLine(d + d + "a");
		Console.WriteLine(d + "d");
		Console.WriteLine(-3 / 2);

        }
    }
}