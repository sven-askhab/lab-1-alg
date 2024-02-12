using System;

class Program
{
    static void Main()
    {
        int N = 10;
        int[,] arr = new int[N, N];
        Random random = new Random();
        for (int row = 0; row < N; row++)
        {
            for (int col = 0; col < N; col++)
            {
                arr[row, col] = random.Next(1, 101);
            }
        }

        int[,] minSum = new int[N, N];
        int[,] maxSum = new int[N, N];
ÿ
        minSum[0, 0] = arr[0, 0];
        maxSum[0, 0] = arr[0, 0];

        for (int col = 1; col < N; col++)
        {
            minSum[0, col] = minSum[0, col - 1] + arr[0, col];
            maxSum[0, col] = maxSum[0, col - 1] + arr[0, col];
        }

        for (int row = 1; row < N; row++)
        {
            minSum[row, 0] = minSum[row - 1, 0] + arr[row, 0];
            maxSum[row, 0] = maxSum[row - 1, 0] + arr[row, 0];
        }

        for (int row = 1; row < N; row++)
        {
            for (int col = 1; col < N; col++)
            {
                minSum[row, col] = Math.Min(minSum[row - 1, col], minSum[row, col - 1]) + arr[row, col];
                maxSum[row, col] = Math.Max(maxSum[row - 1, col], maxSum[row, col - 1]) + arr[row, col];
            }
        }
        Console.WriteLine("Minimum amount of coins: " + minSum[N - 1, N - 1]);
        Console.WriteLine("Maximum amount of coins: " + maxSum[N - 1, N - 1]);
    }
}