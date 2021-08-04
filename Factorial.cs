using System;
public class Factorial
{
	public static int getFactorial(int n)
	{
		if(n == 0 || n==1)
		{
			return 1;
		}
		return n *  getFactorial(n-1);
	}  


	public static void Main(string[] args)
	{
        int n = Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("{0}! ={1}",n,getFactorial(n));
	}
}