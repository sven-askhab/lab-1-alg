using System;
class Program
{
    static int F(int n)
    {
        if (n == 1)
        {
            return 1;
        }
        else if (n > 1)
        {
            return F(n - 1) * (n + 1);
        }
        else
        {
            return n;
        }
    }

    static void Main()
    {
        Console.WriteLine("Enter n");
        int n = Convert.ToInt32(Console.ReadLine());
        int result = F(n);
        Console.WriteLine($"F({n}) = {result}");
    }
}