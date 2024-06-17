namespace Learn_C_Sharp.Lesson04_Methods;

public class MethodOutputs
{
    static void MethodOutputsMain(string[] args)
    {
        /* RETURN TYPE METHODS */
        Console.WriteLine(DecoratePlanet("Jupiter"));
        
        /* OUT; THE RETURN OF MULTIPLE VALUES */
        string ageAsString = "102";
        string nameAsString = "Granny";
        
        int ageAsInt;
        bool outcome = Int32.TryParse(ageAsString, out ageAsInt);
        Console.WriteLine($"Conversion success is {outcome} yielding {ageAsInt}.");
        
        /* USING OUT */
        bool hasWhispered = false;
        string whisper = Whisper("RAWRRRRR!", out hasWhispered);
        Console.WriteLine($"{whisper} // I have whispered: {hasWhispered}");
    }
    
    static string DecoratePlanet(string name) 
    {
        return $"*.*.* Welcome to {name} *.*.*";
    }
    
    /* USING OUT */
    static string Whisper(string phrase, out bool wasWhisperCalled)
    {
        wasWhisperCalled = true;
        return phrase.ToLower();
    }
}