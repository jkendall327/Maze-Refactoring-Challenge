using System;

public class Program
{
	public static void Main(string[] args)
	{
		Amazing.doit(int.Parse(args[0]), int.Parse(args[1]));
		Console.WriteLine(Amazing.result);
	}
}
