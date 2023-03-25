public class SimpleGoals : Goals
{
    public SimpleGoals(string goalName, string description, int score, bool isComplete): base(goalName, description, score, isComplete)
    {

    }

    public void ShowGoal()
    {
        Console.WriteLine($"{_goalName}: {_description}");
        Console.WriteLine($"Worth {_score} points");
    }
    public override int GetBonusScore()
    {
        return 0;
    }

    public override void DisplayGoal(int position)
    {
        string mark;
        if (_isComplete == true)
        {
            mark = "X";
        }
        else
        {
            mark = " ";
        }
        Console.WriteLine($"{position}. [{mark}] {_goalName} ({_description})");
    }
    public override string ToCSVRecord()
    {
        return $"SimpleGoal:{base.ToCSVRecord()},{_isComplete}";
    }
    public override string GetGoalType()
    {
        return "SimpleGoal";
    }
    public override void CompleteGoal()
    {
        _isComplete = true;
    }

}