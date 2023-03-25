public class Game
{
    private List<Goals> goals = new List<Goals>();
    private int totalPoints = 0;
    public Game()
    {
        totalPoints = 0;
    }
    public void CreateGoal()
    {
            //    string startMessage = "The types of Goals are:";
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine(" 1. Simple Goal ");
        Console.WriteLine(" 2. Eternal Goal ");
        Console.WriteLine(" 3. Checklist Goal ");
        int goalType = int.Parse(Console.ReadLine());

        Console.Write("Enter the name of the goal: ");
        string goalName = Console.ReadLine();
        Console.Write("Enter the description of the goal: ");
        string goalDescription = Console.ReadLine();
        Console.Write("Enter the points for the goal: ");
        int goalPoints = int.Parse(Console.ReadLine());
 
        if (goalType == 1)
        {
        SimpleGoals goal = new SimpleGoals(goalName, goalDescription, goalPoints);
        goals.Add(goal);

        }
 

    }
    public void ListGoals()
    {
        int count = 0;
        foreach (Goals goal in goals)
        {
            count++;
            goal.DisplayGoal(count);
        }
    }

    //write goals to .txt file
    public void SaveGoals()

    {
        if (goals.Count() == 0)
        {
            Console.WriteLine("There are no goals to save. ");
            return;
        }
        string fileToSave = DisplayGetGoalFile();
        List<string> saveGoals = new List<string>();
        totalPoints = goals.Sum(g => g._score);
        saveGoals.Add(totalPoints.ToString());
        foreach (Goals goal in goals)
        {
            saveGoals.Add(goal.ToCSVRecord());
        }
        SaveLoadCSV.SaveToCSV(saveGoals, fileToSave);
        Console.WriteLine("Goals saved. ");

        
    }
    //load from .txt file to goals
    public void LoadGoals()
{
    string fileToLoad = DisplayGetGoalFile();
    List<string> loadedGoals = SaveLoadCSV.LoadFromCSV(fileToLoad);

    if (loadedGoals == null)
    {
        Console.WriteLine("Failed to load goals from file.");
        return;
    }

    goals.Clear();
    for (int i = 1; i < loadedGoals.Count(); i++)
    {
        string[] fields = loadedGoals[i].Split(',');
        if (fields.Length < 4)
        {
            Console.WriteLine($"Invalid goal record: {loadedGoals[i]}");
            continue;
        }

        int goalType = int.Parse(fields[0]);
        string goalName = fields[1];
        string goalDescription = fields[2];
        int goalPoints = int.Parse(fields[3]);

        switch (goalType)
        {
            case 1:
                SimpleGoals simpleGoal = new SimpleGoals(goalName, goalDescription, goalPoints);
                goals.Add(simpleGoal);
                break;
            // add cases for other types of goals
            default:
                Console.WriteLine($"Unknown goal type: {goalType}");
                break;
        }
    }
    Console.WriteLine($"Loaded {goals.Count()} goals.");
}
private string DisplayGetGoalFile()
{
    Console.Write("Enter file name (without extension): ");
    string fileName = Console.ReadLine();
    return $"{fileName}.txt";
}


}