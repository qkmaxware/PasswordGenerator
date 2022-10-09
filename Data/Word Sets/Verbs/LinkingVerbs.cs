namespace OnlinePasswordGenerator.Data;

public class LinkingVerbSet : IWordSet {
    public bool IsEnabled {get; set;} = true;
    public string Name => "Linking";
    public string Description => "State of being, condition, or relationship";
    public IEnumerable<string> GetWords() {
        yield return "am";
        yield return "appear";
        yield return "are";
        yield return "being";
        yield return "feel";
        yield return "grow";
        yield return "is";
        yield return "look";
        yield return "remain";
        yield return "seem";
        yield return "smell";
        yield return "sound";
        yield return "stay";
        yield return "taste";
        yield return "turn";
        yield return "was";
        yield return "were";
    }
}