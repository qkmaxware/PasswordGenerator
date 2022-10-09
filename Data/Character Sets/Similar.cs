namespace OnlinePasswordGenerator.Data;

public class SimilarSet : ICharacterSet {
    public bool IsEnabled {get; set;}
    public string Name => "Similar";
    public string Description => "0, O, l, 1, ...";
    public IEnumerable<char> GetChars() {
        yield return '0'; yield return 'O';
        yield return 'l'; yield return '1';
    }
}
