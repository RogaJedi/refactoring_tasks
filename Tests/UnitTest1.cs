using NUnit.Framework;

[TestFixture]
public class SubstringFinderTests
{
    [Test]
    public void Test_SubstringFound()
    {
        var finder = new SubstringFinder();
        int result = finder.FindIndexOfSubstring("hello world this is a test string", "test");
        Assert.That(result, Is.EqualTo(22));
    }

    [Test]
    public void Test_SubstringNotFound()
    {
        var finder = new SubstringFinder();
        int result = finder.FindIndexOfSubstring("abcdef", "xyz");
        Assert.That(result, Is.EqualTo(-1));
    }
}