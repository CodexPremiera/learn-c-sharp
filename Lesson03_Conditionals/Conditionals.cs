namespace Learn_C_Sharp.Lesson03_Conditionals;

public class Conditionals
{
    static void Main(string[] args)
    {
        /* IF STATEMENTS */
        int socks = 3;
        
        if (socks <= 3)
            Console.WriteLine("Time to do laundry!");
        
        
        /* IF-ELSE STATEMENTS */
        int people = 10;
        string weather = "nice";

        if (people <= 10 && weather == "nice")
            Console.WriteLine("SaladMart");
        else
            Console.WriteLine("Soup N Sandwich");      
        
        
        /* ELSE-IF STATEMENTS */
        int guests = 0;

        if (guests >= 4) 
            Console.WriteLine("Catan");
        else if (guests >= 1) 
            Console.WriteLine("Innovation");
        else 
            Console.WriteLine("Solitaire");
        
        
        /* SWITCH STATEMENTS */
        Console.WriteLine("Enter a movie genre: ");
        string genre = Console.ReadLine();

        switch (genre)
        {
            case "Drama":
                Console.WriteLine("Citizen Kane");
                break;
            
            case "Comedy":
                Console.WriteLine("Duck Soup");
                break;
            
            case "Adventure":
                Console.WriteLine("King Kong");
                break;
            
            case "Horror":
                Console.WriteLine("Psycho");
                break;
            
            case "Science Fiction":
                Console.WriteLine("2001: A Space Odyssey");
                break;
            
            default:
                Console.WriteLine("No movie found");
                break;
        }
        
        
        /* TERNARY OPERATORS */
        Console.WriteLine( 
            people <= 10 && weather == "nice" ? 
                "SaladMart" : 
                "Soup N Sandwich"
        );
    }
}