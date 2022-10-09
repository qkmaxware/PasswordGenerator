namespace OnlinePasswordGenerator.Data;

public interface IWordSet {
    public bool IsEnabled {get; set;}
    public string Name {get;}
    public string Description {get;}
    public IEnumerable<string> GetWords();
}