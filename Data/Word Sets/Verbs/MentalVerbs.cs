namespace OnlinePasswordGenerator.Data;

public class MentalVerbSet : IWordSet {
    public bool IsEnabled {get; set;} = true;
    public string Name => "Mental";
    public string Description => "Intellectual processes that occur within the mind";
    public IEnumerable<string> GetWords() {
        yield return "concern";
        yield return "decide";
        yield return "dislike";
        yield return "doubt";
        yield return "feel";
        yield return "forget";
        yield return "hate";
        yield return "hear";
        yield return "hope";
        yield return "impress";
        yield return "know";
        yield return "learn";
        yield return "like";
        yield return "look";
        yield return "love";
        yield return "mind";
        yield return "notice";
        yield return "own";
        yield return "perceive";
        yield return "realize";
        yield return "recognize";
        yield return "remember";
        yield return "see";
        yield return "smell";
        yield return "surprise";
        yield return "prefer";
        yield return "promise";
        yield return "think";
        yield return "understand";
    }
}