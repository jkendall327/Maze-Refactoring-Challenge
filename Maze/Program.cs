using System;

public class Program
{
	public static void Main(string[] args)
	{
		var amazing = new Amazing(new Random());

		var result = amazing.DoIt(int.Parse(args[0]), int.Parse(args[1]));
		Console.WriteLine(result);
	}
}
