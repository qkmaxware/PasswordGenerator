namespace OnlinePasswordGenerator.Data;

public class OceanNounSet : IWordSet {
    public bool IsEnabled {get; set;}
    public string Name => "Ocean";
    public string Description => "Oceans on Earth";
    public IEnumerable<string> GetWords() {
        yield return "Pacific Ocean";
        yield return "Atlantic Ocean";
        yield return "Indian Ocean";
        yield return "Southern Ocean";
        yield return "Arctic Ocean";
    }
}