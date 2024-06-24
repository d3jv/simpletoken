using System.Text;

namespace SimpleToken;

public class SimpleTokenGenerator
{
    private static readonly string _vowels = "aeiouy";
    private static readonly string _consonants = "qwrtzpsdfghjklxcvbnm";

    private readonly Random _rng; 

    public SimpleTokenGenerator() : this(new Random())
    {
    }

    public SimpleTokenGenerator(int seed) : this(new Random(seed))
    {
    }

    public SimpleTokenGenerator(Random rng)
    {
        _rng = rng;
    }

    /// <summary>
    /// Creates a simple random token of the specified length
    /// </summary>
    /// <param name="length">
    /// Desired length of the token. Default is 10.
    /// </param>
    /// <returns>Simple token of the specified size</returns>
    public string GetToken(uint length = 10)
    {
        var sb = new StringBuilder();

        for (int i = 0; i < length; ++i) {
            if (i % 2 == 0) {
                sb.Append(GetRandomConsonant());
            } else {
                sb.Append(GetRandomVowel());
            }
        }

        return sb.ToString();
    }

    private char GetRandomVowel()
    {
        return _vowels[_rng.Next(_vowels.Length - 1)];
    }

    private char GetRandomConsonant()
    {
        return _consonants[_rng.Next(_consonants.Length - 1)];
    }
}