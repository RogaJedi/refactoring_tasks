using System;

namespace App.Utils
{
    public class SubstringFinder
{
    public int FindIndexOfSubstring(string text, string pattern)
    {
        for (int i = 0; i <= text.Length - pattern.Length; i++)
        {
            if (IsMatch(text, pattern, i))
                return i;
        }
        return -1;
    }

    private bool IsMatch(string text, string pattern, int startIndex)
    {
        for (int j = 0; j < pattern.Length; j++)
        {
            if (text[startIndex + j] != pattern[j])
                return false;
        }
        return true;
    }
}
}
