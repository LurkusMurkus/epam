using System;

/// <summary>
/// Create a program that takes a sequence of symbols (string) as arguments from the command line
/// and prints the maximum number of unequal consecutive characters per line to the console.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 0)
        {
            Console.WriteLine("Please provide a sequence of symbols as command line arguments.");
            return;
        }

        foreach (var arg in args)
        {
            int maxConsecutiveCount = GetMaxConsecutiveCount(arg);
            Console.WriteLine($"Maximum consecutive unequal characters in '{arg}': {maxConsecutiveCount}");
        }
    }

    static int GetMaxConsecutiveCount(string sequence)
    {
        if (string.IsNullOrEmpty(sequence))
        {
            return 0;
        }

        int maxCount = 1;
        int currentCount = 1;

        for (int i = 1; i < sequence.Length; i++)
        {
            if (sequence[i] != sequence[i - 1])
            {
                currentCount++;
                maxCount = Math.Max(maxCount, currentCount);
            }
            else
            {
                currentCount = 1;
            }
        }

        return maxCount;
    }
}
