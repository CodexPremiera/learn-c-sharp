namespace Learn_C_Sharp.Lesson02_Variables;

class Program
{
    static void VariableMain(string[] args)
    {
        // Create Variables
        var name = "Shadow";
        string breed = "Golden Retriever";
        int age = 5;
        double weight = 65.22;
        bool spayed = true;

        // Print variables to the console
        Console.WriteLine(name);
        Console.WriteLine(breed);
        Console.WriteLine(age);
        Console.WriteLine(weight);
        Console.WriteLine(spayed);
            
        // Casting 
        Console.Write("Enter your favorite number!: ");
        double faveNumber = Convert.ToDouble(Console.ReadLine());
            
        // this is not possible because it loses data: 
        // int myFaveInt = faveNumber;
            
        Console.WriteLine($"Your favorite number is {faveNumber}");
    }
}