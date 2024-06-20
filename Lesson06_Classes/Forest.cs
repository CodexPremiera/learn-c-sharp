using System.Diagnostics;

namespace Learn_C_Sharp.Lesson06_Classes;

public class Forest
{
    /* STATIC FIELDS AND PROPERTIES */
    private static int forestsCreated;
    static int ForestsCreated
    { get; private set; }
    
    private static string treeFacts;
    public static string TreeFacts
    { get; }
    
    /* FIELDS AND PROPERTIES */
    private string name;
    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    private string biome;
    public string Biome
    {
        get => biome;
        set
        {
            switch (value)
            {
                case "Tropical":
                case "Temperate":
                case "Boreal":
                    biome = value;
                    break;         
                default:
                    biome = "Unknown";
                    break;
            }
        }
    }

    private int trees;
    public int Trees
    {
        get => trees;
        set => trees = value;
    }
    
    /* AUTOMATIC PROPERTIES */
    public int Age
    {
        get;
        set;
    }
    
    /* PRIVATE SET */
    private double area;
    public double Area
    {
        get;
        private set;
    }
    
    
    /* CONSTRUCTOR */
    public Forest(string name, string biome)
    {
        Name = name;
        Biome = biome;
        Age = 0;
        Forest.ForestsCreated++;
    }
    
    /* STATIC CONSTRUCTOR */
    static Forest()
    {
        treeFacts = "Forests provide a diversity of ecosystem services including:\r\n  aiding in regulating climate.\r\n  purifying water.\r\n  mitigating natural hazards such as floods.\n";
        ForestsCreated = 0;
      
    }
    
    /* CONSTRUCTOR OVERLOADING */
    public Forest(string name) : this(name, "Unknown")
    {
        Console.WriteLine("Biome not specified. Value defaulted to 'Unknown'.");
    }
    
    /* METHODS */
    public int Grow()
    {
        Trees += 30;
        Age += 1;
        return Trees;
    }
    
    public int Burn()
    {
        Trees -= 20;
        Age += 1;
        return Trees;
    }
    
    /* STATIC METHODS */
    public static void PrintTreeFacts()
    {
        Console.WriteLine(TreeFacts);
    }

}