namespace Learn_C_Sharp.Lesson04_Methods;

public class Methods
{
    static void MethodsMain(string[] args)
    {
        /* USES OPTIONAL PARAMETERS */
        VisitPlanets();
        
        /* POSITIONAL ARGUMENTS */
        VisitPlanets("gallant", "Commander", 5, 6.9);
        
        /* NAMED ARGUMENTS */
        VisitPlanets(numberOfPlanets: 2);
        VisitPlanets(numberOfPlanets: 2, name: "Commander");
        
        /* METHOD OVERLOADING */
        NamePets();
        NamePets("Vader", "Bruce");
        NamePets("Sova", "Luna", "Dexie");
        
    }

    static void VisitPlanets(
        string adjective = "brave",
        string name = "Cosmonaut", 
        int numberOfPlanets = 0,
        double gForce = 4.2)
    {
        Console.WriteLine($"Welcome back, {adjective} {name}.");
        Console.WriteLine($"You visited {numberOfPlanets} new planets...");
        Console.WriteLine($"...while experiencing a g-force of {gForce} g!");
    }
    
    /* METHOD OVERLOADING */
    static void NamePets()
    {
        Console.WriteLine("Aw, you have no spacefaring pets :(");
    }
    
    static void NamePets(string name1, string name2)
    {
        Console.WriteLine($"Your pets {name1} and {name2} will be joining your voyage across space!");
    }
    
    static void NamePets(string name1, string name2, string name3)
    {
        Console.WriteLine($"Your pets {name1}, {name2}, and {name3} will be joining your voyage across space!");
    }
}