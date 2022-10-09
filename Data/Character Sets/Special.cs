namespace OnlinePasswordGenerator.Data;

public class SpecialSet : ICharacterSet {
    public bool IsEnabled {get; set;}
    public string Name => "Special";
    public string Description => "!, $, %, &, ...";
    public IEnumerable<char> GetChars() {
        yield return '!';
        yield return '#';
        yield return '$';
        yield return '%';
        yield return '&';
        yield return '*';
        yield return '+';
        yield return '=';
        yield return '?';
        yield return '@';
    }
}