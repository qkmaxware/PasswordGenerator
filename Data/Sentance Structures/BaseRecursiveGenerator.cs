using System.Text.RegularExpressions;

namespace OnlinePasswordGenerator.Data;

public abstract class BaseRecursiveGenerator {

    private static string pluralize(string value) {
        if (value.Length < 1)
            return value;

        var last_letter = value[value.Length - 1];
        switch (last_letter) {
            case 's':
            case 'h':
            case 'x':
            case 'z':
                return value + "es";
            default:
                return value + "s";
        }
    }

    private string Random(List<string> src) {
        var index = System.Security.Cryptography.RandomNumberGenerator.GetInt32(0, src.Count);
        return src[index];
    }
    protected string Generate(List<string> templates, Dictionary<string, List<string>> phrases) {
        var template = Random(templates);
        return Generate(template, phrases);
    }

    public int MaxRecursiveDepth = 1500;
    private static Regex replacement = new Regex(@"\@[\w-]+(?:\(s\))?");
    private static Regex an = new Regex(@"\<an?\>(\s*\w)?");

    private string Generate(string template, Dictionary<string, List<string>> Phrases) {
        // Generate
        // 2. While subcomponents exist, substitute
        int count = 0;
        while (replacement.IsMatch(template) && count < MaxRecursiveDepth) {
            count++;
            template = replacement.Replace(template, (match) => {
                var property = match.Value.Substring(1); // without the @
                var plural = false;
                if (property.EndsWith("(s)")) {
                    plural = true;
                    property = property.Substring(0, property.Length - 3);
                }

                if (Phrases.ContainsKey(property)) {
                    var thing = Random(Phrases[property]);
                    if (plural) {
                        thing = pluralize(thing);
                    }
                    return thing;
                } else {
                    return string.Empty;
                }
            });
        }

        // 3. Cleanup a/an
        template = an.Replace(template, (match) => {
            // Get next letter
            var next_letter = match.Groups[1]?.Value?.Trim();
            if (next_letter == null)
                return string.Empty; // no next character, delete this <an>
                
            // Determine if 'a' or 'an' should be used
            var letter = next_letter.ToLower();
			switch (letter) {
				case "a":
				case "e":
				case "i":
				case "o":
				case "u":
					return "an" + match.Groups[1].Value; // is a vowel
				default: 
					return "a"  + match.Groups[1].Value; // is a consonant
			};
        });

        // 4. Capitalize first letter
        template = char.ToUpper(template[0]).ToString() + template.Substring(1);

        return template;
    }
}