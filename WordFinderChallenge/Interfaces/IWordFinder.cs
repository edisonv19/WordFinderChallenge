namespace WordFinderChallenge.Interfaces;

internal interface IWordFinder
{
    IEnumerable<string> Find(IEnumerable<string> wordStream);

    char[,] Matrix { get; }
}
