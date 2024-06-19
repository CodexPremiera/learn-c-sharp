namespace Learn_C_Sharp.Lesson05_Arrays;

public class Loops
{
    static void LoopsMain(string[] args)
    {
         /* WHILE LOOP */
         int emails = 20;  
      
         while (emails > 0)
         {
             emails--;
             Console.WriteLine($"one email deleted, {emails} left");
         }
      
         Console.WriteLine("INBOX ZERO ACHIEVED!");
         
         /* DO-WHILE LOOP */
         bool buttonClick = true;
         do
         {
             Console.WriteLine("BLARRRRRRRRR");
         } while (!buttonClick);
      
         Console.WriteLine("Time for a five minute break");
         
         /* FOR LOOP */
         for (int i = 1; i < 17; i++)
         {
             CreateTemplate(i);
         }
         
         /* FOREACH LOOP */
         string[] todo = { "respond to email", "make wireframe", "program feature", "fix bugs" };
      
         foreach (string task in todo) 
         {
             CreateTodoItem(task);
         }
    }
    
    static void CreateTemplate(int week)
    {
        Console.WriteLine($"Week {week}");
        Console.WriteLine("Announcements: \n \n \n ");
        Console.WriteLine("Report Backs: \n \n \n");
        Console.WriteLine("Discussion Items: \n \n \n");
    }
    
    static void CreateTodoItem(string item)
    {
        Console.WriteLine($"[] {item}");
    }
}