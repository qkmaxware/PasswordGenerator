namespace OnlinePasswordGenerator.Data;

public class MinusSet : ICharacterSet {
    public bool IsEnabled {get; set;}
    public string Name => "Minus";
    public string Description => "-";
    public IEnumerable<char> GetChars() {
        yield return '-';
    }
}

public class DashesSet : ICharacterSet {
    public bool IsEnabled {get; set;}
    public string Name => "Dashes";
    public string Description => "-, –, —, ~";
    public IEnumerable<char> GetChars() {
        yield return '-';
        yield return '–';
        yield return '—';
        yield return '~';
    }
}