namespace OnlinePasswordGenerator.Data;

public class SpaceSet : ICharacterSet {
    public bool IsEnabled {get; set;}
    public string Name => "Spaces";
    public string Description => " ";
    public IEnumerable<char> GetChars() {
        yield return ' ';
    }
}

public class WhitespaceSet : ICharacterSet {
    public bool IsEnabled {get; set;}
    public string Name => "Whitespace";
    public string Description => @" , \n, \t, \r";
    public IEnumerable<char> GetChars() {
        yield return ' ';
        yield return '\n';
        yield return '\t';
        yield return '\r';
    }
}