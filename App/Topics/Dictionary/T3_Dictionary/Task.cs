namespace App.Topics.Dictionary.T3_Dictionary;

public static class DictionaryTasks
{
    public static System.Collections.Generic.List<System.Collections.Generic.KeyValuePair<string, int>>
        TopNWords(string text, int n)
    {
        if (n <= 0 || string.IsNullOrWhiteSpace(text))
        {
            return new List<KeyValuePair<string, int>>();
        }

        text = text.ToLowerInvariant();

        List<string> words = new List<string>();
        string currentWord = "";

        foreach (char c in text)
        {
            if (char.IsLetterOrDigit(c))
            {
                currentWord += c;
            }
            else if (!char.IsWhiteSpace(c) && currentWord.Length > 0)
            {
                words.Add(currentWord);
                currentWord = "";
            }
            else if (char.IsWhiteSpace(c) && currentWord.Length > 0)
            {
                words.Add(currentWord);
                currentWord = "";
            }
        }

        if (currentWord.Length > 0)
        {
            words.Add(currentWord);
        }

        Dictionary<string, int> count = new Dictionary<string, int>();
        foreach (string word in words)
        {
            if (count.ContainsKey(word))
            {
                count[word]++;
            }
            else
            {
                count[word] = 1;
            }
        }

        var sortedWords = count.ToList();
        sortedWords.Sort((pair1, pair2) =>
        {
            int countEqualise = pair2.Value.CompareTo(pair1.Value);
            if (countEqualise != 0)
            {
                return countEqualise;
            }
            return pair1.Key.CompareTo(pair2.Key);
        });

        if (sortedWords.Count > n)
        {
            return sortedWords.GetRange(0, n);
        }
        else
        {
            return sortedWords;
        }

    }
}