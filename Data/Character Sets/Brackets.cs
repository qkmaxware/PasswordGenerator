namespace OnlinePasswordGenerator.Data;

public class BracketSet : ICharacterSet {
    public bool IsEnabled {get; set;}
    public string Name => "Brackets";
    public string Description => "(, {, [, ...";
    public IEnumerable<char> GetChars() {
        yield return '(';
        yield return ')';
        yield return '{';
        yield return '}';
        yield return '[';
        yield return ']';
        yield return '<';
        yield return '>';
        yield return '>';
    }
}