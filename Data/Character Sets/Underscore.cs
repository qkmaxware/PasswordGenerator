namespace OnlinePasswordGenerator.Data;

public class UnderscoreSet : ICharacterSet {
    public bool IsEnabled {get; set;}
    public string Name => "Underscore";
    public string Description => "_";
    public IEnumerable<char> GetChars() {
        yield return '_';
    }
}