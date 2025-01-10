using WordFinderChallenge.Interfaces;

namespace WordFinderChallenge.Implementations;

public class WordFinder : IWordFinder
{
    private const int MaxSize = 64;
    private readonly char[,] _matrix;

    public char[,] Matrix => _matrix;

    public WordFinder(IEnumerable<string> matrixList)
    {
        var rowSize = matrixList.Count() > MaxSize ? MaxSize : matrixList.Count();
        var columnSize = matrixList.First().Length > MaxSize ? MaxSize : matrixList.First().Length;

        _matrix = new char[rowSize, columnSize];

        var characterList = matrixList.Select(x => x.ToCharArray()).ToList();

        for (var i = 0; i < _matrix.GetLength(0); i++)
        {
            for (var j = 0; j < _matrix.GetLength(1); j++)
            {
                _matrix[i, j] = characterList.ElementAt(i)[j];
            }
        }
    }

    public IEnumerable<string> Find(IEnumerable<string> wordStream)
    {
        var wordsDictionary = wordStream
            .Distinct()
            .ToDictionary(k => k, v => 0);

        foreach (var word in wordStream)
        {
            var countWordFound = GetCountWordFoundHorizontally(word) + GetCountWordFoundVertically(word);
            wordsDictionary[word] = countWordFound;
        }

        var result = wordsDictionary.OrderByDescending(x => x.Value).Take(10).Select(x => x.Key);

        return result;
    }

    private int GetCountWordFoundHorizontally(string word)
    {
        var countWordFound = 0;

        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            for (var j = 0; j <= _matrix.GetLength(1) - word.Length; j++)
            {
                if (IsHorizontalMatch(i, j, word))
                {
                    countWordFound++;
                }
            }
        }

        return countWordFound;
    }

    private bool IsHorizontalMatch(int row, int col, string word)
    {
        for (int j = 0; j < word.Length; j++)
        {
            if (_matrix[row, col + j] != word[j])
            {
                return false;
            }
        }

        return true;
    }

    private int GetCountWordFoundVertically(string word)
    {
        var countWordFound = 0;

        if (word.Length == 1)
        {
            return countWordFound;
        }

        for (int i = 0; i <= _matrix.GetLength(0) - word.Length; i++)
        {
            for (var j = 0; j < _matrix.GetLength(1); j++)
            {
                if (IsVerticalMatch(i, j, word))
                {
                    countWordFound++;
                }
            }
        }

        return countWordFound;
    }

    private bool IsVerticalMatch(int row, int col, string word)
    {
        for (int i = 0; i < word.Length; i++)
        {
            if (_matrix[row + i, col] != word[i])
            {
                return false;
            }
        }

        return true;
    }
}
