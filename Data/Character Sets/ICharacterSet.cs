namespace OnlinePasswordGenerator.Data;

public interface ICharacterSet {
    public bool IsEnabled {get; set;}
    public string Name {get;}
    public string Description {get;}
    public IEnumerable<char> GetChars();
}