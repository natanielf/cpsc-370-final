namespace Cpsc370Final;

public class StoryParser
{
    private string _fileName;

    private List<string> _story;
    //constructor given a file name
    public StoryParser(string fileName)
    {
        _fileName = fileName;
        _story = new List<string>();
    }

    
    public List<string> ParseStoryFile()
    {
        List<string> parsedStory = new List<string>();

        return parsedStory;
    }
}