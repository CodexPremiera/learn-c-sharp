namespace Learn_C_Sharp.Lesson06_Classes;

public class Class
{
    static void Main(string[] args)
    {
        /* CLASS INSTANTIATION */
        Forest f = new Forest("Congo", "Tropical");
        f.Trees = 0;
      
        Console.WriteLine(f.Name);
        Console.WriteLine(f.Biome);
    }
}