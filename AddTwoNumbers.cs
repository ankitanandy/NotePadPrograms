using System;

public class AddTwoNumbers
{
	public static void Main(string[] args)
	{	
		Console.WriteLine("Enter the 1st number");
		int a = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the 2nd number");
		int b = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("The sum is {0}", Add(a,b));
	}
	
	private static int Add(int a , int b)
	{
		if(b==0)
		{	return a;}
		
		int sum = a^b;
		int carry = (a&b)<<1;
		return Add(sum,carry);	
	}
}
