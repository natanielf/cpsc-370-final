using NuGet.Frameworks;

namespace Cpsc370Final.Tests;

public class UnitTest1
{
    [Fact]
    public void ParseDefaultWordDictionaryJsonFile()
    {
        WordParser wordParser = new WordParser();
        Dictionary<string, List<string>> wordDictionary = wordParser.GetWordDictionary();
        Assert.NotNull(wordDictionary);
    }

    [Fact]
    public void ParseStoryFile()
    {
        StoryParser storyParser = new StoryParser("DefaultStory.txt");
        string[] storyArray = storyParser.ParseStoryFile();
        string[] expectedStoryArray = ["This", " ", "is", " ", "the", " ", "ADJECTIVE", " ", "story", ",", " ", "everybody", "."];
        Assert.NotNull(storyArray);
        Assert.Equal(expectedStoryArray, storyArray);
    }

    [Fact]
    public void ParseDefaultStoryFileWhenGivenFileDoesNotExist()
    {
        StoryParser storyParser = new StoryParser("Fake.txt");
        string[] storyArray = storyParser.ParseStoryFile();
        string[] expectedStoryArray = ["This", " ", "is", " ", "the", " ", "ADJECTIVE", " ", "story", ",", " ", "everybody", "."];
        Assert.NotNull(storyArray);
        Assert.Equal(expectedStoryArray, storyArray);
    }

    [Theory]
    [InlineData (new string[] {"I", " ", "am", " ", "PLACE"}, "I am PLACE")]
    [InlineData (new string[] {"I", " ", "am", " ", "PERSON"}, "I am PERSON")]
    [InlineData (new string[] {"I", " ", "am", " ", "EXCLAMATION"}, "I am EXCLAMATION")]
    public void ReplaceStoryTemplate (string[] templateStory, string finalStory)
    {
        WordParser wordParser = new WordParser("DefaultWords.json");
        WordDictionary wordDictionary = wordParser.GetWordDictionary();
        MadLib madLib = new MadLib(templateStory, wordDictionary);
        madLib.GenerateFinalStory();
        string finalTestStory = madLib.GetFinalStory();
        Assert.NotEqual(finalTestStory, finalStory);
    }

}