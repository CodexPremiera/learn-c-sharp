using System.Collections;

namespace Learn_C_Sharp.Lesson05_Arrays;

public class Arrays
{
    static void ArraysMain(string[] args)
    {
        /* ARRAY DECLARATION */
        string[] summerStrut = new string[]
        {
            "Juice", "Missing U", "Raspberry Beret", "New York Groove", "Make Me Feel", "Rebel Rebel", "Despacito", "Los Angeles"
        };
        int[] ratings = { 5, 4, 4, 3, 3, 5, 5, 4 };
      
        /* ARRAY LENGTH */
        if (summerStrut.Length == 8)
            Console.WriteLine("SummerStrut playlist is ready to go!");
        else if (summerStrut.Length > 8)
            Console.WriteLine("Too many songs!");
        else
            Console.WriteLine("Add some songs!");
        
        /* ARRAY EDIT */
        summerStrut[7] = "I Like It";
        ratings[7] = 3;
        
        /* ARRAY ACCESS */
        int index = 4;
        Console.WriteLine($"You rated the song {summerStrut[index]} {ratings[index]} stars.");
        
        /* BUILT-IN METHODS */
        int threeRating = Array.IndexOf(ratings, 3);
        Console.WriteLine($"Song number {threeRating + 1} is rated three stars.");
      
        string? findName = Array.Find(summerStrut, song => song.Length > 10);
      
        Console.WriteLine($"The first song that has more than 10 characters in the title is {findName}.");
      
        Array.Sort(summerStrut);
        string firstSong = summerStrut[0];
        string lastSong = summerStrut[7];
        Console.WriteLine($"The first song in the playlist is now {firstSong}.");
        Console.WriteLine($"The last song in the playlist is now {lastSong}.");
    }
}