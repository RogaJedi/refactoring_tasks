
using System;
using System.Diagnostics;

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

class Program
{
    static void Main()
    {
        string text = "hello world this is a test string";
        string pattern = "test";
        var finder = new SubstringFinder();

        var sw = Stopwatch.StartNew();
        int index = finder.FindIndexOfSubstring(text, pattern);
        sw.Stop();

        Console.WriteLine($"Индекс подстроки: {index}");
        Console.WriteLine($"Время: {sw.ElapsedTicks} тиков");
    }
}