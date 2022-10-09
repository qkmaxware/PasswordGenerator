namespace OnlinePasswordGenerator.Data;

public class UppercaseLettersSet : ICharacterSet {
    public bool IsEnabled {get; set;} = true;
    public string Name => "Uppercase Letters";
    public string Description => "A, B, C, ...";

    public IEnumerable<char> GetChars() {
        yield return 'A';
        yield return 'B';
        yield return 'C';
        yield return 'D';
        yield return 'E';
        yield return 'F';
        yield return 'G';
        yield return 'H';
        yield return 'I';
        yield return 'J';
        yield return 'K';
        yield return 'L';
        yield return 'M';
        yield return 'N';
        yield return 'O';
        yield return 'P';
        yield return 'Q';
        yield return 'R';
        yield return 'S';
        yield return 'T';
        yield return 'U';
        yield return 'V';
        yield return 'W';
        yield return 'X';
        yield return 'Y';
        yield return 'Z';
    }
}

public class LowercaseLettersSet : ICharacterSet {
    public bool IsEnabled {get; set;} = true;
    public string Name => "Lowercase Letters";
    public string Description => "a, b, c, ...";
    public IEnumerable<char> GetChars() {
        yield return 'a';
        yield return 'b';
        yield return 'c';
        yield return 'd';
        yield return 'e';
        yield return 'f';
        yield return 'g';
        yield return 'h';
        yield return 'i';
        yield return 'j';
        yield return 'k';
        yield return 'l';
        yield return 'm';
        yield return 'n';
        yield return 'o';
        yield return 'p';
        yield return 'q';
        yield return 'r';
        yield return 's';
        yield return 't';
        yield return 'u';
        yield return 'v';
        yield return 'w';
        yield return 'x';
        yield return 'y';
        yield return 'z';
    }
}