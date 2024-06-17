namespace Learn_C_Sharp.Lesson04_Methods;

public class AlternateExpressions
{
    static void AlternateExpressionsMain(string[] args)
    {
        /* USING ARROW FUNCTIONS */
        Welcome("Earth");
        double days = 500;
        double rotations = DaysToRotations(days);
        Console.WriteLine($"In {days} days, the Earth has rotated {rotations} time(s).");
        
        /* METHODS AS ARGUMENTS */
        string[] adjectives = {"rocky", "mountainous", "cosmic", "extraterrestrial"};
        string? firstLongAdjective = Array.Find(adjectives, IsLong);
        Console.WriteLine($"The first long word is: {firstLongAdjective}.");
        
        /* LAMBDA EXPRESSION */
        bool? longAdjectiveExists = Array.Exists(adjectives, word => word.Length > 8);
        Console.WriteLine($"Does a long word exist? {longAdjectiveExists}.");
    }
    
    /* ARROW FUNCTIONS */
    static double DaysToRotations(double days) => days / 365;
    
    static void Welcome(string planet) => Console.WriteLine($"Welcome to {planet}!");
    
    static bool IsLong(string word) => word.Length > 8;
}