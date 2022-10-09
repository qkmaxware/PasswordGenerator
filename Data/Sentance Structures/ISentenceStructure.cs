namespace OnlinePasswordGenerator.Data;

public interface ISentenceStructure {
    public bool IsEnabled {get; set;}
    public string Name {get;}
    public string Description {get;}

    public string Replace(WordDictionary dict);
}