namespace OnlinePasswordGenerator.Data;

public class RiversNounSet : IWordSet {
    public bool IsEnabled {get; set;}
    public string Name => "Rivers";
    public string Description => "Some of the rivers on Earth";
    public IEnumerable<string> GetWords() {
        yield return "Nile";
        yield return "Amazon";
        yield return "Mississippi-Missouri-Red Rock";
        yield return "Chang Jiang";
        yield return "Ob";
        yield return "Huang He";
        yield return "Yenisei";
        yield return "Parana";
        yield return "Irtish";
        yield return "Zaire";
        yield return "Heilong";
        yield return "Lena";
        yield return "Mackenzie";
        yield return "Niger";
        yield return "Mekong";
        yield return "Mississippi";
        yield return "Missouri";
        yield return "Volga";
        yield return "Madeira";
        yield return "Purus";
        yield return "Sao Francisco";
        yield return "Yukon";
        yield return "St. Lawrence";
        yield return "Rio Grande";
        yield return "Brahmaputra";
        yield return "Indus";
        yield return "Danube";
        yield return "Euphrates";
        yield return "Darling";
        yield return "Zambezi";
        yield return "Murray";
        yield return "Nelson";
        yield return "Paraguay";
        yield return "Ural";
        yield return "Ganges";
        yield return "Amu Darya";
        yield return "Japura";
        yield return "Salween";
        yield return "Arkansas";
        yield return "Colorado";
        yield return "Dnieper";
        yield return "Ohio-Allegheny";
        yield return "Irrawaddy";
        yield return "Orange";
        yield return "Orinoco";
        yield return "Sungari";
        yield return "Saskatchewan";
        yield return "Peace";
        yield return "Tigris";
    }
}