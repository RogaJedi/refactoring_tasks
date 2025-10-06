
using System;
using System.Diagnostics;
using App.Utils;

namespace App
{
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
}