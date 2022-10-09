namespace OnlinePasswordGenerator.Data;

/* TEMPLATE
namespace OnlinePasswordGenerator.Data;

public class ContinentNounSet : IWordSet {
    public bool IsEnabled {get; set;}
    public string Name => "Continents";
    public string Description => "Continents on Earth";
    public IEnumerable<string> GetWords() {

    }
}
*/

public class ContinentNounSet : IWordSet {
    public bool IsEnabled {get; set;}
    public string Name => "Continents";
    public string Description => "Continents on Earth";
    public IEnumerable<string> GetWords() {
        yield return "Asia";
        yield return "Europe";
        yield return "Africa";
        yield return "South America";
        yield return "North America";
        yield return "Oceania";
        yield return "Antarctica";
    }
}