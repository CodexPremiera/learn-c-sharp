namespace Learn_C_Sharp.Lesson02_Variables;

public class Texts
{
    static void TextMain(string[] args)
    {
        /* STRING INTERPOLATION */
        string beginning = "Once upon a time,";
        string middle = "The kid climbed a tree";
        string end = "Everyone lived happily ever after.";
        Console.WriteLine($"{beginning} {middle} {end}");
        
        /* STRING LENGTH AND INDEXOF */
        string password = "a92301j2add";
        int passwordLength = password.Length;
        int passwordCheck = password.IndexOf("!");
        Console.WriteLine(
            $"The user password is {password}. Its length is {passwordLength} and it receives a {passwordCheck} check."
        );
        
        /* STRING SUBSTRING */
        string startStrand = "ATGCGATGAGCTTAC";
        
        int tga = startStrand.IndexOf("TGA");
        int startPoint = 0;
        int length = tga + 3;

        string dna = startStrand.Substring(startPoint, length);
        Console.WriteLine(dna.ElementAt(3));
        
        /* STRING MANIPULATION */
        Console.WriteLine(startStrand.ToLower());
        Console.WriteLine(startStrand.ToUpper());
    }
}