namespace OnlinePasswordGenerator.Data;

public class SubjectVerbPredicate : BaseRecursiveGenerator, ISentenceStructure {
    public bool IsEnabled {get; set;} = true;
    public string Name => "Subject Verb Predicate";
    public string Description => "Simple subject verb predicate substitution";

    private List<string> introducers = new List<string> {
        "",
        "<a>",
        "the"
    };
    private List<string> templates = new List<string>(){
        "@intro @noun @verb(s)",
        "@intro @noun @verb @preposition @noun",
    };

    public string Replace(WordDictionary dict) {
        var phrases = new Dictionary<string, List<string>> {
            {"intro", introducers},
            {"adjective", dict.Adjectives ?? new List<string>()},
            {"noun", dict.Nouns ?? new List<string>()},
            {"preposition", dict.Prepositions ?? new List<string>()},
            {"adverb", dict.Adverbs ?? new List<string>()},
            {"verb", dict.Verbs ?? new List<string>()},
        };

        return this.Generate(templates, phrases);
    }
}