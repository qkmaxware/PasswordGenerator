namespace OnlinePasswordGenerator.Data;

public class DigitsSet : ICharacterSet {
    public bool IsEnabled {get; set;} = true;
    public string Name => "Digits";
    public string Description => "0, 1, 2, ...";
    public IEnumerable<char> GetChars() {
        yield return '1';
        yield return '2';
        yield return '3';
        yield return '4';
        yield return '5';
        yield return '6';
        yield return '7';
        yield return '8';
        yield return '9';
        yield return '0';
    }
}