namespace OnlinePasswordGenerator.Data;

public class SeaNounSet : IWordSet {
    public bool IsEnabled {get; set;}
    public string Name => "Seas";
    public string Description => "Some of the seas on Earth";
    // List from https://en.wikipedia.org/wiki/List_of_seas
    public IEnumerable<string> GetWords() {
        yield return "Philippine Sea";
        yield return "Coral Sea";
        yield return "American Mediterranean Sea";
        yield return "Arabian Sea";
        yield return "Sargasso Sea";
        yield return "South China Sea";
        yield return "Weddell Sea";
        yield return "Caribbean Sea";
        yield return "Mediterranean Sea";
        yield return "Gulf of Guinea";
        yield return "Tasman Sea";
        yield return "Bay of Bengal";
        yield return "Bering Sea";
        yield return "Sea of Okhotsk";
        yield return "Gulf of Mexico";
        yield return "Gulf of Alaska";
        yield return "Barents Sea";
        yield return "Norwegian Sea";
        yield return "East China Sea";
        yield return "Hudson Bay";
        yield return "Greenland Sea";
        yield return "Somov Sea";
        yield return "Mar de Grau";
        yield return "Riiser-Larsen Sea";
        yield return "Sea of Japan";
        yield return "Argentine Sea";
        yield return "East Siberian Sea";
        yield return "Lazarev Sea";
        yield return "Kara Sea";
        yield return "Scotia Sea";
        yield return "Labrador Sea";
        yield return "Andaman Sea";
        yield return "Laccadive Sea";
        yield return "Irminger Sea";
        yield return "Solomon Sea";
        yield return "Mozambique Channel";
        yield return "Cosmonauts Sea";
        yield return "Banda Sea";
        yield return "Baffin Bay";
        yield return "Laptev Sea";
        yield return "Arafura Sea";
        yield return "Ross Sea";
        yield return "Chukchi Sea";
        yield return "Timor Sea";
        yield return "North Sea";
        yield return "Bellingshausen Sea";
        yield return "Beaufort Sea";
        yield return "Red Sea";
        yield return "Black Sea";
        yield return "Gulf of Aden";
        yield return "Yellow Sea";
        yield return "Baltic Sea";
        yield return "Caspian Sea";
        yield return "Libyan Sea";
        yield return "Mawson Sea";
        yield return "Levantine Sea";
        yield return "Java Sea";
        yield return "Gulf of Thailand";
        yield return "Celtic Sea";
        yield return "Gulf of Carpentaria";
        yield return "Celebes Sea";
        yield return "Tyrrhenian Sea";
        yield return "Sulu Sea";
        yield return "Cooperation Sea";
        yield return "Persian Gulf";
        yield return "Flores Sea";
        yield return "Gulf of Saint Lawrence";
        yield return "Bay of Biscay";
        yield return "Aegean Sea";
        yield return "Gulf of Anadyr";
        yield return "Molucca Sea";
        yield return "Oman Sea";
        yield return "Ionian Sea";
        yield return "Gulf of California";
        yield return "Balearic Sea";
        yield return "Adriatic Sea";
    }
}