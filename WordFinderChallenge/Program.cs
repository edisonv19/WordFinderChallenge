using WordFinderChallenge.Implementations;
using WordFinderChallenge.Interfaces;

namespace WordFinderChallenge;

internal class Program
{
    static void Main(string[] args)
    {
        var stringEntry = new List<string>
        {
            "abcdc",
            "fgwio",
            "chill",
            "pqnsd",
            "uvdxy",
        };

        IWordFinder wordFinder = new WordFinder(stringEntry);
        var streamWords = new List<string> { "cold", "wind", "snow", "chill" };
        var top10MostRepeatedWords = wordFinder.Find(streamWords);

        PrintFinalScreen(wordFinder.Matrix, top10MostRepeatedWords);

        // Another Example
        stringEntry =
        [
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
            "abcdefghijkmlnopqrstuvwxyz0123456789abcdefghijkmlnopqrstuvwxyz0123456789",
        ];

        wordFinder = new WordFinder(stringEntry);
        streamWords =
        [
            "aaaaaa",
            "kkkkk",
            "123",
            "f",
            "hhhhhhhhhhh",
            "yyyyyyyyyyyy",
            "ggggggggggggg",
            "ttttttttttttttttttttttttt",
            "nnnnnnnnnn",
            "ccccccccc",
            "xxxxxxxx",
            "zzzzzzz",
            "lllll",
            "pppp",
            "pppp",
            "00",
            "f",
            "6666666666666666666666666666666666666666666666666666666666666666"
        ];
        top10MostRepeatedWords = wordFinder.Find(streamWords);

        PrintFinalScreen(wordFinder.Matrix, top10MostRepeatedWords);
    }
    
    private static void PrintFinalScreen(char[,] matrix, IEnumerable<string> top10MostRepeatedWords)
    {
        Console.WriteLine("Matrix: ");
        PrintMatrix(matrix);
        Console.WriteLine();
        Console.WriteLine("Top 10 Most repeated words:");
        PrintArray(top10MostRepeatedWords);
        Console.WriteLine();
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine();
    }

    private static void PrintArray(IEnumerable<string> array)
    {
        foreach (string item in array)
        {
            Console.Write(item + " ");
        };
        Console.WriteLine();
    }

    private static void PrintMatrix(char[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
