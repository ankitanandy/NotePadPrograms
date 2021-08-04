/*Given a 32-bit signed integer, reverse digits of an integer.

Example 1:

Input: 123
Output: 321
Example 2:

Input: -123
Output: -321
Example 3:

Input: 120
Output: 21 
*/


using System;

public class ReverseInteger
{
	public static void Main(string[] args)
	{
		Console.WriteLine("Enter an integer to reverse:");
		int num = Convert.ToInt32(Console.ReadLine());
		Console.WriteLine(Reverse(num));
	}

	private static int Reverse(int num)
	{
		int rev = 0,rem =0;
		bool negative = false;
		if(num<0)
		{
			negative = true;
			num *=-1;
		}

		while(num>0)
		{
			rem = num%10;
			rev=rev*10+rem;
			num = num/10;
		}
		
		if(negative)
		{	rev*=-1;
		}
		
		return rev;
	}
}