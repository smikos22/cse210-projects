public class Game
{
    private List<Goals> goals = new List<Goals>();
    private string fileName = "goals.txt";
    private int totalPoints;
    public Game()
    {
         totalPoints = 0;
    }
    public int GetTotalPoints()
    {
        return totalPoints;
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
        SimpleGoals goal = new SimpleGoals(goalName, goalDescription, goalPoints, false);
        goals.Add(goal);

        }
        else if (goalType == 2)
        {
            EternalGoals goal = new EternalGoals(goalName, goalDescription, goalPoints);
            goals.Add(goal);
        }
        else if (goalType == 3)
        {
            Console.Write("Enter how many times this goal needs to be accomplished for a bonus: ");
            int timesToDo = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing the goal it that many times? ");
            int bonusScore = int.Parse(Console.ReadLine());
            ChecklistGoals goal = new ChecklistGoals(goalName, goalDescription, goalPoints, bonusScore, timesToDo, 0);
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
       //    goal.DisplayGoal(count);
 //      Console.WriteLine(goal.ToCSVRecord());
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
        //calculate the points the user has.
//        int totalPoints = 0;
 //       foreach (Goals goal in goals)
 //       {
 //           totalPoints += goal.GetScore();
 //       }
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(totalPoints);
            foreach (Goals goal in goals)
            {
                outputFile.WriteLine(goal.ToCSVRecord());
            }
        }
/*        string fileToSave = DisplayGetGoalFile();
        List<string> saveGoals = new List<string>();
        totalPoints = goals.Sum(g => g._score);
        saveGoals.Add(totalPoints.ToString());
        foreach (Goals goal in goals)
        {
            saveGoals.Add(goal.ToCSVRecord());
        }
        SaveLoadCSV.SaveToCSV(saveGoals, fileToSave);
        Console.WriteLine("Goals saved. ");

*/        
    }
    //load from .txt file to goals
    public void LoadGoals()
    {
    string[] lines = System.IO.File.ReadAllLines(fileName);
    int cnt = 0;
    foreach (string line in lines)
    {
        if (cnt == 0)
        {
            Console.WriteLine(line);
            totalPoints = int.Parse(line);
        }
        else
        {
            string[] goalParts = line.Split(":");
            string goalType = goalParts[0];
            string goalData = goalParts[1];

            if (goalType == "SimpleGoal")
            {
                string[] goalDataParts = goalData.Split(",");
                SimpleGoals goal = new SimpleGoals(goalDataParts[0], goalDataParts[1], int.Parse(goalDataParts[2]), bool.Parse(goalDataParts[3]));

                goals.Add(goal);

            }
            else if (goalType == "EternalGoal")
            {
                string[] goalDataParts = goalData.Split(",");
                EternalGoals goal = new EternalGoals(goalDataParts[0], goalDataParts[1], int.Parse(goalDataParts[2]));

                goals.Add(goal);


            }
            else if (goalType =="ChecklistGoal")
            {
                string[] s = goalData.Split(",");
                ChecklistGoals goal = new ChecklistGoals(s[0], s[1], int.Parse(s[2]), int.Parse(s[3]), int.Parse(s[4]), int.Parse(s[5]));
                goals.Add(goal);
            }
            else
            {
                Console.WriteLine("Error: GOAL TYPE NOT DETECTED");
            }
        }
        cnt += 1;
    }
}
    public void RecordEvent()
    {
        Console.WriteLine("The goals are: ");
        int cnt = 0;
        foreach(Goals goal in goals)
        {
            cnt += 1;
            Console.WriteLine($"{cnt}. {goal.GetGoalName()}");
        }
        Console.Write("Which goal did you accomplish? ");
        int goalSelected = int.Parse(Console.ReadLine());
        cnt = 0;
        foreach(Goals goal in goals)
        {
            cnt += 1;
            if (cnt == goalSelected)
            {
                string goalType = goal.GetGoalType();
                goal.CompleteGoal();

                if (goalType == "ChecklistGoal")
                {
                    if (goal.GetisComplete())
                    {
                        Console.WriteLine($"Congratulations! You have earned {goal.GetScore() + goal.GetBonusScore()} points!");
                        totalPoints += goal.GetScore() + goal.GetBonusScore();
                        Console.WriteLine($"You now have {totalPoints} points.");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You have earned {goal.GetScore()} points.");
                        totalPoints += goal.GetScore();
                        Console.WriteLine($"You now have {totalPoints} points.");

                    }
                }
                else
                {
                //goal.CompleteGoal();
                    Console.WriteLine($"Congratulations! You have earned {goal.GetScore()} points!");
                    totalPoints += goal.GetScore();
                    Console.WriteLine($"You now have {totalPoints} points.");
                }
            }
        }
    }

}