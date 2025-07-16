public class Translator
{
    public static void Run()
    {
        var englishToSpanish = new Translator();
        englishToSpanish.AddWord("House", "Casa");
        englishToSpanish.AddWord("Car", "Carro");
        englishToSpanish.AddWord("Plane", "Avion");
        englishToSpanish.AddWord("Fish", "Pez");
        englishToSpanish.AddWord("Sea", "Mar");
        Console.WriteLine(englishToSpanish.Translate("Car")); // carro
        Console.WriteLine(englishToSpanish.Translate("Plane")); // avion
        Console.WriteLine(englishToSpanish.Translate("Train")); // ??
        Console.WriteLine(englishToSpanish.Translate("Fish")); // pez
        Console.WriteLine(englishToSpanish.Translate("Sea")); // mar
    }

    private Dictionary<string, string> _words = new();

    /// <summary>
    /// Add the translation from 'from_word' to 'to_word'
    /// For example, in a english to german dictionary:
    /// 
    /// my_translator.AddWord("book","buch")
    /// </summary>
    /// <param name="fromWord">The word to translate from</param>
    /// <param name="toWord">The word to translate to</param>
    /// <returns>fixed array of divisors</returns>
    public void AddWord(string fromWord, string toWord)
    {
        // ADD YOUR CODE HERE
        _words[fromWord] = toWord;
    }

    /// <summary>
    /// Translates the from word into the word that this stores as the translation
    /// </summary>
    /// <param name="fromWord">The word to translate</param>
    /// <returns>The translated word or "???" if no translation is available</returns>
    public string Translate(string fromWord)
    {
        // ADD YOUR CODE HERE
        string newWord = "????";
        if (_words.ContainsKey(fromWord)) newWord = _words[fromWord];

        return newWord;
    }
}