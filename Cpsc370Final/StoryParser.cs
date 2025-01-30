namespace Cpsc370Final;

public class StoryParser
{
    private string _fileName;

    //constructor given a file name
    public StoryParser(string fileName)
    {
        _fileName = fileName;
    }
    
    public string[] ParseStoryFile()
    {
        //read the file and save it all to a string
        string storyText = File.ReadAllText(_fileName);
        
        //split the string into an array of strings
        string[] storyArray = storyText.Split(" ");
        
        for (int i = 0; i < storyArray.Length; i++)
        {
            Console.WriteLine(storyArray[i]);
        }
        return storyArray;
    }
    
    
}