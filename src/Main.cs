// C# program to find nth ugly number
using System;

class Pascal {

  static int row(int k, int i, int c) {
      if (k > i) return 0;
      Console.Write( c + ", ");
      int a = c * (i-k)/(k+1);
      return row(k+1, i, a);
  }

  static int col(int i, int n) {
      if (i > n) return 0;
      row(0, i, 1);
      Console.WriteLine("");
      return col(i+1, n);
  }
	/* Driver program to test above
	functions */
	public static void Main()
	{
		 int input = 10;
		Console.WriteLine("[INPUT] "+ input);
		Console.WriteLine("[OUTPUT] ");
    col(0, input);
	}
}
