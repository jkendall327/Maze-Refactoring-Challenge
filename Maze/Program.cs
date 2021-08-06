using System;

public class Program
{
	public static void Main(string[] args)
	{
		var amazing = new Amazing();

		amazing.DoIt(int.Parse(args[0]), int.Parse(args[1]));
		Console.WriteLine(amazing.Result);
	}
}
