namespace Learn_C_Sharp.Lesson03_Conditionals;

public class Logic
{
    static void LogicMain(string[] args)
    {
        /* BOOL VARIABLE */
        double timeToDinner = 4;
        double distance = 95;
        double rate = 30;

        double tripDuration = distance / rate;
        bool answer = tripDuration <= timeToDinner;
        Console.WriteLine(answer);
        
        /* LOGICAL OPERATORS */
        bool beach = true;
        bool hiking = false;
        bool city = true;

        bool yourNeeds = beach && city;
        bool friendNeeds = beach || hiking;

        bool tripDecision = yourNeeds && friendNeeds;
        Console.WriteLine(tripDecision);
    }
}