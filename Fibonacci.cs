using System;


public static class Fibonacci
{
    public static int getnthFibonacci(int n)
    {
        if (n == 2)
        {
            return 1;
        }
        if (n == 1)
        {
            return 0;
        }

        return getnthFibonacci(n - 2) + getnthFibonacci(n - 1);
    }


    public static void PrintFibonacciSeries(int n)
    {
        int f1 = 0, f2 = 1, i;

        if (n < 1)
            return;
	Console.Write(f1 + " ");
        for (i = 1; i < n; i++)
        {
            Console.Write(f2 + " ");
            int next = f1 + f2;
            f1 = f2;
            f2 = next;
        }

    }


    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("The {0}th Fibonacci number is {1} ", n, getnthFibonacci(n));
        Console.WriteLine("The Series is :");
        PrintFibonacciSeries(n);

        Console.ReadKey();
    }
}